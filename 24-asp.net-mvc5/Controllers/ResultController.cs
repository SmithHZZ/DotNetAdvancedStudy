using _24_asp.net_mvc5.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _24_asp.net_mvc5.Controllers
{
    public class ResultController : Controller
    {
        [CustomActionFilter]
        // GET: Result
        public ActionResult Index()
        {
            return View();
        }
    }
}