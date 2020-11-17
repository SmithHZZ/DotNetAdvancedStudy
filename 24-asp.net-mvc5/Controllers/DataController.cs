using _24_asp.net_mvc5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _24_asp.net_mvc5.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewDataTest()
        {
            ViewData["hello"] = "world";
            return View();
        }

        public ActionResult ViewBagTest()
        {
            ViewBag.hello = "world";
            return View();
        }

        public ActionResult TempDataTest()
        {
            TempData["hello"] = "world";
            return View();
        }

        public ActionResult ModelTest()
        {
            return View(new Student(){ Id = 1, Name = "Hello", Age = 18 });
        }
    }
}