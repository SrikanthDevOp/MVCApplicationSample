using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShipleyDonutApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Menu()
        {
            ViewBag.Message = "Your menu page.";

            return View();
        }

        public ActionResult Franchise()
        {
            ViewBag.Message = "Your franchise page.";

            return View();
        }

        public ActionResult Community()
        {
            ViewBag.Message = "Your community page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Shop()
        {
            ViewBag.Message = "Your shop page.";

            return View();
        }
        public ActionResult StoreLocator()
        {
            ViewBag.Message = "Your store locator page.";

            return View();
        }
    }
}