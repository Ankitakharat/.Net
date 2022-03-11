using ORMTestApp.DAL;
using ORMTestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ORMTestApp.Controllers
{
    public class ProductController : Controller
    {
        DbOrmContext entities = new DbOrmContext();
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = entities.Products.ToList();
            this.ViewData["products"] = products;
            return View();

        }
        public ActionResult Details(int id)
        {

            var product = entities.Products.SingleOrDefault(p => p.Id == id);
            this.ViewData["product"] = product;
            return View();
        }
        public ActionResult Delete(int id)
        {
            var product = entities.Products.SingleOrDefault(p => p.Id == id);
            entities.Products.Remove(product);
            entities.SaveChanges();   // to reflect changes back to database by Entity framework
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var product = entities.Products.SingleOrDefault(e => e.Id == id);
            
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                entities.Entry(product).State = System.Data.Entity.EntityState.Modified;
                entities.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                product.Id = 8989;
                entities.Products.Add(product);
                entities.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}