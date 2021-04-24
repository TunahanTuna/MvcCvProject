using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;
namespace MvcCvProject.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        ExperienceRepository repo = new ExperienceRepository();
        public ActionResult Index()
        {
            var experience = repo.List();
            return View(experience);
        }
        [HttpGet]
        public ActionResult ExperienceAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ExperienceAdd(TblExperience p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult ExperienceDelete(int id)
        {
            var delete = repo.Find(x => x.ID == id);
            repo.TDelete(delete);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult ExperienceGet(int id)
        {
            var get = repo.Find(x => x.ID == id);
            return View(get);
        }
        [HttpPost]
        public ActionResult ExperienceGet(TblExperience p)
        {
            var get = repo.Find(x => x.ID == p.ID);
            get.Title = p.Title;
            get.SubTitle = p.SubTitle;
            get.Description = p.Description;
            get.Date = p.Date;
            repo.TUpdate(get);
            return RedirectToAction("Index");
        }


    }
}