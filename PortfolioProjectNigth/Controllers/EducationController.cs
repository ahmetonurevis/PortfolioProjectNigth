﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioProjectNigth.Controllers
{
    public class EducationController : Controller
    {
        public ActionResult EducationList()
        {
            return View();
        }

        public ActionResult CreateEducation()
        {
            return View();
        }
    }
}