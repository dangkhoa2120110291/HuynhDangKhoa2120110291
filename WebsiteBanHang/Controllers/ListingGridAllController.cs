using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Context;

namespace WebsiteBanHang.Controllers
{
    public class ListingGridAllController : Controller
    {
        WebBanHangEntities obj = new WebBanHangEntities();
        // GET: ListingGridAll
        public ActionResult Index()
        {
            var lstProduct = obj.Products.ToList();
            var lstCategory = obj.Categories.ToList();
            var lstBrand = obj.Brands.ToList();

            Models.HomeModel objHome = new Models.HomeModel();

            objHome.ListProduct = lstProduct;
            objHome.ListCategory = lstCategory;
            objHome.ListBrand = lstBrand;
            return View(objHome);
        }
    }
}