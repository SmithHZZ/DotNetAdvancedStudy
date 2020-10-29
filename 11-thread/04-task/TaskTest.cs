using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11_thread._04_task
{
    public class TaskTest
    {
        /// <summary>
        /// 
        /// task的基本使用
        /// 
        /// task的线程是源于线程池的
        /// 
        /// 所以线程池的设置会影响到Task的使用
        /// 
        /// </summary>
        public static void Test01()
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Hello World");

            
            Task task = new Task(()=>
            {
                
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Hello World");
            });
            
            task.Start();
            //同步等待，当前线程等待0.2秒然后继续
            Thread.Sleep(2000);
            //异步等待，不会阻塞
            Console.WriteLine($"Delay前");
            Stopwatch stopwatch = new Stopwatch();
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch.Start();
            stopwatch1.Start();
            //Delay会创建一个任务，等待指定时间后开启任务
            Task t1 = Task.Delay(2000).ContinueWith((t) =>
            {
                stopwatch1.Stop();
                Console.WriteLine($"Delay结束,耗时{stopwatch1.ElapsedMilliseconds}");
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Hello World");
            });
            stopwatch.Stop();
            Console.WriteLine($"Delay后,耗时{stopwatch.ElapsedMilliseconds}");
        }

        /// <summary>
        /// 什么时候能用多线程：任务能并发的时候
        /// 
        /// 多线程能干嘛：提升速度，优化用户体验
        /// 
        /// </summary>
        public static void Test02()
        {
            List<Task> tasks = new List<Task>();

            TaskFactory taskFactory = new TaskFactory();

            tasks.Add(taskFactory.StartNew(() => { Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Hello World2"); }));
            tasks.Add(taskFactory.StartNew(() => { Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Hello World3"); }));
            tasks.Add(taskFactory.StartNew(() => { Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Hello World4"); }));
            tasks.Add(taskFactory.StartNew(() => { Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Hello World1"); }));
            tasks.Add(taskFactory.StartNew(() => { Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Hello World5"); }));

            //阻塞当前线程等待某个任务完成
            //Task.WaitAny(tasks.ToArray());

            //阻塞当前线程，等待任务全部完成
            //也有限时等待的重载
            //Task.WaitAll(tasks.ToArray());

            Console.WriteLine("================Finish================");

            //列表页：核心数据可能来自多个渠道（数据库、搜索引擎、分布式服务、缓存），多线程并发请求，那个先完成就用哪个结果，其他的就不用了


            //ContinueWhenAny、ContinueWhenAll都是非阻塞式的回调
            //而且使用的线程是新线程或者是刚完成工作的线程，唯一不可能是主线程

            taskFactory.ContinueWhenAny(tasks.ToArray(), t =>
            {
                
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} 有人完成了");
            });

            taskFactory.ContinueWhenAll(tasks.ToArray(), ts =>
            {
                Console.WriteLine("Happy");
            });


        }

        /// <summary>
        /// 
        /// </summary>
        public static void Test03()
        {
            Task<int> task = Task.Run<int>(() =>
            {
                Console.WriteLine("Hello World Run()");
                Thread.Sleep(1000);
                return -1;
            });

            //会阻塞
            int i = task.Result;

            Console.WriteLine($"i:{i}");

        }
    }
}
