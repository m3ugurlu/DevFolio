using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolio.Models;

namespace DevFolio.Controllers
{
    public class TestmonialController : Controller
    {
        DbDevFolioEntities db = new DbDevFolioEntities();
        public ActionResult TestmonialList()
        {
            var values = db.Testimonial.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateTestmonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTestmonial(Testimonial t)
        {
            db.Testimonial.Add(t);
            db.SaveChanges();
            return RedirectToAction("TestmonialList");
        }

        public ActionResult DeleteTestmonial(int id)
        {
            var value = db.Testimonial.Find(id);
            db.Testimonial.Remove(value);
            db.SaveChanges();
            return RedirectToAction("TestmonialList");
        }

        [HttpGet]
        public ActionResult UpdateTestmonial(int id)
        {
            var value = db.Testimonial.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateTestmonial(Testimonial p)
        {
            var value = db.Testimonial.Find(p.TestimonialID);
            value.ImageUrl = p.ImageUrl;
            value.NameSurname = p.NameSurname;
            value.Description = p.Description;
            value.Status = true;
            db.SaveChanges();
            return RedirectToAction("TestmonialList");


        }
    }
}