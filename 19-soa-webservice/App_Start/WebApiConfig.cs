using _19_soa_webservice.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace _19_soa_webservice
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //替换全局异常处理
            config.Services.Replace(typeof(IExceptionHandler), new CustomExceptionHandler());

            // Web API 配置和服务

            config.DependencyResolver = new UnityDependencyResolver(ContainerFactory.BuildContainer());

            // Web API 路由


            //全局注册
            //config.Filters.Add(new CustomExceptionFilterAttribute());
            //config.Filters.Add(new CustomBasicAuthorizeAttribute());

            
           
                

            // 路由配置
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // 特性路由
            config.MapHttpAttributeRoutes();
        }
    }
}
