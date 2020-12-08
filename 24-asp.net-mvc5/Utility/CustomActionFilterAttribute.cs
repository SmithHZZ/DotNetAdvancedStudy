using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _24_asp.net_mvc5.Utility
{
    public class CustomActionFilterAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// Action执行前
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            LogHelper.WriteLog("OnActionExecuting");
            filterContext.HttpContext.Response.Write("OnActionExecuting");
        }

        /// <summary>
        /// Action执行后
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            LogHelper.WriteLog("OnActionExecuted");
            filterContext.HttpContext.Response.Write("OnActionExecuted");
        }

        /// <summary>
        /// Result执行前
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            LogHelper.WriteLog("OnResultExecuting");
            filterContext.HttpContext.Response.Write("OnResultExecuting");
        }

        /// <summary>
        /// Result执行后
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            LogHelper.WriteLog("OnResultExecuted");
            filterContext.HttpContext.Response.Write("OnResultExecuted");
        }
    }
}