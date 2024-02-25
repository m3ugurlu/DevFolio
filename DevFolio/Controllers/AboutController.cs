using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolio.Models;

namespace DevFolio.Controllers
{
    public class AboutController : Controller
    {
        DbDevFolioEntities db = new DbDevFolioEntities();
        public ActionResult AboutList()
        {
            var values = db.TblAbout.ToList();
            return View(values);
        }
         [HttpGet]
        public ActionResult AboutCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AboutCreate(TblAbout a)
        {
            db.TblAbout.Add(a);
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }

        public ActionResult AboutDelete(int id)
        {
            var value = db.TblAbout.Find(id);
            db.TblAbout.Remove(value);
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }

        [HttpGet]
        public ActionResult AboutUpdate(int id)
        {
            var value = db.TblAbout.Find(id);
            return View(value);
        }
    }
}