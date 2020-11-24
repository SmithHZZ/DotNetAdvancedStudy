using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _24_asp.net_mvc5
{
    public class RouteConfig
    {
        /// <summary>
        /// 
        /// 路由匹配遇到第一个吻合的就结束匹配
        /// 
        /// 
        /// 
        /// </summary>
        /// <param name="routes"></param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            //忽略路由
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //配置自己的路由
            routes.MapRoute(
                name: "Hello",
                url: "{controller}hello/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional}
            );

            //固定路由
            routes.MapRoute(
                name: "About",
                url: "About/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            //带约束的路由
            routes.MapRoute(
                name: "Test",
                url: "Test/{action}_{year}_{month}_{day}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new { year = @"\d{4}", month = @"\d{2}", day = @"\d{2}" }
            );

            //路由映射
            routes.MapRoute(
                //路由名称
                name: "Default",
                //匹配规则
                url: "{controller}/{action}/{id}",
                //默认值
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                //如果使用插件式开发，要加上这个配置
                //,namespaces: new string[] { "项目中的命名空间","项目外的插件命名空间" }
            );
        }
    }
}
