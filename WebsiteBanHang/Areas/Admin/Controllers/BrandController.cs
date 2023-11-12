using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Context;

namespace WebsiteBanHang.Areas.Admin.Controllers
{
    public class BrandController : Controller
    {
        // GET: Admin/Brand
        WebBanHangEntities obj = new WebBanHangEntities();
        public ActionResult Index()
        {
            var lstBrand = obj.Brands.ToList();
            return View(lstBrand);
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Brand objBrand)
        {
            try
            {
                obj.Brands.Add(objBrand);
                obj.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var objBrand = obj.Brands.Where(n => n.Id == id).FirstOrDefault();
            return View(objBrand);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var objBrand = obj.Brands.Where(n => n.Id == id).FirstOrDefault();
            return View(objBrand);
        }
        [HttpPost]
        public ActionResult Delete(Brand objPro)
        {
            var objBrand = obj.Brands.Where(n => n.Id == objPro.Id).FirstOrDefault();
            obj.Brands.Remove(objBrand);
            obj.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var objBrand = obj.Brands.Where(n => n.Id == id).FirstOrDefault();
            return View(objBrand);
        }
        [HttpPost]
        public ActionResult Edit(Brand objBrand)
        {
            obj.Entry(objBrand).State = EntityState.Modified;
            obj.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}