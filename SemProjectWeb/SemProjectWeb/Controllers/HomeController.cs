using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SemProjectWeb.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index() {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult gallery()
        {
            return View();
        }

        public ActionResult services()
        {
            return View();
        }
        public ActionResult booking()
        {
            return View();
        }

        
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        
    }
}