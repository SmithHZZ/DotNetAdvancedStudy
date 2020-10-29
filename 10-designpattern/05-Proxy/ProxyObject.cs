using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_designpattern._05_Proxy
{
    /// <summary>
    /// 
    /// 包一层：没有什么问题是包一层不能解决的，如果有，就再包一层
    /// 
    /// 比如做日志记录，可以避免修改业务类，只需要修改代理类
    /// 
    /// 如异常处理
    /// 
    /// 如实现缓存，提升性能
    /// 
    /// 通过代理能为被代理对象增加功能，而并不是在业务方法里增加
    /// 
    /// </summary>
    public class ProxyObject
    {
        private RealObject RealObject = new RealObject();

        public void DoAdd()
        {
            Console.WriteLine("do add");
            RealObject.Add();
        }

        public void DoRemove()
        {
            try
            {
                RealObject.Remove();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
