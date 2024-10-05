using PortfolioProjectNigth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioProjectNigth.Controllers
{
    public class DashboardController : Controller
    {
        DbMyPortfolioNightEntities1 context = new DbMyPortfolioNightEntities1();

        public ActionResult Index()
        {
            ViewBag.EducationCount = context.Education.Count();
            ViewBag.SkillCount = context.Skill.Count();
            ViewBag.ExperienceCount = context.Experience.Count();
            ViewBag.ServiceCount = context.Service.Count();
            ViewBag.SocialMediaCount = context.SocialMedia.Count();
            ViewBag.MessageCount = context.Contact.Count();

            return View();
        }
    }
}