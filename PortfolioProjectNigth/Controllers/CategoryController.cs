using PortfolioProjectNigth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace PortfolioProjectNigth.Controllers
{
	
	public class CategoryController : Controller
	{
		DbMyPortfolioNightEntities1 context = new DbMyPortfolioNightEntities1 ();
		public ActionResult CategoryList()
		{
			var values = context.Category.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(Category category)
        {
            context.Category.Add(category);
            context.SaveChanges();
            return RedirectToAction("CategoryList");
        }
    }
}