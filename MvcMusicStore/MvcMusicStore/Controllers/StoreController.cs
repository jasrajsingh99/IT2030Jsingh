using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
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
        public ActionResult Index(int? id   )
        {
            Genre genre = db.Genres.Find();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = db.Albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(genre);
        }

        // GET: /Store/Browse
        [HttpGet]
        public ActionResult Browse()
        {
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name");
            Genre genre = db.Genres.Find();
            //var genre = MusicStoreDB.Genre.ToList();


            return View(genre);
        }

        // GET: /Store/Details
        [HttpGet]
        public ActionResult Details(int? id)
        {
            Album album = db.Albums.Find(id);
            return View(album);
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