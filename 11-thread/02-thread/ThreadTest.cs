using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11_thread._02_thread
{
    /// <summary>
    /// 
    /// Thread C#对线程对象的封装
    /// 
    /// 
    /// </summary>
    public class ThreadTest
    {
        /// <summary>
        /// 线程的创建
        /// </summary>
        public static void Test01()
        {
            //无参数，无返回值的委托
            ThreadStart threadStart = () =>
            {
                Console.WriteLine("Hello World");
            };
            //创建线程
            Thread thread = new Thread(threadStart);
            //
            thread.Start();
        }

        /// <summary>
        /// Thread的常用操作
        /// </summary>
        public static void Test02()
        {
            //一个object类型的参数，无返回值
            ParameterizedThreadStart parameterizedThreadStart = (o) =>
            {
                Console.WriteLine(o);
            };

            Thread thread = new Thread(parameterizedThreadStart);

            thread.Start("hello world thread");
            //挂起线程，不知道什么时候会暂停，让线程操作变得很复杂
            thread.Suspend();
            //恢复线程，恢复也不是立即恢复
            thread.Resume();

            //终结线程，肯定会结束，但不知道什么时候结束
            thread.Abort();
            //会等待线程完成，才执行接下来的操作
            thread.Join();
            thread.Join(1000);
            //设置优先级
            //优先执行，但不代表优先完成，具体情况还是要看操作系统的调度
            thread.Priority = ThreadPriority.Normal;
            //设置后台线程
            //默认是false 前台线程，进程关闭，线程需要计算结束才退出，后台线程则会立即退出
            thread.IsBackground = true;
            //恢复终结线程
            Thread.ResetAbort();
        }

        /// <summary>
        /// 获取多线程执行的返回值
        /// </summary>
        public static void Test03()
        {
            int i = 0;

            ThreadStart threadStart = new ThreadStart(() =>
           {
               Thread.Sleep(2000);
               i = 100;
               
           });

            Thread thread = new Thread(threadStart);
            thread.Start();

            thread.Join();

            Console.WriteLine(i);
        }


    }
}
