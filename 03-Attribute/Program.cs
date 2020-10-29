using _03_Attribute.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Attribute
{
    /// <summary>
    /// 特性学习
    /// Attribute
    /// 
    /// 
    /// 特性attribute是个类，直接或者间接继承自Attribute类
    /// 
    /// 约定俗成用Attribute结尾，使用特性时可以省略
    /// 
    /// 
    /// 如何在程序运行时找到添加的特性-----反射
    /// 
    /// 特性是在编译时确定的，无法使用变量值
    /// 
    /// 所以filter是不能注入的，所以在.net core中才提供filter注入
    /// 
    /// 
    /// 
    /// 1、通过特性提供额外数据
    /// ReamrkAttribute
    /// 
    /// 2、通过特性提供额外行为
    /// 
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            object[] objAttrs = typeof(Student).GetCustomAttributes(typeof(Test01Attribute), true);

            foreach (object obj in objAttrs)
            {
                Test01Attribute attr = obj as Test01Attribute;

                Console.WriteLine(attr + "===========" + attr.Id);
            }

            Console.WriteLine(Status.Off.GetRemark());
            Console.WriteLine(Status.On.GetRemark());

            Console.WriteLine(AttributeExtend.Vaildate<Student>(new Student() { QQ = 100000000}));

            Console.WriteLine(AttributeExtend.Vaildate(new Student() { QQ = 0}));

            Console.WriteLine(new Student().Vaildate());

            Console.WriteLine(new Student() { QQ = 100000000 }.Vaildate());



            Console.ReadLine();

            
            
        }
    }
}
