﻿
using PortfolioProjectNigth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioProjectNigth.Controllers
{
    public class EducationController : Controller
    {
        DbMyPortfolioNightEntities1 context = new DbMyPortfolioNightEntities1();

        public ActionResult EducationList()
        {
            var values = context.Education.ToList();
            return View(values);
        }

        public ActionResult CreateEducation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateEducation(Education education)
        {
            context.Education.Add(education);
            context.SaveChanges();

            return RedirectToAction("EducationList");
        }

        public ActionResult UpdateEducation(int id)
        {
            var value = context.Education.Find(id);

            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateEducation(Education education)
        {
            var value = context.Education.Find(education.EducationID);

            value.Title = education.Title;
            value.SubTitle = education.SubTitle;
            value.Description = education.Description;
            value.Date =education.Date;

            context.SaveChanges();

            return RedirectToAction("EducationList");
        }

        public ActionResult DeleteEducation(int id)
        {
            var value = context.Education.Find(id);
            context.Education.Remove(value);
            context.SaveChanges();

            return RedirectToAction("EducationList");
        }
    }
}