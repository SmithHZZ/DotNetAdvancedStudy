using _24_asp.net_mvc5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _24_asp.net_mvc5.Controllers
{
    /// <summary>
    /// 
    /// 特性
    /// 
    /// 
    /// 如果Action重载，必须通过特性来指定不同的访问方法
    /// 否则会出现异常
    /// 
    /// 如果没有特性标注，默认使用方法名作为路由依据
    /// 
    /// ChildActionOnly 标注的Action不能被单独请求，只能被子请求
    /// 
    /// Bind
    /// 指定只从前段接收哪些字段
    /// 
    /// ValidateAntiForgeryToken
    /// 防止重复提交
    /// cookie里加一个key，接收提交参数时先校验这个
    /// 
    /// MVC支持很多特性，全都是基于反射的
    /// 
    /// 
    /// </summary>
    public class AttributeController : Controller
    {
        [HttpGet]
        // GET: Attribute
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int Id)
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult ChildActionOnly()
        {
            return View();
        }

       
        public ActionResult Bind([Bind(Exclude = "", Include = "", Prefix = "")]Student student)
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public ActionResult ValidateAntiForgeryToken()
        {
            return View();
        }

    }
}