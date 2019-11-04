using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;


namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {

        private MusicStoreDB db = new MusicStoreDB();

        // GET: Store
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = db.Albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View();
        }

        // GET: /Store/Browse
        [HttpGet]
        public ActionResult Browse()
        {
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name");

                
            return View();
        }

        // GET: /Store/Details
        [HttpGet]
        public ActionResult Details(int? id)
        {


            return View();
        }


        // GET: /Store/Details/5
        /*public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = db.Albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }
        */



    }
}