using _11_thread._01_sync_async;
using _11_thread._02_thread;
using _11_thread._03_threadpool;
using _11_thread._04_task;
using _11_thread._05_parallel;
using _11_thread._06_exception_handle;
using _11_thread._07_async_await;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11_thread
{
    /// <summary>
    /// 进程：虚拟的概念
    /// 
    /// 

    /// 
    /// 硬件对多线程的支持
    /// 
    /// 四核8线程
    /// 
    /// 4核指的物理核
    /// 
    /// 8线程指模拟线程（模拟核）
    /// 
    /// CPU分片：
    /// 
    /// 比如将1s分成1000份，系统调度去执行不同的任务
    /// 从宏观角度（用户角度）看，像是多个程序在并发执行
    /// 
    /// 同步和异步
    /// 
    /// 
    /// C#中的多线程
    /// 
    /// Thread   是对线程相关属性的包装
    /// 
    /// public Thread(ThreadStart start);
    /// 
    ///     ThreadStart
    ///     是无参数无返回值的委托
    ///         public delegate void ThreadStart();
    /// 
    /// public Thread(ParameterizedThreadStart start);
    /// 
    ///     ParameterizedThreadStart
    ///     是有一个object类型参数，无返回值的委托
    ///         public delegate void ParameterizedThreadStart(object obj);
    /// 
    /// 
    /// 
    /// public Thread(ThreadStart start, int maxStackSize);
    /// 
    /// 为该线程指定最大栈大小
    /// 
    /// public Thread(ParameterizedThreadStart start, int maxStackSize);
    /// 
    /// 为该线程指定最大栈大小
    /// 
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //new Thread(new ThreadStart(() => { Console.WriteLine("ThreadStart"); })).Start();

            //new Thread(new ParameterizedThreadStart(obj => { Console.WriteLine($"ParameterizedThreadStart Parameter is :{obj.ToString()}"); })).Start("Hello ParameterizedThreadStart");

            //SyncAsyncTest.Test01();

            //SyncAsyncTest.Test02();

            //ThreadTest.Test02();

            //ThreadTest.Test03();

            //ThreadPoolTest.Test01();

            //ThreadPoolTest.Test02();

            //TaskTest.Test01();

            //TaskTest.Test02();

            //TaskTest.Test03();

            //ParallelTest.Test01();

            //ParallelTest.Test02();

            //ParallelTest.Test03();

            //ExceptionHandleTest.Test02();

            //ExceptionHandleTest.Test04();

            //ExceptionHandleTest.Test05();


            AsyncAwaitTest.Test01();

            Console.ReadKey();
        }
    }
}
