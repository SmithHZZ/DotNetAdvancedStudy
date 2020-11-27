using _24_asp.net_mvc5.Models;
using _24_asp.net_mvc5.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _24_asp.net_mvc5.Controllers
{
    /// <summary>
    /// 
    /// Http请求的本质
    /// 
    /// 请求-应答式
    /// 
    /// 从页面下载文件还是在页面上显示文件内容，
    /// 靠的就是ContentType来控制的
    /// 
    /// application/pdf
    /// application/octet-stream
    /// 
    /// ActionResult的各种子类
    /// 
    /// ViewResult
    /// JsonResult
    /// 
    /// 
    /// 
    /// 
    /// </summary>
    public class HttpController : Controller
    {
        // GET: Http
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewTest()
        {
            return View();
        }

        /// <summary>
        /// 实现下载
        /// </summary>
        /// <returns></returns>
        public ActionResult FileTest()
        {
            return File( AppContext.BaseDirectory + @"\App_Data\Caffe.pdf", "application/octet-stream", "Caffe.pdf");
        }

        /// <summary>
        /// 实现在线预览
        /// </summary>
        /// <returns></returns>
        public ActionResult FileTest1()
        {
            Response.AppendHeader("ontent - disposition", "inline");
            Response.ContentType = "application/pdf";
            Response.WriteFile(AppContext.BaseDirectory + @"\App_Data\Caffe.pdf");

            return null;
        }

        /// <summary>
        /// 使用自定义的扩展ActionResult
        /// </summary>
        /// <returns>自定义的XmlResult对象</returns>
        public ActionResult CustomXmlResult()
        {
            Student student = new Student()
            {
                Id = 1,
                Name = DateTime.Now.ToString(),
                Age = 18
            };
            return new XmlResult(student);
        }
    }
}