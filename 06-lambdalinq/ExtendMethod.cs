using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_lambdalinq
{
    /// <summary>
    /// 扩展方法
    /// 
    /// 
    /// 1、静态类
    /// 2、静态方法
    /// 3、第一个参数前+this,要扩展的类型
    /// 
    /// 
    /// 
    /// 扩展方法的调用，像实例方法一样，就像扩展了Student的逻辑
    /// 
    /// 1、第三方的类，不适合修改源码，可以通过扩展方法增加逻辑
    /// 优先调用实例方法，最怕扩展方法增加了，别人类又修改了
    /// 2、适合组件式开发的扩展(.net core中很多)
    /// 定义接口或者类的时候，都是按照最小需求，但是在开发时又经常增加需要一些方法，就通过扩展方法
    /// context.Response,WriteAsyc()，中间件的注册
    /// 3、扩展一些常见操作
    /// </summary>
    public static class ExtendMethod
    {
        public static void Study(this Student student)
        {
            Console.WriteLine("学习，学个屁！");
        }

        public static void Hello<T>(this T t) where T : Student
        {
            Console.WriteLine("Hello World!");
        }
    }
}
