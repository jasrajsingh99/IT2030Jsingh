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
        //MvcMusicStoreDB db = new MvcMusicStoreDB();

        // GET: Store
        [HttpGet]
        public ActionResult Index(int? id   )
        {
            var genre = db.Genres.ToListAsync(  );
            return View(genre);
        }

        // GET: /Store/Browse
        [HttpGet]
        public ActionResult Browse()
        {
            //ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name");
            //Genre genre = db.Genres.Find();
            var genre = db.Genres.ToList();
            //var genreModel = db.Genres.Include("Albums").Single(g => g.Name == genre);
            //var genre = db.Genres.Find();

            return View(genre);
        }

        // GET: /Store/Details
        [HttpGet]
        public ActionResult Details(int? id)
        {
            //Album album = db.Albums.Find(id);
            //var album = new Album { Title = "Album " + id };
            var album = db.Albums.Find(id);
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