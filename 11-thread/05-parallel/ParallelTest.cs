using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11_thread._05_parallel
{
    public class ParallelTest
    {
        /// <summary>
        /// 
        /// </summary>
        public static void Test01()
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Main");

            //主线程会参与计算，阻塞界面
            //== TaskWaitAll + 主线程计算
            Parallel.Invoke(
                () => { Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Parallel1"); },
                () => { Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Parallel2"); },
                () => { Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Parallel3"); },
                () => { Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Parallel4"); },
                () => { Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Parallel5"); },
                () => { Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Parallel6"); }
                );

            Parallel.For(0, 5, (i) => { Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Parallel ====  {i}"); });

            Console.WriteLine("==================Finish===============");
        }

        /// <summary>
        /// Parallel.For(）的使用
        /// </summary>
        public static void Test02()
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Main");

            //从几开始，共几个
            Parallel.For(0, 5, (i) => { Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Parallel ====  {i}"); });

            Console.WriteLine("==================Finish===============");
        }

        /// <summary>
        /// ParallelOptions的使用
        /// </summary>
        public static void Test03()
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Main");

            ParallelOptions options = new ParallelOptions();
            options.MaxDegreeOfParallelism = 3;

            //这句话会阻塞，但是运行起来的线程不阻塞
            Parallel.For(0, 10, (i) => { Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Parallel ====  {i}"); });

            Console.WriteLine("==================Finish===============");
        }
    }
}
