using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProject.Models.Entity;

namespace MvcCvProject.Controllers
{
    public class DefaultController : Controller
    {
        DbCvEntities db = new DbCvEntities();
        // GET: Default
        public ActionResult Index()
        {
            var values = db.TblAbout.ToList();
            return View(values);
        }
        public PartialViewResult Experiences()
        {
            var experience = db.TblExperience.ToList();
            return PartialView(experience);
        }
        public PartialViewResult Education()
        {
            var education = db.TblEducation.ToList();
            return PartialView(education);
        }
        public PartialViewResult Skill()
        {
            var skill = db.TblSkill.ToList();
            return PartialView(skill);
        }
        public PartialViewResult Hobby()
        {
            var hobby = db.TblHobbies.ToList();
            return PartialView(hobby);
        }
        public PartialViewResult Certificate()
        {
            var certificate = db.TblCertificate.ToList();
            return PartialView(certificate);
        }
        [HttpGet]
        public PartialViewResult Contact()
        {
           
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Contact(TblContact p)
        {
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblContact.Add(p);
            db.SaveChanges();
            return PartialView();
        }
    }
}