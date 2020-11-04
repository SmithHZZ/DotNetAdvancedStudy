using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_soa_webapi
{
    /// <summary>
    /// 
    /// RESTful架构风格和WebApi
    /// WebApi路由&特性路由
    /// WebApi依赖注入&面向切面
    /// 
    /// WebService WCF WebApi
    /// 
    /// RESTFUL
    ///     接口的设计风格
    ///     资源：万物看成资源
    ///     统一接口：CRUD 对应 get post put delete 请求方法
    ///     URI：统一资源定位符
    ///     无状态：基于Http协议
    ///     
    /// 网站启动执行Application_Start
    /// 给路由添加地址规则
    /// 请求进来时会经过路由匹配找到合适的控制器
    ///     如何找Action？
    ///         根据HttpMethod
    ///         
    ///     1、先根据Get开头曲匹配，已Get开头的方法默认都是Get时执行的
    ///     2、加特性修饰的方法[HttpGet]
    ///     3、按照参数找最吻合的
    ///     
    /// 特性路由  可以单独定制
    /// [Route(template:"api/Values/{id}/v2")]
    /// 
    /// 
    /// 
    /// 配合IOC、AOP使用
    /// 1、配置文件、完成容器初始化工作
    /// 2、容器和WebApi的整合
    ///     1、实现IDependencyResolver
    ///     2、在WebApiConfig类的Register方法中指定
    ///     config.DependencyResolver = new UnityDependencyResolver(ContainerFactory.BuildContainer());
    /// 
    /// 
    /// </summary>
    public class WebApiTest
    {

        public static void Test01()
        {

        }
    }
}
