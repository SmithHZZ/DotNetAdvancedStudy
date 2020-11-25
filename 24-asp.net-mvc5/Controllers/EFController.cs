using _24_asp.net_mvc5.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _24_asp.net_mvc5.Controllers
{
    /// <summary>
    /// 使用构造函数注入将需要的业务操作对象传入
    /// 
    /// 使用PageList进行分页
    /// </summary>
    public class EFController : Controller
    {
        private static List<Student> data = new List<Student>();

        static EFController()
        {
            for (int i = 0; i < 1000; i++)
            {
                data.Add(new Student { Id = i, Name = "Hello" + i, Age = (10 + i) % 90 });
            }
        }

        // GET: EF
        public ActionResult Index()
        {

            return View();
        }


        public ActionResult PageList(int page = 1,int size = 10)
        {
            ViewBag.MyPageList = data.ToPagedList(page, 20);

            return View();
        }
    }
}