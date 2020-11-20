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
