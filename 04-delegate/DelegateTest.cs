using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04_delegate
{

    /// <summary>
    /// 
    /// 委托就是一个类，其实例可以放入一个方法
    /// 
    /// 
    /// 1、委托的声明
    /// 2、委托使用
    /// 3、委托使用场景
    /// 4、框架内置委托Action、Func
    /// 
    /// Action最多可以接受16个泛型参数
    /// 
    /// 为什么要有Action Func
    /// 1、对常用的委托提供一个标准，不然函数签名相同，也不能通用
    /// 
    /// 
    /// .Net向前兼容，以前有的东西也无法去掉，历史包袱
    /// 
    /// 在使用时就不要定义新的委托了，只要Action和Func能满足就使用Action、Func
    /// 
    /// 
    /// 任何一个委托都是多播委托 MulitCast Delegate
    /// 
    /// 可以通过+=来添加委托
    /// 
    /// -=操作可以移除，从尾部开始，遇到第一个完全吻合的就移除，且只移除一个
    /// 如何没有吻合的，就不做任何操作
    /// 
    /// 多播委托不能通过BeginInvoke方法调用
    /// 
    /// </summary>
    public class DelegateTest
    {
        public delegate void NoRNoP();

        public delegate void NoRWith1P(int a);

        public delegate int NoPWithR();

        public delegate int WithRWith2P(out int a,ref int b);

        public delegate void SayHai(string name);

        public Action<string> action;

        public Func<string> func;

        public void Show()
        {
            NoRNoP noRNoP = new NoRNoP(DoNothing);

            noRNoP += () => {
                Console.WriteLine("I am later");
            };

            noRNoP.Invoke();

            SayHiReal("张三",(s) =>
            {
                Console.WriteLine($"{s},晚上好");
            });

            SayHiReal("Three Zhang", (s) =>
            {
                Console.WriteLine($"{s},good evening");
            });

            SayHiReal("india", (s) =>
            {
                Console.WriteLine($"{s},萨瓦迪卡");
            });

        }

        public void DoNothing()
        {
            Console.WriteLine("this is do nothing");
        }

        public void StartGreet()
        {
            Console.WriteLine("prepare greet");
        }

        public void SayHiReal(string name,SayHai sayHai)
        {
            StartGreet();

            sayHai.Invoke(name);
        }

        public void ActionTest()
        {
            {
                Action action = new Action(() => { Console.WriteLine("Hello Action"); });

                action += DoNothing;

                

                action.Invoke();
                //action.BeginInvoke(null, null);
                foreach (Action item in action.GetInvocationList())
                {
                    item.Invoke();
                    item.BeginInvoke(null, null);
                }
            }

            {
                Action<string> action = new Action<string>(s =>
                {
                    Console.WriteLine("action-string=========>"+s);
                });

                action.Invoke("test");
            }
        }

        public void FuncTest()
        {
            {
                Func<int> func = new Func<int>(() => { return 1; });

                Console.WriteLine(func.Invoke());

                //启动线程进行调用
                func.BeginInvoke(null, null);

                
                
            }

            {
                Func<string, string> func = new Func<string, string>(s =>
                 {
                     return s.ToUpper();
                 });

                Console.WriteLine(func.Invoke("Hello World"));
            }
        }

        public void DelegationInFrameworkTest()
        {
            Thread thread = new Thread(new ThreadStart(()=> { Console.WriteLine("Thread"); }));

            Task task = new Task(() => {
                Console.WriteLine("Task");
            });

            thread.Start();

            task.Start();
        }
    }
}
