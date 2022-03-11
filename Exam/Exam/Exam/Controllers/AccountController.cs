using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using System.Web.Security;
using Exam.DAL;
using Exam.BLL;

namespace Exam.Controllers
{
    public class AccountController : Controller
    {
        WorkshopContext entities = new WorkshopContext();
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Username, string Password, string returnUrl)
        {
            bool status = AccountManager.Validate(Username, Password);

          
            if (status)
            {
                FormsAuthentication.SetAuthCookie(Username, false);
                return Redirect(returnUrl ?? Url.Action("Index", "Home"));

            }
            else
            {
                ModelState.AddModelError("", "Incorrect username or password");
                return View();
            }


        }
    }
}