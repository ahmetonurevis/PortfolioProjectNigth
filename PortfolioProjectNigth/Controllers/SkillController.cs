﻿using PortfolioProjectNigth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using Newtonsoft.Json.Linq;

namespace PortfolioProjectNigth.Controllers
{
    public class SkillController : Controller
    {
        DbMyPortfolioNightEntities1 context = new DbMyPortfolioNightEntities1();

        public ActionResult SkillList(int page = 1)
        {
            var values = context.Skill.ToList().ToPagedList(page, 5);
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSkill(Skill skill)
        {
            skill.Status = true;
            context.Skill.Add(skill);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        public ActionResult DeleteSkill(int id)
        {
            var value = context.Skill.Find(id);
            context.Skill.Remove(value);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var value = context.Skill.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateSkill(Skill skill)
        {
            var values = context.Skill.Find(skill.SkillID);
            values.SkillName = skill.SkillName;
            values.Rate = skill.Rate;
            values.Icon = skill.Icon;

            context.SaveChanges();

            return RedirectToAction("SkillList");
        }
        public ActionResult ChangeSkillToTrue(int id)
        {
            var value = context.Skill.Find(id);
            value.Status = true;
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        public ActionResult ChangeSkillToFalse(int id)
        {
            var value = context.Skill.Find(id);
            value.Status = false;
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
    }
}
