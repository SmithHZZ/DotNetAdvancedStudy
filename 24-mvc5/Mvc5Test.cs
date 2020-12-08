using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_mvc5
{

    /// <summary>
    /// 
    /// ASP.NET MVC 是指Web开发框架
    /// V Views 用户看到的视图内容
    /// C Controller 控制器用于控制模型和视图
    /// M Model 数据传递模型 模型：业务模型和视图模型
    /// 
    /// 
    /// 后台给前台传值的方式：
    ///     1、ViewBag   动态类型
    ///     2、ViewData  字典类型
    ///     以上二者会覆盖，后者为准
    ///     3、Model     适合复杂数据，强类型
    ///     4、TempData 临时数据，可以跨Action传递，存在Session中，用一次就清理掉
    /// 
    /// 
    /// Route的使用和扩展
    ///     匹配时会将所有controller的子类的所有命名空间和方法进行存储，方便进行匹配，判断存在还是不存在
    ///     方便快速定位
    ///     
    ///     控制器类可以出现在web项目的外面作为dll出现，只要路由能匹配到就可以访问
    /// 
    ///             //忽略路由
    ///           routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
    ///           //配置自己的路由
    ///           routes.MapRoute(
    ///               name: "Hello",
    ///               url: "{controller}hello/{action}/{id}",
    ///               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional}
    ///           );
    ///           //固定路由
    ///           routes.MapRoute(
    ///               name: "About",
    ///               url: "About/{action}/{id}",
    ///               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
    ///           );
    ///           //带约束的路由
    ///           routes.MapRoute(
    ///               name: "Test",
    ///               url: "Test/{action}_{year}_{month}_{day}",
    ///               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
    ///               constraints: new { year = @"\d{4}", month = @"\d{2}", day = @"\d{2}" }
    ///           );
    ///       //路由映射
    ///       routes.MapRoute(
    ///           //路由名称
    ///           name: "Default",
    ///           //匹配规则
    ///           url: "{controller}/{action}/{id}",
    ///           //默认值
    ///           defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
    ///       );
    ///       
    /// Area区域
    ///     使用Area可以将项目拆分开，一个工程中可以包含多个web系统
    /// 
    /// 
    /// Razor语法，前后端语法混编
    /// 
    /// 
    /// 
    /// html扩展控件，后端封装到前端
    /// 
    /// 模板页Layout，局部也PartialView
    /// 
    /// IOC和MVC结合，工厂的创建和business初始化
    /// 
    /// log4net配置和使用
    /// 
    /// 自定义AuthorizeAttribute的创建和使用
    /// 
    /// 新建CustomAuthorizeAttribute 继承 AuthorizeAttribute
    /// 
    /// 重写其中的OnAuthorize方法，进行认证操作，
    ///     public class CustomAuthorizeAttribute : AuthorizeAttribute
    ///    {

    ///        public override void OnAuthorization(AuthorizationContext filterContext)
    ///    {

    ///        var httpContext = filterContext.HttpContext;

    ///        if (httpContext.Session["CurrentUser"] == null || !(httpContext.Session["CurrentUser"] is CurrentUser))
    ///        {
    ///            LogHelper.WriteLog("接口" + httpContext.Request.Url.AbsoluteUri + "访问被拦截");
    ///            filterContext.Result = new RedirectResult("Auth/Login");
    ///            //断路器：指定了Result，那么请求就短路了，不会执行action

    ///        }
    ///        else
    ///        {
    ///            CurrentUser user = (CurrentUser)httpContext.Session["CurrentUser"];
    ///            LogHelper.WriteLog("用户" + user + "访问接口" + httpContext.Request.Url.AbsoluteUri + "成功！");
    ///        }

    ///        //base.OnAuthorization(filterContext);
    ///    }
    ///}
    ///
    /// 最后，在需要进行身份认证的接口上进行特性的标注
    /// 或者在控制器上使用特性，那么该控制器中的所有方法进行访问时都需要认证
    /// 全局注册，全部请求都生效
    /// 
    /// AllowAnonymous匿名，单独加特性时没用的
    /// 其实需要验证时支持
    /// 
    /// 不光可以判断是否登录，还可以进行权限验证
    /// 
    /// Filter生效机制
    /// 
    /// 
    /// 统一的异常处理
    /// 
    /// 自定义异常处理特性继承 HandleErrorAttribute
    /// 
    /// 还是三种方式
    /// 1、在Action上使用特性
    /// 2、在Controller上使用特性
    /// 3、在FilterConfig中使用全局配置
    /// 
    /// 还有部分抓不到的异常，需要进行进一步处理
    /// 在Global中实现以下方法，进行异常处理
    /// protected void Application_Error(object sender, EventArgs e)
    /// 
    /// 
    /// IActionFilter
    /// IResultFilter
    /// 
    /// 在Action、Result执行的前后进行的操作
    /// 
    /// 1、创建自定义的ActionFilterAttribute 继承 ActionFilterAttribute
    /// 2、重写其中的OnActionExecuting、OnActionExecuted、OnResultExecuting、OnResultExecuted方法
    /// 3、三种生效方式和作用范围，同上
    /// 
    /// 生效顺序问题
    ///     不同位置注册生效顺序-全局->控制器->Action
    ///     同一位置按照先后顺序生效
    ///     设置后是按照从大到小执行
    ///     俄罗斯套娃
    /// 
    /// 日志、参数检测、缓存、重写试图、压缩、防盗链、统计访问量
    /// 
    /// 不同客户端区别处理、限流
    /// 
    /// 虽然很丰富，但是只能是以Action为单位
    /// 
    /// Action中内部调用别的类库，加操作，做不到
    /// 
    /// 需要使用IOC+AOP扩展
    /// 
    /// </summary>
    public class Mvc5Test
    {

        /// <summary>
        /// 
        /// </summary>
        public static void Test01()
        {

        }
    }
}
