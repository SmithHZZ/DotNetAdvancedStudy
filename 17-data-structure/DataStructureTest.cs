using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_data_structure
{

    /// <summary>
    /// 
    /// 数据结构
    /// 
    /// 1、集合set
    /// 
    /// 2、线性结构
    /// 
    /// 3、树形结构
    /// 
    /// 4、图状结构（网状）
    ///     地图应用
    ///     
    /// 1、内存连续存储
    ///     Array 定长的
    ///     ArrayList 变长的
    ///     List 泛型 本质上也是数组
    ///     
    /// 2、内存非连续存储
    ///     链表
    ///     LinkedList
    /// 
    /// </summary>
    public class DataStructureTest
    {
        /// <summary>
        /// 连续内存存储
        /// </summary>
        public static void Test01()
        {

            //数组
            int[] array = new int[10];

            array[0] = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.Write(array[i]+"\t");
            }

            //ArrayList
            ArrayList arrayList = new ArrayList();

            arrayList.Add("123");
            arrayList.Add(123);
            arrayList.Add(123.0);

            arrayList[2] = 4;

            foreach (var item in arrayList)
            {
                Console.Write(item + "\t");
            }

            //List
            List<string> list = new List<string>();

            list.Add("123");

            //会报错
            //list[2] = "11111";

            list.Add("11111");

            foreach (var item in list)
            {
                Console.Write(item + "\t");
            }
        }

        /// <summary>
        /// 非连续内存
        /// </summary>
        public static void Test02()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddFirst(0);
            linkedList.AddFirst(1);

            linkedList.AddFirst(2);
            linkedList.AddFirst(3);

            //linkedList.AddAfter();
            //linkedList.AddBefore();
            //linkedList.AddFirst();
            //linkedList.AddLast();

            LinkedList<int>.Enumerator enumerator = linkedList.GetEnumerator();

            do
            {
                Console.WriteLine(enumerator.Current);
            } while (enumerator.MoveNext());

            Console.WriteLine(linkedList.ElementAt(0));
        }

        /// <summary>
        /// 队列
        /// 
        /// 特殊链表
        /// 先进先出
        /// 
        /// 使用场景：A线程不断将任务放入队列，B线程不断从队列中拿出任务并执行
        /// </summary>
        public static void Test03()
        {
            Queue<int> queue = new Queue<int>();

            //添加到末尾
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(12);
            queue.Enqueue(13);
            queue.Enqueue(14);

            //只找出，不删除
            Console.WriteLine(queue.Peek());

            //找出并删除在第一个位置的元素
            Console.WriteLine(queue.Dequeue());
        }

        /// <summary>
        /// 
        /// 栈
        /// Stack
        /// 
        /// 特殊链表
        /// 
        /// 先进后出
        /// 
        /// 浏览器的浏览记录，前进后退
        /// 
        /// 操作撤销
        /// 
        /// </summary>
        public static void Test04()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine(stack.Pop());
            
        }

        /// <summary>
        /// set 纯粹的集合
        /// 
        /// 唯一的
        /// 无序的
        /// 
        /// HashSet
        /// 
        /// 
        /// IP投票
        /// 
        /// 找出共同好友
        /// 
        /// 可能认识的人 
        /// </summary>
        public static void Test05()
        {
            HashSet<int> hashset = new HashSet<int>();

            //重复添加会覆盖
            hashset.Add(1);
            hashset.Add(1);

            hashset.Add(2);
            hashset.Add(3);
            hashset.Add(4);
            hashset.Add(5);

            hashset.SymmetricExceptWith(hashset);//补
            hashset.UnionWith(hashset);//并
            hashset.ExceptWith(hashset);//差
            hashset.IntersectWith(hashset);//交



            foreach (var item in hashset)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// SortedSet
        /// 
        /// 排序集合
        /// 
        /// 
        /// 还有
        ///     SortedList
        ///     SortedDictionary
        /// </summary>
        public static void Test06()
        {
            SortedSet<int> sortedset = new SortedSet<int>();

            sortedset.Add(1);
            sortedset.Add(5);
            sortedset.Add(2);
            sortedset.Add(0);

            foreach (var item in sortedset)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// 增删都快
        /// 
        /// 
        /// Dictionary
        /// 
        /// 需要映射，也有冲突
        /// 
        /// 散列算法 数组长度 都会 影响性能
        /// 
        /// 冲突解决算法
        /// 
        /// </summary>
        public static void Test07()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "a");
            dictionary.Add(2, "b");
            dictionary.Add(3, "c");
            dictionary.Add(4, "d");
            dictionary.Add(5, "e");

            foreach (var item in dictionary)
            {
                Console.WriteLine($"key {item.Key} value {item.Value}");
            }

        }


        /// <summary>
        /// 每个集合类型都实现了很多接口
        /// 
        /// 如List，实现了下列接口
        /// IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
        /// 
        /// IList
        /// 数组类型约束
        /// 
        /// ICollection
        /// 集合类型约束
        /// 
        /// IEnumerable
        /// 迭代器模式
        /// 
        /// yield的使用，和迭代器配合使用
        /// 
        /// 原理：
        /// 是语法糖，编译时由编译器生成iterator代码
        /// 
        /// 
        ///     
        /// 
        /// </summary>
        public static void Test08()
        {

        }


        /// <summary>
        /// 
        /// dynamic
        /// 动态类型
        /// 
        /// 4.0出现
        /// 
        /// 让程序有了弱类型的特性
        /// 
        /// 作用：
        ///     1、有时可以代替反射，性能比反射高
        ///     2、数据绑定方便
        ///     3、跟c++交互方便
        /// 
        /// 原理：
        ///     声明dynamic会生成四个委托
        ///     任何跟dynamic交互都变成dynamic
        /// 
        /// 
        /// </summary>
        public static void Test09()
        {
            string s = "123";

            //强类型的检查
            //int i = (int)s;

            dynamic d = "123";

            //编译时不检查
            //运行时仍然报错
            int i = (int)d;

            Console.WriteLine(i);
        }
    }

}
