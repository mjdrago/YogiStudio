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
    public class AdministratorController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Administrator
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CRUDCalendar()
        {
            var instructor = GetInstructors().ToList();
            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            ViewBag.Classes = new SelectList(db.ClassDetails.ToList(), "Id", "ClassName");
            ViewBag.ClassDescription = new SelectList(db.ClassDetails.ToList(), "Id", "ClassDescription");
            ViewBag.Instructors = new SelectList(db.Customers.Where(x => instructor.Contains(x.ApplicationUserId)).ToList(), "Id", "Name");
            return View();
        }

        private IQueryable<string> GetInstructors ()
        {
            var instructorRole = db.Roles.Where(h => h.Name.ToString() == "Instructor").FirstOrDefault();
            var instructorID = instructorRole.Id.ToString();
            return from user in db.Users
                   where user.Roles.Any(r => r.RoleId.ToString() == instructorID)
                   select user.Id;

        }
        public ActionResult CRUDEmployee()
        {
            return View();
        }
        public ActionResult CRUDPackagesAndPricing()
        {
            return View();
        }
        public ActionResult PayEmployees()
        {
            return View();
        }


        // GET: Administrator/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Administrator/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administrator/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Administrator/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Administrator/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Administrator/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Administrator/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
