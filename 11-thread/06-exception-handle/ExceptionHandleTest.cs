using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11_thread._06_exception_handle
{
    /// <summary>
    /// 多线程异常处理
    /// </summary>
    public class ExceptionHandleTest
    {

        private static readonly object obj = new object();


        /// <summary>
        /// 异常处理
        /// </summary>
        public static void Test01()
        {
            List<Task> tasks = new List<Task>();
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    int j = i;

                    tasks.Add(Task.Run(() =>
                    {
                        if (j == 10 || j == 20 || j == 30)
                        {
                            throw new Exception("异常");
                        }

                        Console.WriteLine($"Thread Id : {Thread.CurrentThread.ManagedThreadId},i========={j}");
                    }));

                    Task.WaitAll(tasks.ToArray());

                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            
        }

        public static void Test02()
        {
            new ExceptionHandleWindow().ShowDialog();
        }

        /// <summary>
        /// 线程取消
        /// 
        /// Task不能从外部终止任务，只能自己终止自己
        /// 
        /// 通知其他线程，有异常，停止工作
        /// 
        /// </summary>
        public static void Test03()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            //IsCancellationRequested初始值是false，调用cancel方法变成true，不能再变回去
            //cancellationTokenSource.IsCancellationRequested;
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    int j = i;

                    Task.Run(() =>
                    {
                        if (j == 10 || j == 20 || j == 30)
                        {
                            throw new Exception("异常");
                        }
                        if(!cancellationTokenSource.IsCancellationRequested)
                            Console.WriteLine($"Thread Id : {Thread.CurrentThread.ManagedThreadId},i========={j}");
                    });

                }
            }
            catch (Exception exc)
            {
                cancellationTokenSource.Cancel();
                Console.WriteLine(exc.Message);
            }
        }

        /// <summary>
        /// 临时变量
        /// 
        /// 
        /// 在多线程中使用变量的时候，特别是闭包
        /// 注意变量的值，和临时变量的使用
        /// </summary>
        public static void Test04()
        {
            //闭包
            //for (int i = 0; i < 10; i++)
            //{
            //    Task.Run(() =>
            //    {
            //        Console.WriteLine($"This is {i} ,ManagedThreadId {Thread.CurrentThread.ManagedThreadId}");
            //    });
            //}

            for (int i = 0; i < 10; i++)
            {
                int k = i;
                Task.Run(() =>
                {
                    Console.WriteLine($"This is k {k} , This is i {i} ManagedThreadId {Thread.CurrentThread.ManagedThreadId}");
                });
            }
        }

        /// <summary>
        /// 线程安全
        /// 
        /// 线程安全
        /// 
        /// 如果你的代码在多个进程中，
        /// 有多个进程同时运行这一段，如果每次运行的结果都是跟单线程运行时的结果一直，
        /// 那么就是线程安全的
        /// 
        /// 
        /// 线程安全问题一般都是有全局变量、共享变量、静态变量、硬盘文件、数据库数据
        /// 只要多线程修改都会有线程安全问题
        /// 
        /// 解决线程安全问题：
        /// 1、加锁 lock
        ///     lock语法糖  Monitor.Enter  引用类型，也不应该是string
        ///     推荐锁是：private static readonly object 不能是null
        ///     lock this容易产生问题
        ///     lock 中的代码不要太多
        /// 
        /// 2、使用线程安全集合
        /// System.Collections.Concurrent命名空间下的集合类
        /// 
        /// 3、数据分拆，避免多线程操作
        /// 
        /// 
        /// </summary>
        public static void Test05()
        {
            int j = 0;

            List<Task> tasks = new List<Task>();
            

            for (int i = 0; i < 100; i++)
            {
                tasks.Add(Task.Run(()=>
                {
                    //同一时刻只有一个线程能进入
                    lock(obj)
                    {
                        j++;
                    }
                    
                    Thread.Sleep(50);
                }));
            }

            Task.WaitAll(tasks.ToArray());

            Console.WriteLine(j);

            //以上是线程不安全代码
        }

    }
}
