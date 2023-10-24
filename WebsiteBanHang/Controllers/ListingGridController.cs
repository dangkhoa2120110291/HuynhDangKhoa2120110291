using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Context;

namespace WebsiteBanHang.Controllers
{
    public class ListingGridController : Controller
    {
        WebBanHangEntities obj = new WebBanHangEntities();
        // GET: ListingGrid
        public ActionResult Index()
        {
            var lstProduct = obj.Products.ToList();
            var lstCategory = obj.Categories.ToList();

            Models.HomeModel objHome = new Models.HomeModel();

            objHome.ListProduct = lstProduct;
            objHome.ListCategory = lstCategory;
            return View(objHome);
        }
    }
}