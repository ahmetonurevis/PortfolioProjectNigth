using PortfolioProjectNigth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioProjectNigth.Controllers
{
    public class DefaultController : Controller
    {
        DbMyPortfolioNightEntities1 context = new DbMyPortfolioNightEntities1 ();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialHeader()
        {
            ViewBag.title = context.Profile.Select(x => x.Title).FirstOrDefault();
            ViewBag.description = context.Profile.Select(x =>x.Description).FirstOrDefault();
            ViewBag.address = context.Profile.Select(x =>x.Address).FirstOrDefault();
            ViewBag.email = context.Profile.Select(x =>x.Email).FirstOrDefault();
            ViewBag.phone = context.Profile.Select(x =>x.Phone).FirstOrDefault();
            ViewBag.github = context.Profile.Select(x =>x.Github).FirstOrDefault();
            ViewBag.imageurl = context.Profile.Select(x =>x.ImageUrl).FirstOrDefault();
            return PartialView();
        }
    }
}