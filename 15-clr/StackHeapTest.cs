using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_clr
{
    /// <summary>
    /// 
    /// 堆栈
    /// 
    /// 堆：Heap 进程存放引用变量的一块内存，全局唯一
    /// 栈：Stack 现金后出数据结构 ，线程栈 一个线程中存放变量的内存，随着线程的声明周期
    /// 
    /// 
    /// 值类型分配在栈上：结构 枚举
    /// 
    /// 引用类型分配在堆上：类  接口 委托
    /// 
    /// 
    /// </summary>
    public class StackHeapTest
    {

        /// <summary>
        /// 
        /// 值类型测试
        /// 
        /// </summary>
        public static void Test01()
        {
            //一定有默认无参构造函数
            StructTest structTest;
            //只有赋值才能使用
            structTest.x = 10;

            Console.WriteLine(structTest.x);

        }

        /// <summary>
        /// 
        /// 引用类型测试
        /// 
        /// </summary>
        public static void Test02()
        {
            //ReferenceTest referenceTest = new ReferenceTest(10);
            //referenceTest.x = 20;

            //1、调用new时就会去栈上开辟内存，创建实例
            //2、把实例的引用传递给构造函数
            //3、执行构造函数
            //4、返回引用
            ReferenceTest referenceTest = new ReferenceTest(10)
            {
                x = 20
            };

            Console.WriteLine(referenceTest.x);
        }

        /// <summary>
        /// 
        /// 装箱拆箱
        /// 
        /// </summary>
        public static void Test03()
        {
            int i = 3;

            object obj = i;

            int k = (int) obj;

            Console.WriteLine(k);
        }


    }

    //结构类型
    public struct StructTest //结构不能有父类，因为隠式继承了ValueType
    {
        public int x;

        public StructTest(int y)
        {
            x = y;
        }
    }

    public class ReferenceTest
    {
        //引用类型中的值类型，跟随对象的存储位置走
        public int x = 0;

        public ReferenceTest(int y)
        {
            x = y;
        }
    }
}
