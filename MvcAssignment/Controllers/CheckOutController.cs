using DataLayer;
using ModelClasses.Interfaces;
using ModelClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAssignment.Controllers
{
    public class CheckOutController : Controller
    {

        IOrder _order;
        public CheckOutController()
        {
            _order = new dbOrder();
        }

        // GET: CheckOut
        public ActionResult Index(int id)
        {
            ViewBag.productId = id;
            return View();
        }

        [HttpPost]
        public JsonResult SubmitOrder(Order orderDetails)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = _order.submitOrder(orderDetails);

                    return Json(result.Id, JsonRequestBehavior.AllowGet);
                }
                else
                    throw new Exception("Model is not valid");

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}