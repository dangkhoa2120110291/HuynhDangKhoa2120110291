using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Context;

namespace WebsiteBanHang.Controllers
{
    public class CartController : Controller
    {
        WebBanHangEntities obj = new WebBanHangEntities();
        // GET: Cart
        public ActionResult Detail(int id)
        {
            var objProduct = obj.Products.Where(n => n.Id == id).FirstOrDefault();
            return View(objProduct);          
        }
    }
}