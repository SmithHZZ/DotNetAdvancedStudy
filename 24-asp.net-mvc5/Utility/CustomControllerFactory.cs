using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _24_asp.net_mvc5.Utility
{
    /// <summary>
    /// 实现自定义的控制器工厂
    /// 满足容器的注入
    /// </summary>
    public class CustomControllerFactory : DefaultControllerFactory
    {
        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            Console.WriteLine(controllerName+ " created !");

            //这里使用Container容器创建控制器

            return base.CreateController(requestContext, controllerName);
        }
    }
}