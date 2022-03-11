using Exam.DAL;
using Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam.Controllers
{
    public class WorkshopController : Controller
    {
        // GET: Workshop

        WorkshopContext entities = new WorkshopContext();


        public ActionResult ShowAllWorkshop()
        {
            List<Workshop> workshops = entities.Workshops.ToList();
            this.ViewData["workshops"] = workshops;

            return View();
        }

        public ActionResult View(int id)
        {
            var workshop = entities.Workshops.SingleOrDefault(p => p.Id == id);
            this.ViewData["workshops"] = workshop;
            return View();
        }

        [Authorize]
        public ActionResult Edit(int id)
        {
            var workshop = entities.Workshops.SingleOrDefault(p => p.Id == id);
            this.ViewData["workshops"] = workshop;
            return View(workshop);
        }


        [HttpPost]
        public ActionResult Edit(Workshop workshop)
        {
            if (ModelState.IsValid)
            {
                entities.Entry(workshop).State = System.Data.Entity.EntityState.Modified;
                entities.SaveChanges();
                return RedirectToAction("ShowAllWorkshop", "workshop");

            }
            return View(workshop);
        }

        [Authorize]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Workshop workshop)
        {
            if (ModelState.IsValid)
            {
                workshop.Id = 5;
                entities.Workshops.Add(workshop);
                entities.SaveChanges();
                return RedirectToAction("ShowAllWorkshop", "workshop");
            }
            return View(workshop);
        }

        [Authorize]
        public ActionResult Delete(int id)
        {
            var workshop = entities.Workshops.SingleOrDefault(p => p.Id == id);
            entities.Workshops.Remove(workshop);
            entities.SaveChanges();
            return RedirectToAction("ShowAllWorkshop", "workshop");
        }
    }
}