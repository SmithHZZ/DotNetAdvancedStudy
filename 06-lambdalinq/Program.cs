using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_lambdalinq
{
    public class Program
    {
        static void Main(string[] args)
        {
            LambdaLinqTest lambdaLinqTest = new LambdaLinqTest();
            //lambdaLinqTest.Test01();
            //lambdaLinqTest.Test02();


            Student student = new Student();

            ExtendMethod.Study(student);
            
            //扩展方法
            student.Study();

            //泛型扩展方法
            student.Hello();

            //lambdaLinqTest.Test03();


            //LinqTest.Test01();
            //LinqTest.Test02();
            LinqTest.Test03();

            Console.Beep();



            Console.ReadKey();
        }
    }
}
