using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SnowSoftwareMVCPowerBIDemo.Controllers
{
    public class NavigationController : Controller
    {
        // GET: Navigation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Report()
        {
            return View("VersionReport");
        }

        public ActionResult Menu()
        {
            return PartialView("_Navigation");
        }
    }
}