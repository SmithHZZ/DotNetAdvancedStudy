using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11_thread._01_sync_async
{
    public class SyncAsyncTest
    {
        public static void Test01()
        {
            Action<string> action = (s) => { Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} para is {s}"); };
            action("Hello");

            action.Invoke("World");

            //异步方法
            action.BeginInvoke("BeginInvoke", null, null);
        }

        /// <summary>
        /// 
        /// 解决Windows桌面程序
        /// 耗时操作界面假死问题
        /// 
        /// 
        /// web程序也是需要的，
        /// 例如发短信通知，异步多线程去发短信
        /// 
        /// 同步方法比较慢，
        /// 异步方法速度快
        /// 
        /// 线程数多数情况下不会等于时间花费倍数
        /// 因为资源受限
        /// 
        /// 多线程其实是资源换时间
        /// 
        /// 同步方法有序进行
        /// 
        /// 异步多线程方法无序进行
        /// 
        ///     启动无序：
        ///         向操作系统申请资源，就绪时间不同
        ///         上cpu调度的顺序也不能确定
        ///     结束也无序
        ///     
        ///     使用多线程小心，尤其是有顺序要求时
        ///     
        /// 等待：
        ///     WaitOne()
        ///     EndInvoke()
        ///     
        /// 
        /// </summary>
        public static void Test02()
        {
            new FormTest().ShowDialog();
        }
    }
}
