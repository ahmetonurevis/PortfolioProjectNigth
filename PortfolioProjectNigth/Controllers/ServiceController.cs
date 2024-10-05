using PortfolioProjectNigth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioProjectNigth.Controllers
{
    public class ServiceController : Controller
    {
        DbMyPortfolioNightEntities1 context = new DbMyPortfolioNightEntities1();

        public ActionResult ServiceList()
        {
            var values = context.Service.ToList();

            return View(values);
        }

        [HttpGet]
        public ActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateService(Service service)
        {
            context.Service.Add(service);
            context.SaveChanges();

            return RedirectToAction("ServiceList");
        }

        public ActionResult DeleteService(int id)
        {
            var value = context.Service.Find(id);
            context.Service.Remove(value);
            context.SaveChanges();

            return RedirectToAction("ServiceList");
        }

        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var value = context.Service.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateService(Service service)
        {
            var value = context.Service.Find(service.ServiceID);

            value.Title = service.Title;
            value.Description = service.Description;
            value.Icon = service.Icon;
            value.SubTitle1 = service.SubTitle1;
            value.SubTitle2 = service.SubTitle2;
            value.SubTitle3 = service.SubTitle3;
            context.SaveChanges();

            return RedirectToAction("ServiceList");
        }
    }
}