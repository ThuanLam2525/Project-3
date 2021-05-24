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

namespace BanHangEntityClient.Controllers
{
    public class DevicesController : Controller
    {
        private ThietBiDienTuEntities db = new ThietBiDienTuEntities();

        // GET: Devices
        public ActionResult Index()
        {
            //Lấy ds thiết bị
            var laptop = (from lap in db.Device where lap.catalog == "Laptop" select lap).OrderBy(lap => lap.id);
            var computer = (from pc in db.Device where pc.catalog == "Máy bộ" select pc).OrderBy(pc => pc.id);
            var component = (from com in db.Device where com.catalog == "Linh kiện" select com).OrderBy(com => com.id);
            var accessory = (from acc in db.Device where acc.catalog == "Phụ kiện" select acc).OrderBy(acc => acc.id);
            //Lấy 8 cái cuối cùng mỗi ds
            var laplist = laptop.Skip(Math.Max(0, laptop.Count() - 8));
            var pclist = computer.Skip(Math.Max(0, computer.Count() - 8));
            var comlist = component.Skip(Math.Max(0, component.Count() - 8));
            var acclist = accessory.Skip(Math.Max(0, accessory.Count() - 8));
            //
            dynamic model = new ExpandoObject();
            model.laplist = laplist;
            model.pclist = pclist;
            model.comlist = comlist;
            model.acclist = acclist;
            return View(model);
        }

        public ActionResult ChitietSanpham(int id)
        {
            var productdetail = (from dv in db.Device where dv.id == id select dv).First();
            return View(productdetail);
        }

        public ActionResult Danhmuc(string catalog, string type = "", decimal fromprice = -1, decimal toprice = -1, int page = 1, string sort = "id")
        {
            var typelist = (from dv in db.Device where dv.catalog == catalog select dv).Select(dv => dv.type).Distinct();
            //Lấy ds thiết bị
            var device = (from dev in db.Device where dev.catalog == catalog select dev);
            //Chức năng lọc
            if (type != "" && fromprice == -1 && toprice == -1)
            {
                device = (from dev in db.Device where dev.catalog == catalog && dev.type == type select dev);
            }
            else if (type != "" && fromprice != -1 && toprice == -1)
            {
                device = (from dev in db.Device where dev.catalog == catalog && dev.type == type && dev.price >= fromprice select dev);
            }
            else if (type != "" && fromprice == -1 && toprice != -1)
            {
                device = (from dev in db.Device where dev.catalog == catalog && dev.type == type && dev.price <= toprice select dev);
            }
            else if (type != "" && fromprice != -1 && toprice != -1)
            {
                device = (from dev in db.Device where dev.catalog == catalog && dev.type == type && dev.price >= fromprice && dev.price <= toprice select dev);
            }
            else if (type == "" && fromprice != -1 && toprice == -1)
            {
                device = (from dev in db.Device where dev.catalog == catalog && dev.price >= fromprice select dev);
            }
            else if (type == "" && fromprice == -1 && toprice != -1)
            {
                device = (from dev in db.Device where dev.catalog == catalog && dev.price <= toprice select dev);
            }
            else if (type == "" && fromprice != -1 && toprice != -1)
            {
                device = (from dev in db.Device where dev.catalog == catalog && dev.price >= fromprice && dev.price <= toprice select dev);
            }
            //Chức năng sắp xếp theo giá tiền
            if (sort.Equals("asc"))
            {
                device = device.OrderBy(dev => dev.price);
            }
            else if (sort.Equals("des"))
            {
                device = device.OrderByDescending(dev => dev.price);
            }
            else
            {
                device = device.OrderByDescending(dev => dev.id);
            }
            //Lấy 12 thiết bị
            var devlist = device.Skip((page - 1) * 12).Take(12);
            //Lấy số trang
            var pages = device.Count() / 12;
            if (device.Count() % 12 != 0)
            {
                pages = pages + 1;
            }
            dynamic model = new ExpandoObject();
            model.title = catalog.ToUpper();
            model.typelist = typelist;
            model.devlist = devlist;
            model.pages = pages;
            model.cataglog = catalog;
            model.currentpage = page;
            model.checkedtype = type;
            model.fromprice = fromprice;
            model.toprice = toprice;
            model.sort = sort;
            return View(model);
        }

        public ActionResult TimKiem(string keyword, decimal fromprice = -1, decimal toprice = -1, int page = 1, string sort = "id")
        {
            //Lấy ds thiết bị
            var device = (from dev in db.Device select dev).Where(dev => dev.name.Contains(keyword));
            //Chức năng lọc
            if (fromprice != -1 && toprice == -1)
            {
                device = (from dev in db.Device where dev.price >= fromprice select dev).Where(dev => dev.name.Contains(keyword));
            }
            else if (fromprice == -1 && toprice != -1)
            {
                device = (from dev in db.Device where dev.price <= toprice select dev).Where(dev => dev.name.Contains(keyword));
            }
            else if (fromprice != -1 && toprice != -1)
            {
                device = (from dev in db.Device where dev.price >= fromprice && dev.price <= toprice select dev).Where(dev => dev.name.Contains(keyword));
            }
            //Chức năng sắp xếp theo giá tiền
            if (sort.Equals("asc"))
            {
                device = device.OrderBy(dev => dev.price);
            }
            else if (sort.Equals("des"))
            {
                device = device.OrderByDescending(dev => dev.price);
            }
            else
            {
                device = device.OrderByDescending(dev => dev.id);
            }
            //Lấy 12 thiết bị
            var devlist = device.Skip((page - 1) * 12).Take(12);
            //Lấy số trang
            var pages = device.Count() / 12;
            if (device.Count() % 12 != 0)
            {
                pages = pages + 1;
            }
            dynamic model = new ExpandoObject();
            model.keyword = keyword;
            model.devlist = devlist;
            model.pages = pages;
            model.currentpage = page;
            model.fromprice = fromprice;
            model.toprice = toprice;
            model.sort = sort;
            return View(model);
        }
    }
}
