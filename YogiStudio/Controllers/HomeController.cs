using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YogiStudio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Instructors()
        {
            return View();
        }
        public ActionResult CourseCalendar()
        {
            return View();
        }
        public ActionResult PackagesAndPricing()
        {
            return View();
        }
    }
}