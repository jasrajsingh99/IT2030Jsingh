using EventApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//using EventApplication.Models;

namespace EventApplication.Controllers
{
    public class HomeController : Controller
    {
        private EventDB db = new EventDB();

        public ActionResult LastMinuteDeals()
        {
            var events = GetLastMinuteDeals();
            return PartialView("_LastMinuteDeals", events);
        }

        public List<Event> GetLastMinuteDeals()
        {
            var today = DateTime.Now;
            //keep the get last minute deal method functional regardless of when it's used
            var LMD = today.AddDays(+2);
            // var events = db.Events
            return db.Events
              .Where(a => a.StartDate < LMD)
              .OrderBy(a => System.Guid.NewGuid())
              .ToList();

            //return events;
        }

        public ActionResult EventSearch(string q)
        {
            var events = GetEvent(q);
            return PartialView("_EventSearch", events);
        }

        private List<Event> GetEvent(string searchString)
        {
            return db.Events
               .Where(a => a.Title.Contains(searchString))
              .ToList();
        }


        public ActionResult EventSearchResults(string q)
        {
            var events = GetEventResults(q);
            return PartialView("_EventSearchResults", events);
        }

        private List<Event> GetEventResults(string searchString)
        {
            return db.Events
                 .Where(a => a.Location.Contains(searchString))
                .ToList();
        }


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

        public ActionResult FindEvent()
        {
            ViewBag.Message = "Find Event.";

            return View();
        }
    }
}