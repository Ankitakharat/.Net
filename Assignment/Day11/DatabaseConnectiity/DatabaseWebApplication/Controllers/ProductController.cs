using BOL;
using DAL1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseWebApplication.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product

        List<Product> list = ProductDAO.GetAll();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Remove(int id)
        {
            ProductDAO.Delete(id);
            return RedirectToAction("Index", "product");

        }

        public ActionResult Edit(int id)
        {
            Product pro = ProductDAO.Get(id);
            ViewBag.Product = pro;

            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id, string name)
        {
            bool status = ProductDAO.Update(id,name);

            if (status)
            {
                return RedirectToAction("Index", "product");
            }
            else
            {
                return RedirectToAction("Index", "home");
            }
        }
    }
}
    
