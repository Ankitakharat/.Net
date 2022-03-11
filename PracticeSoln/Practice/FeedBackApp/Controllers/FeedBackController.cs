using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FeedBackApp.DAL;
using FeedBackApp.Models;

namespace FeedBackApp.Controllers
{
    public class FeedBackController : Controller
    {
        FeedbackContext entities = new FeedbackContext();
        // GET: FeedBack
        public ActionResult AllFeedBack(int ? id)
        {
            List<Feedback> feedbacks = entities.feedbacks.ToList();
            this.ViewData["feedbacks"] = feedbacks;
            return View();
        }
        public ActionResult View(int id)
        {
            var feeback = entities.feedbacks.SingleOrDefault(p => p.Id == id);
            this.ViewData["feedbacks"] = feeback;
            return View();
        }

        public ActionResult Edit(int id)
        {
            var feeback = entities.feedbacks.SingleOrDefault(p => p.Id == id);
            this.ViewData["feedbacks"] = feeback;
            return View(feeback);
        }

        [HttpPost]
        public ActionResult Edit(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                entities.Entry(feedback).State = System.Data.Entity.EntityState.Modified;
                entities.SaveChanges();
                return RedirectToAction("AllFeedback", "feedback");
            }
            return View(feedback);
        }
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Feedback feedback)
        {
            if(ModelState.IsValid)
            {
                feedback.Id = 10;
                entities.feedbacks.Add(feedback);
                entities.SaveChanges();
                return RedirectToAction("AllFeedback", "feedback");
            }
            return View(feedback);
        }

        public ActionResult Delete(int id)
        {
            var feedback = entities.feedbacks.SingleOrDefault(p => p.Id == id);
            entities.feedbacks.Remove(feedback);
            entities.SaveChanges();
            return RedirectToAction("AllFeedback", "feedback");
        }

    }
}