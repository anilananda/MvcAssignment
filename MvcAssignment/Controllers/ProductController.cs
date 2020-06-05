using ModelClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAssignment.Controllers
{
    public class ProductController : Controller
    {
        ModelClasses.Interfaces.IProduct _product;
        public ProductController()
        {
            _product = new DataLayer.dbProduct();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public string Create(Product product)
        {
            try
            {
                // TODO: Add insert logic here
                if (product != null && ModelState.IsValid)
                {
                    _product.addProduct(product);
                    return "Product Added Successfully";
                }
                else
                {
                    return "Product Not Inserted! Try Again";
                }

                //  return RedirectToAction("Index");
            }
            catch
            {
                return "Product Not Inserted! Try Again";
            }
        }

        [HttpPost]
        public ActionResult InsertProduct()
        {
            return View();
        }


        public ActionResult Edit()
        {
            return View();
        }

        [HttpGet]
        public ActionResult EditProduct(int id)
        {
            return View();
        }

        [HttpGet]
        public JsonResult getProducts()
        {
            try
            {
                var res = _product.GetProducts();

                if (res == null)
                    throw new NullReferenceException();

                return Json(res, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpGet]
        public JsonResult getProduct(int Id)
        {
            try
            {
                var res = _product.GetProduct(Id);

                if (res == null)
                    throw new NullReferenceException();

                return Json(res, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {

                throw;
            }
        }




        [HttpPost]
        public ActionResult DeleteProduct(int Id)
        {
            try
            {

                _product.DeleteProduct(Id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpPost]
        public string UpdateProduct(Product product)
        {
            try
            {
                return _product.UpdateProduct(product);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}