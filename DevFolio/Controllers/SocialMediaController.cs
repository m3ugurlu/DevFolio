using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolio.Models;

namespace DevFolio.Controllers
{
    public class SocialMediaController : Controller
    {
        DbDevFolioEntities db = new DbDevFolioEntities();
        public ActionResult SocialMediaList()
        {
            var values = db.TblSocialMedia.ToList();
            return View(values);
        }
        //TEST_30062024

        [HttpGet]
        public ActionResult SocialMediaCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SocialMediaCreate(TblSocialMedia p)
        {
            db.TblSocialMedia.Add(p);
            db.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        public ActionResult SocialMediaDelete(int id)
        {
            var value = db.TblSocialMedia.Find(id);
            db.TblSocialMedia.Remove(value);
            db.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        [HttpGet]
        public ActionResult SocialMediaUpdate(int id)
        {
            var value = db.TblSocialMedia.Find(id);
            return View(value);
        }
    }
}