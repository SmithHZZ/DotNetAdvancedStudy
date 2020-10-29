using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_event
{
    /// <summary>
    /// 事件
    /// 
    /// 一个委托的实例，带event关键字
    /// 限制权限，只允许在事件声明内进行赋值和invoke，不允许外面进行
    /// 
    /// 
    /// 事件与委托的区别和联系
    /// 
    /// 委托是一种类型，事件是委托类型的一个实例，加上了event权限控制
    /// 
    /// 
    /// 事件无处不在，winform wpf webform 请求级事件
    /// 
    /// 解耦 单一职责 安全性
    /// 
    /// 
    /// 
    /// </summary>
    public class EventTest
    {
        public event Action hello= () =>
            {
                Console.WriteLine("时间发生了1");
            };

        public void Test01()
        {

            hello += () => {
                Console.WriteLine("时间发生了2");
            };

            hello.Invoke();
        }
    }
}
