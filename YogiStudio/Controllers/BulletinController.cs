using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YogiStudio.Models;

namespace YogiStudio.Controllers
{
    public class BulletinController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Bulletin
        private string message;
        private string name;
        private DateTime dateTime;
        private string comment;
        public ActionResult Index()
        {
            return View();
        }

        // GET: Bulletin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Bulletin/Create
        [HttpPost]
        public ActionResult PostMessage(Bulletin model)
        {           
            model.Name = name;
            model.Message = message;
            model.DateTime = dateTime;

            return View("InstructorBulletin");
        }
        [HttpGet]
        public ActionResult ReceiveMessage(Bulletin model)
        {
            model.Name = name;
            model.Message = message;
            model.DateTime = dateTime;

            return View("InstructorBulletin");
        }
        public ActionResult CreateComment(Bulletin model)
        {
            model.Name = name;
            model.Message = message;
            model.DateTime = dateTime;
            model.Comment = comment;

            return View("InstructorBulletin");
        }

        // POST: Bulletin/Create
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

        // GET: Bulletin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Bulletin/Edit/5
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

        // GET: Bulletin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Bulletin/Delete/5
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
