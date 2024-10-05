using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using PortfolioProjectNigth.Models;
namespace PortfolioProjectNigth.Controllers
{
    public class InternController : Controller
    {
        DbMyPortfolioNightEntities1 context = new DbMyPortfolioNightEntities1();
        public ActionResult InternList()
        {
            var values = context.Intern.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult UpdateIntern(int id)
        {
            var value = context.Intern.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateIntern(Intern intern)
        {
            var value = context.Intern.Find(intern.InternID);
            value.Title = intern.Title;
            value.Description = intern.Description;
            value.SubTitle = intern.SubTitle;
            context.SaveChanges();
            return RedirectToAction("InternList");
        }
        public ActionResult DeleteIntern(int id)
        {
            var value = context.Intern.Find(id);
            context.Intern.Remove(value);
            context.SaveChanges();
            return RedirectToAction("InternList");
        }
        [HttpGet]
        public ActionResult CreateIntern()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateIntern(Intern intern)
        {
            context.Intern.Add(intern);
            context.SaveChanges();
            return RedirectToAction("InternList");
        }
    }
}