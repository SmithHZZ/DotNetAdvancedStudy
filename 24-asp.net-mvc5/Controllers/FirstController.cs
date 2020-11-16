using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace _24_asp.net_mvc5.Controllers
{
    /// <summary>
    /// 
    /// ActionResult是顶层抽象类
    /// 
    /// ViewResult 是 ViewResultBase 子类
    /// 
    /// ViewResultBase 是 ActionResult 子类
    /// 
    /// </summary>
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            //这里返回的就是 ViewResult
            return View();
        }

        public ViewResult Json()
        {
            return new ViewResult();
        }

        /// <summary>
        /// 
        /// /First/IndexId/2
        /// 这样传是路由解析出来的，只有Id可以这样
        /// 
        /// /First/IndexId?Id=1
        /// url地址传参
        /// 
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public ViewResultBase IndexId(int Id)
        {
            return View();
        }

        public ViewResultBase IndexIdNull(int? Id)
        {
            return View();
        }

        public string StringName(string name)
        {
            return $"My Name is {name}";
        }

        public string JsonName(string name)
        {
            return JsonConvert.SerializeObject(new { Id = 1, Name = name });
        }

        
        public JsonResult JsonTest(string name)
        {
            return new JsonResult()
            {
                Data = new { Id = 1, Name = name },
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };

        }

        /// <summary>
        /// 直接下载文件
        /// </summary>
        /// <returns></returns>
        public FileResult FileTest()
        {
            return File(Encoding.UTF8.GetBytes("Hello World!!!"), "file", "hello.txt");
        }
    }
}