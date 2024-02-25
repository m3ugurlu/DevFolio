using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolio.Models;

namespace DevFolio.Controllers
{
    public class AdressController : Controller
    {
        DbDevFolioEntities db = new DbDevFolioEntities();
        public ActionResult AdresList()
        {
            var values = db.TblAdress.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AdresCreate()
        {
            return View();
        }
     
        [HttpPost]
        public ActionResult AdresCreate(TblAdress a)
        {
            db.TblAdress.Add(a);
            db.SaveChanges();
            return RedirectToAction("AdresList");
        }
        public ActionResult AdresDelete(int id)
        {
            var value = db.TblAdress.Find(id);
            db.TblAdress.Remove(value);
            db.SaveChanges();
            return RedirectToAction("AdresList");
        }
        [HttpGet]
        public ActionResult AdresUpdate(int id)
        {
            var value = db.TblAdress.Find(id);
            return View(value);
        }
    }
}