using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToyStoreWeb.Models;

namespace ToyStoreWeb.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            Product pro = null;
            switch(id)
            {
                case 1:
                    pro = new Product
                    {
                        Id = 1,
                        Title = "Pikachu",
                        Description = "Electric tail",
                        ImageUrl = "/Images/Toys/Pikachu.jpg",
                        Quantity = 1000,
                        UnitPrice = 500
                    };
                    break;

                case 2:
                    pro = new Product
                    {
                        Id = 2,
                        Title = "Eevee",
                        Description = "Fire tail",
                        ImageUrl = "/Images/Toys/eevee.jpg",
                        Quantity = 500,
                        UnitPrice = 300
                    };
                    break;

                case 3:
                    pro = new Product
                    {
                        Id = 3,
                        Title = "Charmander",
                        Description = "orange tail",
                        ImageUrl = "/Images/Toys/charmander.jpg",
                        Quantity = 800,
                        UnitPrice = 600
                    };
                    break;

                case 4:
                    pro = new Product
                    {
                        Id = 3,
                        Title = "Sylveon",
                        Description = "cute tail",
                        ImageUrl = "/Images/Toys/sylveon.jpg",
                        Quantity = 400,
                        UnitPrice = 1000
                    };
                    break;


            }
            this.ViewBag.product = pro;
            return View();
        }
    }
}