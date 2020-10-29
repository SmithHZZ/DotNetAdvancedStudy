using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06_lambdalinq
{
    /// <summary>
    /// 
    /// Linq .net framework 3.0的重大改变
    /// 
    /// Lambda是实例化委托的参数（快捷方式）       匿名方法
    /// 
    /// Linq是基于委托的封装（基于泛型、委托、Lambda表达式实现），逻辑解耦，代码重用   帮助类库
    /// 
    /// 
    /// 
    /// </summary>
    public static class LinqTest
    {
        public static void Test01()
        {
            List<Student> list = new List<Student>();

            list.Where((s)=> 1 == 1 );
        }

        /// <summary>
        /// 这个方法要所有都结束才整体返回
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static IEnumerable<T> JsonWhere<T>(this IEnumerable<T> source,Func<T,bool> func)
        {
            
            List<T> list = new List<T>();
            foreach(var item in source)
            {
                Thread.Sleep(100);
                Console.WriteLine("JsonWhere进入检测");
                if(func(item))
                {
                    list.Add(item);
                }
            }

            return list;
        }


        /// <summary>
        /// 这个方法只要满足就会返回一个,外面使用了以后再次回来寻找满足的
        /// 懒（延迟）加载的意思
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static IEnumerable<T> JsonWhereIterator<T>(this IEnumerable<T> source, Func<T, bool> func)
        {
            List<T> list = new List<T>();
            foreach (var item in source)
            {
                Thread.Sleep(100);
                Console.WriteLine("JsonWhereIterator进入检测");
                if (func(item))
                {
                    //yield跟IEnumerable配对使用
                    yield return item;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TOut"></typeparam>
        /// <param name="source"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static IEnumerable<TOut> JsonSelect<T, TOut>(this IEnumerable<T> source,Func<T,TOut> func)
        {
            List<TOut> list = new List<TOut>();
            foreach (var item in source)
            {
                list.Add(func.Invoke(item));
            }

            return list;
        }

        static List<int> list = new List<int>()
        {
            10,20,22,125,21,54,21,2,12,12,564,564,2,123,1,541,54,23,1,23,321,1111,1,23456
        };

        public static void Test02()
        {


            var l1 = list.JsonWhere(i => i > 50);
            foreach(var i in l1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*************************************************");

            var l2 = list.JsonWhereIterator(i => i > 50);
            foreach (var i in l2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*************************************************");

            var l3 = list.JsonSelect(s => s + 10 );

            l3.ToList().ForEach(i => Console.WriteLine(i));

        }

        /// <summary>
        /// Linq to Object
        /// 
        /// 
        /// 针对的是IEnumbale数据，内存数据
        /// 
        /// 可变部分使用Func委托类型
        /// 
        /// </summary>
        public static void Test03()
        {
            //Linq to Object

            var temp = from i in list
                       where 1 == 1
                       group i by i.ToString().Length into t
                       select t;

            foreach (var data in temp)
            {
                Console.WriteLine($"Key == {data.Key} Min == {data.Min()} Max == {data.Max()}");//

                foreach (var item in data)
                {
                    Console.WriteLine(item);
                }

            }
        }

        /// <summary>
        /// Linq to Sql
        /// 
        /// 针对Queryable数据，
        /// 
        /// 数据库操作
        /// 
        /// 
        /// 封装通用的数据库操作
        /// 
        /// 
        /// 可以是内存数据，也可以不是
        /// 
        /// 可变部分使用表达式目录树，是可以解析的
        /// 
        /// </summary>
        public static void Test04()
        {
            list.Where(s =>
            {
                Console.WriteLine("Hello World!!!");
                return s > 1;
            });


            IQueryable<int> queryable = list.AsQueryable();
            //queryable.Where(s =>
            //{
            //    Console.WriteLine("Hello World!!!");
            //    return s > 1;
            //});

            queryable.Where(s => s > 1 );


        }

        /// <summary>
        /// 
        /// 
        /// Linq to XML
        /// 
        /// 
        /// 是一种伟大的封装思想，希望通过一种模式完成一切数据源的访问，
        /// 让开发者变成小白，不适合现在对开发者的要求
        /// 
        /// 开发入门容易，很容易就能做起来程序，但是精通起来难
        /// 
        /// </summary>
        public static void Test05()
        {

        }

    }
}
