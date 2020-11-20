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
        }
    }
}
