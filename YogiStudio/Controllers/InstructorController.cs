using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YogiStudio.Models;

namespace YogiStudio.Controllers
{
    public class InstructorController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Instructor
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Calendar()
        {
            //var instructor = GetInstructors().ToList();
            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            ViewBag.Classes = new SelectList(db.ClassDetails.ToList(), "Id", "ClassName");
            ViewBag.ClassDescription = new SelectList(db.ClassDetails.ToList(), "Id", "ClassDescription");
            //ViewBag.Instructors = new SelectList(db.Customers.Where(x => instructor.Contains(x.ApplicationUserId)).ToList(), "Id", "Name");
            return View();
        }
        public ActionResult Bulletin()
        {
            
            return View(/*db.Bulletins.ToList()*/);
        }
        public ActionResult MyPay()
        {
            return View();
        }

        // GET: Instructor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Instructor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Instructor/Create
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

        // GET: Instructor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Instructor/Edit/5
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

        // GET: Instructor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Instructor/Delete/5
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
