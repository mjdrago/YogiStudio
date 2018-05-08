using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using YogiStudio.Models;

namespace YogiStudio.Controllers
{
    public class MasterSchedulesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MasterSchedules
        public ActionResult Index()
        {
            var masterSchedules = db.MasterSchedules.Include(m => m.ClassId).Include(m => m.InstructorId);
            return View(masterSchedules.ToList());
        }

        // GET: MasterSchedules/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterSchedule masterSchedule = db.MasterSchedules.Find(id);
            if (masterSchedule == null)
            {
                return HttpNotFound();
            }
            return View(masterSchedule);
        }

        // GET: MasterSchedules/Create
        public ActionResult Create()
        {
            ViewBag.ClassDetailId = new SelectList(db.ClassDetails, "Id", "ClassName");
            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "FirstName");
            return View();
        }

        // POST: MasterSchedules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public bool Create(string classId,string instructorId, string NewEventDate, string NewEventTime, string NewEventDuration)
        {
            try
            {
                MasterSchedule newEvent = new MasterSchedule();
                newEvent.ClassDetailId = Int32.Parse(classId);
                newEvent.CustomerId = Int32.Parse(instructorId);
                newEvent.StartTime = DateTime.ParseExact(NewEventDate + " " + NewEventTime, "MM/DD/YYYY HH:mm", CultureInfo.InvariantCulture);
                newEvent.AppointmentLenghtInMinutes = Int32.Parse(NewEventDuration);
                db.MasterSchedules.Add(newEvent);
                db.SaveChanges();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        // GET: MasterSchedules/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterSchedule masterSchedule = db.MasterSchedules.Find(id);
            if (masterSchedule == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClassDetailId = new SelectList(db.ClassDetails, "Id", "ClassName", masterSchedule.ClassDetailId);
            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "FirstName", masterSchedule.CustomerId);
            return View(masterSchedule);
        }

        // POST: MasterSchedules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ClassDetailId,CustomerId,StartTime,AppointmentLenghtInMinutes")] MasterSchedule masterSchedule)
        {
            if (ModelState.IsValid)
            {
                db.Entry(masterSchedule).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClassDetailId = new SelectList(db.ClassDetails, "Id", "ClassName", masterSchedule.ClassDetailId);
            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "FirstName", masterSchedule.CustomerId);
            return View(masterSchedule);
        }

        // GET: MasterSchedules/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterSchedule masterSchedule = db.MasterSchedules.Find(id);
            if (masterSchedule == null)
            {
                return HttpNotFound();
            }
            return View(masterSchedule);
        }

        // POST: MasterSchedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MasterSchedule masterSchedule = db.MasterSchedules.Find(id);
            db.MasterSchedules.Remove(masterSchedule);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
