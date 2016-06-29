using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace chinaCoders.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs() 
        {
            ViewBag.Message = "Your application description page.";

            return View("AboutUs");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult text()
        {
            ViewBag.Message = "Your text page.";

            return View("text");
        }

    }
}