using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11_thread._07_async_await
{
    /// <summary>
    /// async await语法和使用
    /// 
    /// 原理探究和使用建议
    /// 
    /// async await是C#保留关键字，通常是成对出现
    /// async 修饰方法
    /// await只能出现在async修饰的方法的内部,只能出现在task/async方法前面，只有await会报错
    /// 
    /// 是语法糖，编译器提供的功能
    /// 
    /// 
    /// async await能够用同步的方式编写代码，但又是非阻塞的
    /// 
    /// </summary>
    public class AsyncAwaitTest
    {
        /// <summary>
        /// 不推荐在winform中使用async
        /// </summary>
        public static void Test01()
        {
            //TestAsync1();
            //TestAsync2();
            TestAsync3();
        }

        /// <summary>
        /// IAsyncStateMachine
        /// 
        ///    public interface IAsyncStateMachine
        ///    {
        ///        void MoveNext();
        ///        void SetStateMachine(IAsyncStateMachine stateMachine);
        ///    }
        /// 
        /// 异步状态机
        /// 
        /// 状态机：
        ///     初始化状态0---执行就修改状态1---再执行就修改状态0---执行就修改状态1---如果出现其他窗台就结束了
        /// 
        /// </summary>
        public static void Test02()
        {
            IAsyncStateMachine asyncStateMachine;
        }

        private static async void TestAsync1()
        {
            Console.WriteLine($"当前主线程 ：{Thread.CurrentThread.ManagedThreadId.ToString("00")}");

            Thread.Sleep(1000);
            Console.WriteLine("async");
            
        }



        private static async void TestAsync2()
        {
            Console.WriteLine($"TestAsync2 ===== 当前主线程 ：{Thread.CurrentThread.ManagedThreadId.ToString("00")}");

            Task.Run(() =>
            {
                Console.WriteLine($"当前线程 ：{Thread.CurrentThread.ManagedThreadId.ToString("00")}");
                Thread.Sleep(1000);
                Console.WriteLine("async");
            });

            Console.WriteLine($"TestAsync2 ===== 当前主线程 ：{Thread.CurrentThread.ManagedThreadId.ToString("00")}");

        }

        //主线程调用async/await方法，主线程遇到await返回执行后续动作
        //await后面的代码会等着task任务的完成后再继续执行
        private static async void TestAsync3()
        {
            Console.WriteLine($"TestAsync3 ===== 当前主线程 ：{Thread.CurrentThread.ManagedThreadId.ToString("00")}");

            //await后，调用方法内部语句会继续执行，task执行结束后，await后语句继续执行
            await Task.Run(() =>
            {
                Console.WriteLine($"当前线程 ：{Thread.CurrentThread.ManagedThreadId.ToString("00")}");
                Thread.Sleep(1000);
                Console.WriteLine("async");
            });

            //这个语句可能是Task线程执行、可能是新的子线程执行，也可能是主线程
            Console.WriteLine($"TestAsync3 ===== 当前主线程 ：{Thread.CurrentThread.ManagedThreadId.ToString("00")}");

        }

    }
}
