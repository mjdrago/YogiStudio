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
        public ActionResult Index()
        {
            return View();
        }

        // GET: Bulletin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult ReceiveMessage(Bulletin model)
        {
            try
            {
                ApplicationDbContext db = new ApplicationDbContext();

                Bulletin newPost = new Bulletin();
                newPost.Message = model.Message;
                newPost.Name = model.Name;
                newPost.DateTime = DateTime.Now;

                db.Bulletins.Add(newPost);

                db.SaveChanges();
            }
            catch (Exception exception)
            {
                throw exception;
            }
          
            return RedirectToAction("Bulletin","Instructor");
        }

        // GET: Bulletin/Create
        [HttpPost]
        public ActionResult PostMessage(Bulletin model)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            Bulletin newPost = new Bulletin();
            newPost.Message = model.Message;
            newPost.Name = model.Name;
            newPost.DateTime = model.DateTime;

            db.Bulletins.Add(newPost);

            db.SaveChanges();

            return View();
        }
        [HttpGet]
        public ActionResult ReceiveComment(Bulletin model)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            Bulletin newComment = new Bulletin();

            newComment.Comment = model.Comment;
            newComment.Name = model.Name;
            newComment.DateTime = model.DateTime;

            db.Bulletins.Add(newComment);

            db.SaveChanges();

            return View();
        }
        [HttpPost]
        public ActionResult PostComment(Bulletin model)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            Bulletin newComment = new Bulletin();

            newComment.Comment = model.Comment;
            newComment.Name = model.Name;
            newComment.DateTime = model.DateTime;

            db.Bulletins.Add(newComment);

            db.SaveChanges();

            return View();
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
