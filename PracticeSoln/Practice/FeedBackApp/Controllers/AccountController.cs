using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FeedBackApp.DAL;
using System.Web.Security;
using FeedBackApp.BLL;

namespace FeedBackApp.Controllers
{
    public class AccountController : Controller
    {
        FeedbackContext entities = new FeedbackContext();
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username,string password,string returnUrl)
        {
            bool status = AccountManager.Validate(username, password);

            //var user = entities.accounts.SingleOrDefault(p => p.User == username && p.Password == password);          
            if(status)
            {
                FormsAuthentication.SetAuthCookie(username, false);
                return Redirect(returnUrl ?? Url.Action("Index" , "Home"));
            }
            else
            {
                ModelState.AddModelError("", "Incorrect username or password");
                return View();
            }
            
        }

    }
}