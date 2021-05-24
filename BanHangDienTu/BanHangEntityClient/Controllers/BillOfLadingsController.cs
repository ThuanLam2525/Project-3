using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BanHangEntityClient.Models;
using Newtonsoft.Json;

namespace BanHangEntityClient.Controllers
{
    public class BillOfLadingsController : Controller
    {
        private ThietBiDienTuEntities db = new ThietBiDienTuEntities();

        public ActionResult Thanhtoan()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Thanhtoan(string Nguoinhan, string Diachi, decimal Sum)
        {
            List<CartDv> cartdv = new List<CartDv>();
            List<CartCb> cartcb = new List<CartCb>();
            if (Session["CartDv"] != null)
            {
                cartdv = (List<CartDv>)Session["CartDv"];
                foreach(CartDv dv in cartdv)
                {
                    dv.Device.amount -= dv.Quantity;
                    foreach(Device dd in db.Device.ToList())
                    {
                        if(dd.id == dv.Device.id)
                        {
                            dd.amount -= dv.Quantity;
                            break;
                        }
                    }
                }
                db.SaveChanges();
                Session["CartDv"] = null;
            }

            if (Session["CartCb"] != null)
            {
                cartcb = (List<CartCb>)Session["CartCb"];
                foreach(CartCb cb in cartcb)
                {
                    cb.Combo.amount -= cb.Quantity;
                    foreach(Combo cc in db.Combo.ToList())
                    {
                        if(cc.id == cb.Combo.id)
                        {
                            cc.amount -= cb.Quantity;
                            break;
                        }
                    }
                }
                db.SaveChanges();
                Session["CartCb"] = null;
            }

            Invoice hoadon = new Invoice()
            {
                customer_id = Convert.ToInt32(Session["idCustomer"].ToString()),
                createdDate = DateTime.Today,
                totalMoney = Sum,
                status = "Chưa xử lý",
                detail = jsonDetail(cartdv, cartcb)
            };
            db.Invoice.Add(hoadon);
            db.SaveChanges();

            BillOfLading phieugiaohang = new BillOfLading()
            {
                receiverName = Nguoinhan,
                address = Diachi,
                //Ngày ship là Ngày tạo + 7 ngày
                shipDate = DateTime.Today + new TimeSpan(7, 0, 0, 0),
                status = "Chưa giao",
                invoice_id = hoadon.id
            };
            db.BillOfLading.Add(phieugiaohang);
            db.SaveChanges();

            return Json("Thanh toán thành công");
        }
        
        //Dạng json:
        /*
         * {
         *      "thietbi": [
         *          {
         *              các thuộc tính của devices,
         *              quanlity
         *          }
         *      ],
         *      "combo": [
         *          {
         *              các thuộc tính của combo,
         *              quanlity
         *          }
         *      ]
         * }
         */
        private string jsonDetail(List<CartDv> cartdv, List<CartCb> cartcb)
        {
            JsonDetailInvoice json = new JsonDetailInvoice()
            {
                ThietBi = cartdv,
                Combo = cartcb
            };
            string kq = JsonConvert.SerializeObject(json);
            return kq;
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
