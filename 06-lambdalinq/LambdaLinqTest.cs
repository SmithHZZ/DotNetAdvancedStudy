using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_lambdalinq
{
    public class LambdaLinqTest
    {

        public delegate void NoReturnNoPara();

        public delegate void NoReturnWithPara(int a);
        public void Test01()
        {
            //2.0 匿名方法
            //delegate关键字 可以访问局部变量
            {
                NoReturnNoPara  noReturnNoPara = new NoReturnNoPara(delegate (){
                    Console.WriteLine("Hello World!");
                });

                noReturnNoPara.Invoke();
            }
            //3.0 将delegate关键字去掉换成了=>符号 (goes to)
            //lambda表达式
            {
                NoReturnNoPara noReturnNoPara = new NoReturnNoPara(()=>{
                    Console.WriteLine("Hello World!");
                });

                noReturnNoPara.Invoke();

                //类型可以省略，编译时会加上，编译器的语法糖
                NoReturnWithPara noReturnWithPara = new NoReturnWithPara((a) =>
                {
                    Console.WriteLine($"语法糖{a}");
                });

                //如果方法体只有一行，大括号可以省，语句的；可以省
                noReturnWithPara += (int a) => Console.WriteLine($"{a}");

                noReturnWithPara.Invoke(1);

                //编译器的语法糖，new 可以省
                NoReturnWithPara noReturnWithPara1 = a=> Console.WriteLine($"语法糖{a}");

                noReturnWithPara1.Invoke(2);
            }

            {
                //lambda是什么，委托实例化的一个参数，就是一个方法
                //编译器会将lambda表达式存在一个类里面，lambda是匿名方法，但是编译的时候会分配一个名字
                //还会产生一个私有的sealed类，这里增加了一个方法

                NoReturnNoPara noReturnNoPara = () => Console.WriteLine("Hello World");

                noReturnNoPara += () => Console.WriteLine("Hello World");
                noReturnNoPara += () => Console.WriteLine("Hello World");

                noReturnNoPara -= () => Console.WriteLine("Hello World");

                noReturnNoPara.Invoke();

                //lambda表达式的内容虽然一样但是编译时，生成的是不同名字的方法，所以就不是一个方法  无法移除

            }


        }

        public void Test02()
        {
            {
                //匿名类
                //只能有属性不能有方法


                object model = new
                {
                    Id = 1,
                    UserName = "Json",
                    PassWord = "123@abcd"
                };
            
                //避开编译器检查
                dynamic dyObj = new
                {
                    Id = 1,
                    UserName = "Json",
                    PassWord = "123@abcd"
                };

                Console.WriteLine(dyObj.Id);


                var modelVar = new
                {
                    Id = 1,
                    UserName = "Json",
                    PassWord = "123@abcd"
                };

                //匿名类实例的属性只读，只能在初始化的时候指定
                //modelVar.Id = 100;

                //var是个语法糖可以自动推断类型

                Console.WriteLine(modelVar.GetType());
                Console.WriteLine(modelVar.Id);
                Console.WriteLine(modelVar.UserName);
                Console.WriteLine(modelVar.PassWord);
            }
        }

        public void Test03()
        {
            Func<string> func = () => { return "Hello World"; };

            func += () => "Hello2";

            func();
        }

    
    }
}
