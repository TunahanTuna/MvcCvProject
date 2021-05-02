using MvcCvProject.Models.Entity;
using MvcCvProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCvProject.Controllers
{
    public class SkillController : Controller
    {
       

        SkillRepository repo = new SkillRepository();
        public ActionResult Index()
        {
            var skills = repo.List();
            return View(skills);
        }
        public ActionResult SkillDelete(int id)
        {
            var skill = repo.Find(x => x.ID == id);
            repo.TDelete(skill);
            return RedirectToAction("Index");
        }
    }
}