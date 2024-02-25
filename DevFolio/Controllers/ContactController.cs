using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolio.Models;
namespace DevFolio.Controllers
{
    public class ContactController : Controller
    {
        DbDevFolioEntities db = new DbDevFolioEntities();
        public ActionResult ContactList()
        {
            var values = db.TblContact.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult ContactCreate()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult ContactCreate(TblContact c)
        //{
        //    db.TblContact.Add(c);
        //    db.SaveChanges();
        //    return RedirectToAction("ContactList");
        //}
        public ActionResult DeleteContact(int id)
        {
            var value = db.TblContact.Find(id);
            db.TblContact.Remove(value);
            db.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}