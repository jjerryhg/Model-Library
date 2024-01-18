using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gomore.Controllers
{
    public class FactoryController : Controller
    {
        // GET: Factory
        public ActionResult Upload()
        {
            return View();
        }
        public ActionResult Parameter()
        {
            return View();
        }
    }
}