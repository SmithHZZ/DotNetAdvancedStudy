using _24_asp.net_mvc5.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _24_asp.net_mvc5.Controllers
{
    [CustomHandleError]
    public class ExceptionController : Controller
    {
        /// <summary>
        /// 不可能抓住这个异常
        /// 控制器构造后才有Filter
        /// </summary>
        public ExceptionController()
        {
            throw new Exception("ExceptionController ctor异常");
        }

        // GET: Exception
        public ActionResult Index()
        {
            int j = 0;
            int i = 10 / j;

            return View();
        }


        public ActionResult ExceptionView()
        {
            return View();
        }
    }
}