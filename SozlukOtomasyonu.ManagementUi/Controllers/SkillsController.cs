using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KutuphaneOtomasyonu.Controllers
{
    public class SkillsController : Controller
    {
        // GET: Skills
        SkillsManager sm = new SkillsManager(new EfSkillsDal());
        public ActionResult Index()
        {
            var skillsValues = sm.GetCagetoryList();
            return View(skillsValues);
        }
        public ActionResult GetCagetoryList()
        {
            var skillsvalues = sm.GetCagetoryList();
            return View(skillsvalues);
        }
    }
}