﻿using _19_soa_webservice.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace _19_soa_webservice
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            config.DependencyResolver = new UnityDependencyResolver(ContainerFactory.BuildContainer());

            // Web API 路由
            // 特性路由
            config.MapHttpAttributeRoutes();

            // 路由配置
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
