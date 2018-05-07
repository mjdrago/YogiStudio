using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YogiStudio.Models;

namespace YogiStudio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ApplicationDbContext context = new ApplicationDbContext();

                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var s = UserManager.GetRoles(user.GetUserId());

                if (s[0].ToString() == "Admin")
                {
                    return RedirectToAction("Index","Administrator");
                }
                else if (s[0].ToString() == "Customer")
                {
                    return RedirectToAction("Home", "Customers");
                }
                else if (s[0].ToString() == "Instructor")
                {
                    return RedirectToAction("Home", "Instructor");
                }
            }
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