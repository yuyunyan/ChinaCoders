using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace chinaCoders.Controllers
{
    [RoutePrefix("Public")]
    public class PublicController : BaseController
    {
        // GET: Public
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("LogIn")]
        public ActionResult Login()
        {
            return View();
        }
        [Route("LogOut")]
        public ActionResult LogOut()
        {
            return View();
        }
       
    }
}