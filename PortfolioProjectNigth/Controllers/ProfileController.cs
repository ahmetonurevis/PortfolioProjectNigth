
using PortfolioProjectNigth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioProjectNigth.Controllers
{
    public class ProfileController : Controller
    {
        DbMyPortfolioNightEntities1 context = new DbMyPortfolioNightEntities1();

        public ActionResult Index()
        {
            var values = context.Profile.FirstOrDefault();

            return View(values);
        }

        [HttpPost]
        public ActionResult Index(Profile profile)
        {
            var value = context.Profile.Find(profile.ProfileID);

            value.Title = profile.Title;

            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}