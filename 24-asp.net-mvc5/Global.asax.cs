using _24_asp.net_mvc5.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace _24_asp.net_mvc5
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //注册区域
            AreaRegistration.RegisterAllAreas();
            //注册全局Filter
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //注册路由
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //合并压缩打包工具
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ControllerBuilder.Current.SetControllerFactory(new CustomControllerFactory());

            //log4net.Config.XmlConfigurator.Configure();

            log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo(System.Web.HttpContext.Current.Server.MapPath("web.config")));
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exception = Server.GetLastError();

            LogHelper.WriteLog("发生异常", exception);

            Response.ContentType = "text/html;charset=UTF-8";

            Response.Write("系统错误！！");

            Server.ClearError();
        }
    }
}
