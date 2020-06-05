using ModelClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAssignment.Controllers
{
    public class OrderHistoryController : Controller
    {
        IOrderHistory _orderHistory;
        public OrderHistoryController()
        {
            _orderHistory = new DataLayer.dbOrderHistory();
        }

        // GET: OrderHistory
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetOrderHistory()
        {
            try
            {
                var res = _orderHistory.getOrderHistory();
                return Json(res, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {

                throw;
            }

        }


        // GET: OrderHistory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderHistory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderHistory/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderHistory/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderHistory/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderHistory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderHistory/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
