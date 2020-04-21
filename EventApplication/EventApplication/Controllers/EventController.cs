using EventApplication.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventApplication.Controllers
{
    public class EventController : Controller
    {
        private EventDbContext db = new EventDbContext();

        //create, index, edit, details, delete 
        // GET: Event
        public ActionResult Index()
        {
            //return View(db.Events.ToList());
           // var events = db.Events.Include(c => c.eventType);
            return View(db.Events.ToList());
            //return View();
            //return View(events.ToList());
        }


        // GET: Event/Create
        public ActionResult Create()
        {
            return View();
        }
        //"Title,description,StartDate,StartTime,EndDate,EndTime,Location,eventType,OrganizerName,ContactIndo,MaxTickets,AvailableTickets"
        // POST: Order/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create([Bind(Include = "Title,description,StartDate,StartTime,EndDate,EndTime,Location,eventType,OrganizerName,ContactIndo,MaxTickets,AvailableTickets")] Event eventt)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(eventt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eventt);
        }

        // GET: Event/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event eventt = db.Events.Find(id);
            if (eventt == null)
            {
                return HttpNotFound();
            }
            return View(eventt);
        }

        // GET: Event/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event eventt = db.Events.Find(id);
            if (eventt == null)
            {
                return HttpNotFound();
            }
            return View(eventt);
        }

        // POST: Event/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Title,description,StartDate,StartTime,EndDate,EndTime,Location,eventType,OrganizerName,ContactIndo,MaxTickets,AvailableTickets")] Event eventt)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventt).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eventt);
        }

        // GET: Event/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event eventt = db.Events.Find(id);
            if (eventt == null)
            {
                return HttpNotFound();
            }
            return View(eventt);
        }

        // POST: Event/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Event eventt = db.Events.Find(id);
            db.Events.Remove(eventt);
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