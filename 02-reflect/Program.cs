using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02_reflect
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlDemo.Select<Student>(1);

            SqlDemo.Insert<Student>(new Student()
            {
                Id = 1,
                UserName = "Json",
                Password = "123456"
            });

            var s = new Student()
            {
                Id = 1,
                UserName = "Json",
                Password = "123456"
            } + new Student()
            {
                Id = 1,
                UserName = "Json",
                Password = "123456"
            };

            Console.WriteLine(s);


            dynamic stu = new Student();
            stu.Id = 3;
            //运行时会出现错误代码
            //stu.Hello = "world";
            Console.WriteLine(stu.UserName ?? "");

            //new Program().test();


            int? a = null;

            int b = a ?? 4;

            Console.WriteLine(b);










            Console.ReadKey();




        }

        public void test()
        {
            MethodInfo[] methodInfos = typeof(Program).GetMethods();
            foreach(MethodInfo methodInfo in methodInfos)
            {
                if(methodInfo.Name == "Show")
                {

                    switch(methodInfo.GetParameters().Count())
                    {
                        case 0:
                            methodInfo.Invoke(Activator.CreateInstance(typeof(Program)), new object[] { });
                            break;
                        case 1:
                            methodInfo.Invoke(Activator.CreateInstance(typeof(Program)), new object[] { "hello" });
                            break;
                    }
                    
                    
                }

                Console.WriteLine("methodInfo.Name-------------->" + methodInfo.Name);
            }


            #region 调用私有方法
            {
                Type type = typeof(Program);

                var method = type.GetMethod("Show", BindingFlags.NonPublic | BindingFlags.Instance);

                method.Invoke(Activator.CreateInstance(type), new object[] { "123" });

            }
            #endregion




            Console.ReadKey();
           
        }

        public void Show()
        {
            Console.WriteLine("Hello");
        }

        private void Show(string hello)
        {
            Console.WriteLine("Hello---"+hello);
        }
    }
}
