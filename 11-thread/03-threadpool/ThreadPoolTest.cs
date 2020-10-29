using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11_thread._03_threadpool
{
    /// <summary>
    /// 线程池
    /// 1、节约创建线程的时间和资源
    /// 2、实现对线程数量的管理
    /// 3、方便使用，不用关心线程的创建销毁
    /// 
    /// 
    /// 
    /// </summary>
    public class ThreadPoolTest
    {
        /// <summary>
        /// 线程池使用
        /// </summary>
        public static void Test01()
        {

            ThreadPool.QueueUserWorkItem(o => { Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}  {o}"); },"Hello");

            ThreadPool.QueueUserWorkItem(o => { Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}  {o}"); },"World");

            ThreadPool.GetMaxThreads(out int workerThreads, out int completionPortThreads);

            //设置进程全局的线程池线程数量，进程中有效
            //设置最大必须大于等于CPU的核数，否则无效
            ThreadPool.SetMaxThreads(1000, 1000);
            ThreadPool.SetMinThreads(10, 10);

            Console.WriteLine($"workerThreads:{workerThreads},completionPortThreads:{completionPortThreads}");
        }

        /// <summary>
        /// 线程池实现等待
        /// </summary>
        public static void Test02()
        {
            //类似于信号量的机制
            //ManualResetEvent manualResetEvent = new ManualResetEvent(false);
            ManualResetEvent manualResetEvent = new ManualResetEvent(true);

            ThreadPool.QueueUserWorkItem(o => {
                manualResetEvent.Set();
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}  {o} ********** 1");
            });

            ThreadPool.QueueUserWorkItem(o => {
                manualResetEvent.WaitOne();
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}  {o} ********** 2");
                
            });


        }
    }
}
