﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace New_Lab2_IT2030.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public string Index()
        {
            return "Product/Index is displayed";
        }

        // GET: /Product/Browse
        public string Browse()
        {
            return "Browse displayed";
        }

        // GET: /Product/Details/105
        public string Details(int id)
        {
            string message = "Details displayed for Id=" + id;
            return message;
        }

        // Get: /Product/Location?zip=44124
        public string Location(int zip)
        {
            string message = HttpUtility.HtmlEncode("Location displayed for zip=" + zip);
            return message;
        }
    }
}