﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gomore.Controllers
{
    public class LibraryController : Controller
    {
        // GET: Library
        public ActionResult ModelLibrary()
        {
            return View();
        }
    }
}