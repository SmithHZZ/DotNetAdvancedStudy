using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_homework
{
    public class HomeWork01
    {
        /// <summary>
        /// 输出对象的所有属性和值
        /// </summary>
        public static void Test01()
        {
            Student stu = new Student()
            {
                Id = 1,
                UserName = "Json",
                Password = "123456"
            };

            Type type = stu.GetType();

            foreach (var item in type.GetProperties())
            {
                Console.WriteLine($"{item.Name}:{item.GetValue(stu)}");
               
            }

            Console.WriteLine("*******************************************");

        }

        /// <summary>
        /// 使用自定义特性，输出对象属性描述和值
        /// </summary>
        public static void Test02()
        {
            Student stu = new Student()
            {
                Id = 1,
                UserName = "Json",
                Password = "123456"
            };

            Type type = stu.GetType();

            foreach (var item in type.GetProperties())
            {
                if(item.IsDefined(typeof(DescAttribute),true))
                {
                    DescAttribute descAttr = (DescAttribute)item.GetCustomAttributes(typeof(DescAttribute), true)[0];
                    Console.WriteLine($"{descAttr.Desc}:{item.GetValue(stu)}");
                }
            }

            Console.WriteLine("*******************************************");
        }
    }
}
