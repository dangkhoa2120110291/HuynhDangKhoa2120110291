using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Context;

namespace WebsiteBanHang.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        // GET: Admin/Order        
        WebBanHangEntities obj = new WebBanHangEntities();
        public ActionResult Index()
        {
            var lstOrder = obj.Orders.ToList();
            return View(lstOrder);
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Order objOrder)
        {
            try
            {
                obj.Orders.Add(objOrder);
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
            var objOrder = obj.Orders.Where(n => n.Id == id).FirstOrDefault();
            return View(objOrder);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var objOrder = obj.Orders.Where(n => n.Id == id).FirstOrDefault();
            return View(objOrder);
        }
        [HttpPost]
        public ActionResult Delete(Order objPro)
        {
            var objOrder = obj.Orders.Where(n => n.Id == objPro.Id).FirstOrDefault();
            obj.Orders.Remove(objOrder);
            obj.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var objOrder = obj.Orders.Where(n => n.Id == id).FirstOrDefault();
            return View(objOrder);
        }
        [HttpPost]
        public ActionResult Edit(Order objOrder)
        {
            obj.Entry(objOrder).State = EntityState.Modified;
            obj.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}