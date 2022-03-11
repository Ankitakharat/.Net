using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToyStoreWeb.Controllers
{
    public class AddtoCartController : Controller
    {
        // GET: AddtoCart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddToCart(int id)
        {
            return View();
        }

    }
}