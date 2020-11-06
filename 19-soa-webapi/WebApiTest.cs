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
    /// 认证实现
    ///     1、实现自定义的AuthorizeAttribute
    ///     2、重写其中的OnAuthorization方法，该方法会在Action执行前执行
    ///     3、将特性标注在需要进行认证处理的控制器或Action上
    ///     
    /// 
    /// 异常处理
    ///     使用特性：
    ///     1、实现自定义的ExceptionFilterAttribute
    ///     2、重写其中的OnException方法
    ///     3、将特性标注在需要进行自定义异常处理的控制器或Action上
    ///     注意：其作用域范围，仅在Action内部的异常，像一些参数错误、路由之类的异常，是无法生效的
    ///     
    ///     全局的：
    ///     1、实现自定义的全局异常处理，ExceptionHandler
    ///     2、重写其中的Handler方法
    ///     3、在WebApi的配置类中，进行如下配置
    ///       config.Services.Replace(typeof(IExceptionHandler),new CustomExceptionHandler());
    /// 
    /// 
    /// 跨域处理
    ///     浏览器处于安全考虑对于在访问A网站时，其中js对B网站的接口等资源进行访问时，进行的一种阻止
    ///     以a标签的形式、frame的方式等浏览器自己的行为都是可以的，但是js中对跨站资源的访问都是默认不可以的
    ///     默认是不允许的，但是加上 access-control-allow-origin 响应头时表明该资源允许跨域，是可以的
    ///     
    /// 解决跨域的方式
    ///     Jsonp   只能用get请求
    ///     CORS    跨域资源共享，允许服务器在响应时带上access-control-allow-origin头部 ，支持跨域
    ///         添加Cors支持包 Microsoft.AspNet.WebApi.Cors
    ///         // 支持来自所有网站的所有跨域请求 
    ///         在WebApi的注册方法里配置
    ///         config.EnableCors(new EnableCorsAttribute("*","*","*"));
    ///         单个控制器或者Action支持跨域，可使用特性EnableCorsAttribute进行标注      
    ///         
    ///     为保证浏览器兼容，Jquery指定Jquery.support.cors = true;
    /// 
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
