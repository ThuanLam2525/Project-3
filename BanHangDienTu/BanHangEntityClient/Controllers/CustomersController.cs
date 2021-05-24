using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BanHangEntityClient.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BanHangEntityClient.Controllers
{
    public class CustomersController : Controller
    {
        private ThietBiDienTuEntities db = new ThietBiDienTuEntities();

        // GET: Customers
        public ActionResult Index()
        {
            if (Session["idCustomer"] != null)
            {
                //Get info của Customer
                int idCust = Convert.ToInt32(Session["idCustomer"].ToString());
                return View(db.Customer.Find(idCust));
            }
            else
            {
                return RedirectToAction("Dangnhap");
            }
        }

        public ActionResult ChitietDonhang(int id)
        {
            var hoadon = (from hd in db.Invoice where hd.id == id select hd).FirstOrDefault();
            var phieugiaohang = (from pgh in db.BillOfLading where pgh.invoice_id == id select pgh).FirstOrDefault();

            JsonDetailInvoice detailInvoice = JsonConvert.DeserializeObject<JsonDetailInvoice>(hoadon.detail.ToString());
            List<CartDv> cartDvs = detailInvoice.ThietBi;
            List<CartCb> cartCbs = detailInvoice.Combo;
            
            dynamic model = new ExpandoObject();
            model.hoadon = hoadon;
            model.phieugiaohang = phieugiaohang;
            model.cacthietbi = cartDvs;
            model.caccombo = cartCbs;

            return View(model);
        }

        public ActionResult Dangky()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Dangky([Bind(Include = "id,username,password,name,sdt,address")] Customer customer)
        {
            //Email tồn tại duy nhất
            if (db.Customer.Any(x => x.username == customer.username))
            {
                ViewBag.dupplicateMsg = "Email đã tồn tại";
                return View(customer);
            }
            //Các input thỏa các điều kiện (ở file model)
            if (ModelState.IsValid)
            {
                db.Customer.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Dangnhap");
            }
            return View(customer);
        }

        public ActionResult Dangnhap()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Dangnhap(string username, string password)
        {
            //Các input thỏa điêu kiện
            if (ModelState.IsValid)
            {
                var data = db.Customer.Where(s => s.username.Equals(username) && s.password.Equals(password)).ToList();
                if (data.Count() > 0)
                {
                    //add session
                    Session["Name"] = data.FirstOrDefault().name;
                    Session["Email"] = data.FirstOrDefault().username;
                    Session["idCustomer"] = data.FirstOrDefault().id;
                    Session["Phone"] = data.FirstOrDefault().sdt;
                    Session["Address"] = data.FirstOrDefault().address;
                    return RedirectToAction("../Devices/Index");
                }
                ViewBag.errorMsg = "Đăng nhập thất bại. Xin hãy kiểm tra lại tên tài khoản và mật khẩu.";
            }
            return View();
        }

        public ActionResult Donhang()
        {
            
            int idCust = Convert.ToInt32(Session["idCustomer"].ToString());
            /*
            var tmp = db.Invoice.Include(s => s.customer_id).Where(s => s.id == idCust);
            return View(tmp.ToList());
            */
            var invoiceList = (from hd in db.Invoice where hd.customer_id == idCust select hd).OrderBy(hd => hd.id);
            dynamic model = new ExpandoObject();
            model.invoiceList = invoiceList;
            return View(model);
        }

        //Logout
        public ActionResult Dangxuat()
        {
            //remove session
            Session["idCustomer"] = null;
            Session["Name"] = null;
            Session["Email"] = null;
            return RedirectToAction("Dangnhap");
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
