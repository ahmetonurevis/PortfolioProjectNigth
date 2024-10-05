using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioProjectNigth.Models;
namespace PortfolioProjectNigth.Controllers
{
    public class ChartController : Controller
    {
        DbMyPortfolioNightEntities1 context = new DbMyPortfolioNightEntities1();
        public ActionResult Index()
        {
            var values = context.Skill.ToList();
            return View(values);
        }
    }
}