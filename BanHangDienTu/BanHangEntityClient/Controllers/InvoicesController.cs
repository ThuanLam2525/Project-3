using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BanHangEntityClient.Models;

namespace BanHangEntityClient.Controllers
{
    public class InvoicesController : Controller
    {
        private ThietBiDienTuEntities db = new ThietBiDienTuEntities();

        // GET: Invoices
        public ActionResult Index()
        {
            var invoice = db.Invoice.Include(i => i.Customer);
            return View(invoice.ToList());
        }

        public ActionResult Giohang()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AddtoCart(string id)
        {
            int dv_id = Convert.ToInt32(id);
            int cart_count = CountCart();
            if (Session["CartDv"] == null)
            {
                List<CartDv> cart = new List<CartDv>();
                cart.Add(new CartDv { Device = db.Device.Find(dv_id), Quantity = 1 });
                Session["CartDv"] = cart;
                cart_count++;
            }
            else
            {
                List<CartDv> cart = (List<CartDv>)Session["CartDv"];
                int index = isExist(dv_id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new CartDv { Device = db.Device.Find(dv_id), Quantity = 1 });
                    cart_count++;
                }
                Session["CartDv"] = cart;
            }
            return Json(cart_count.ToString());
        }

        [HttpPost]
        public JsonResult AddtoCartCombo(string id)
        {
            int cb_id = Convert.ToInt32(id);
            int cart_count = CountCart();
            if (Session["CartCb"] == null)
            {
                List<CartCb> cart = new List<CartCb>();
                cart.Add(new CartCb { Combo = db.Combo.Find(cb_id), Quantity = 1 });
                Session["CartCb"] = cart;
                cart_count++;
            }
            else
            {
                List<CartCb> cart = (List<CartCb>)Session["CartCb"];
                int index = isExistCombo(cb_id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new CartCb { Combo = db.Combo.Find(cb_id), Quantity = 1 });
                    cart_count++;
                }
                Session["CartCb"] = cart;
            }
            return Json(cart_count.ToString());
        }

        [HttpPost]
        public ActionResult RemovefromCart(string id, string type)
        {
            if(type.Equals("thietbi"))
            {
                List<CartDv> cart = (List<CartDv>)Session["CartDv"];
                int cart_id = Convert.ToInt32(id);
                int index = isExist(cart_id);
                cart.RemoveAt(index);
                Session["CartDv"] = cart;
                return Json("Xóa thành công");
            }
            if (type.Equals("combo"))
            {
                List<CartCb> cart = (List<CartCb>)Session["CartCb"];
                int cart_id = Convert.ToInt32(id);
                int index = isExistCombo(cart_id);
                cart.RemoveAt(index);
                Session["CartCb"] = cart;
                return Json("Xóa thành công");
            }
            return Json("Xóa thất bại");
        }

        [HttpPost]
        public ActionResult UpdateCart(string id, int quantity, string type)
        {
            if(type.Equals("thietbi"))
            {
                List<CartDv> cart = (List<CartDv>)Session["CartDv"];
                int cart_id = Convert.ToInt32(id);
                List<Device> device_amount = (from dv in db.Device where dv.id == cart_id && dv.amount >= quantity select dv).ToList();
                if (device_amount.Count() == 0)
                    return Json("Số lượng đã vượt quá mà cửa hàng có");
                int index = isExist(cart_id);
                cart[index].Quantity = quantity;
                Session["CartDv"] = cart;
                return Json("Cập nhật thành công");
            }
            if (type.Equals("combo"))
            {
                List<CartCb> cart = (List<CartCb>)Session["CartCb"];
                int cart_id = Convert.ToInt32(id);
                List<Combo> combo_amount = (from cb in db.Combo where cb.id == cart_id && cb.amount >= quantity select cb).ToList();
                if (combo_amount.Count() == 0)
                    return Json("Số lượng đã vượt quá mà cửa hàng có");
                int index = isExistCombo(cart_id);
                cart[index].Quantity = quantity;
                Session["CartCb"] = cart;
                return Json("Cập nhật thành công");
            }
            return Json("Cập nhật thất bại");
        }

        private int CountCart()
        {
            int countDV = 0;
            int countCB = 0;
            if(Session["CartDv"] != null)
            {
                List<CartDv> cartdv = (List<CartDv>) Session["CartDv"];
                countDV = cartdv.Count;
            }
            if (Session["CartCb"] != null)
            {
                List<CartCb> cartcb = (List<CartCb>)Session["CartCb"];
                countCB = cartcb.Count;
            }
            return countDV + countCB;
        }
        
        private int isExist(int id)
        {
            List<CartDv> cart = (List<CartDv>)Session["CartDv"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Device.id.Equals(id))
                    return i;
            return -1;
        }

        private int isExistCombo(int id)
        {
            List<CartCb> cart = (List<CartCb>)Session["CartCb"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Combo.id.Equals(id))
                    return i;
            return -1;
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
