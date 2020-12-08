using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _24_asp.net_mvc5.Utility
{
    public class CustomHandleErrorAttribute : HandleErrorAttribute
    {

        public override void OnException(ExceptionContext filterContext)
        {
            var httpContext = filterContext.HttpContext;

            if(!filterContext.ExceptionHandled)
            {
                LogHelper.WriteLog($"访问接口{httpContext.Request.Url}时发生异常：", filterContext.Exception);

                filterContext.Result = new ViewResult()
                {
                    ViewName = "~/Views/Shared/Error.cshtml",
                    ViewData = new ViewDataDictionary<string>(filterContext.Exception.Message)
                };
                filterContext.ExceptionHandled = true;

            }

            //base.OnException(filterContext);
        }

    }
}