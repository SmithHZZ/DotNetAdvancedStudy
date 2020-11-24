using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _24_asp.net_mvc5.Controllers
{
    /// <summary>
    /// 使用构造函数注入将需要的业务操作对象传入
    /// </summary>
    public class EFController : Controller
    {


        // GET: EF
        public ActionResult Index()
        {
            return View();
        }
    }
}