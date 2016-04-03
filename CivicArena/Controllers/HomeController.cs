using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CivicArena.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Interest()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Zipcode()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Signup()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Action()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Article()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}