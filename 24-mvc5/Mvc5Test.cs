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
