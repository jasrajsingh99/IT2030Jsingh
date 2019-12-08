using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        // GET: /Product/Browse
        public string Browse()
        {
            return "Browse displayed.Browse()";
        }
        //
        // GET: /Product/Details/105
        public string Details()
        {
            return "Details displayed for Id=105.Details()";
        }
        //
        // GET: /Product/Location?zip=44124
        public string Location()
        {
            return "Location?zip=44124.Location()";
        }

    }
}