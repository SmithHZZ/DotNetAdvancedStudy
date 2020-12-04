using _24_asp.net_mvc5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _24_asp.net_mvc5.Utility
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {

        public override void OnAuthorization(AuthorizationContext filterContext)
        {

            //如果标注了匿名特性，直接放行
            if(filterContext.ActionDescriptor.IsDefined(typeof(AllowAnonymousAttribute),true))
            {
                return;
            }


            var httpContext = filterContext.HttpContext;

            if(httpContext.Session["CurrentUser"] == null || !(httpContext.Session["CurrentUser"] is CurrentUser))
            {
                LogHelper.WriteLog("接口" + httpContext.Request.Url.AbsoluteUri + "访问被拦截");
                filterContext.Result = new RedirectResult("~/Auth/Login");
                //断路器：指定了Result，那么请求就短路了，不会执行action
                
            }
            else
            {
                CurrentUser user = (CurrentUser)httpContext.Session["CurrentUser"];
                LogHelper.WriteLog("用户" + user + "访问接口" + httpContext.Request.Url.AbsoluteUri + "成功！");
            }

            //base.OnAuthorization(filterContext);
        }
    }
}