﻿using MVCMusicStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMusicStoreApplication.Controllers
{
    public class StoreController : Controller
    {
        MVCMusicStoreDB db = new MVCMusicStoreDB();

        // GET: Store
        [HttpGet]
        public ActionResult Index(int? id)
        {
            return View(db.Albums
                .Where(a => a.GenreId == id)
                .ToList());
       
        }

        // GET: Store/Browse?genre=value
        [HttpGet]                   
        public ActionResult Browse()
        {

            return View(db.Genres.ToList());
        }

        // GET: Store/
        [HttpGet]
        public ActionResult Details(int? id)
        {
            Album album = db.Albums.Find(id);
            return View(album);

        }
      
    }
}