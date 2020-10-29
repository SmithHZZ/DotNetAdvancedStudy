using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_designpattern._01_Singleton
{
    /// <summary>
    /// 
    /// 单例模式
    /// 
    /// 为什么要有单例模式
    /// 
    /// 构造对象耗时耗资源，很多地方都要使用
    /// 想避免重复构造
    /// 
    /// 公开静态字段的解决方案弊端：
    /// 1、提前构造
    /// 2、没办法保证都使用这个，没有进行约束
    /// 
    /// 实现
    /// 1、私有构造器
    /// 2、持有一个当前类型的对象
    /// 3、有公开的、静态的提供该对象的方法
    /// 
    /// 
    /// 
    /// 应对特殊情况，比如连接数据库连接池
    /// 
    /// 单例可以避免重复创建，但是也会常驻内存
    /// 
    /// 原型模式：换个方式创建对象，不走构造函数，二十内存拷贝
    /// 
    /// 
    /// </summary>
    public class Singleton1
    {
        private Singleton1()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        private static Singleton1 singleton1 = null;

        private static readonly object objLock = new object();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Singleton1 GetInstance()
        {
            if(singleton1 == null)
            {
                singleton1 = new Singleton1();
            }

            return singleton1;
        }

        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <returns></returns>
        public static Singleton1 GetInstanceWithLock()
        {
            //限制并发
            lock (objLock)
            {
                if (singleton1 == null)
                {
                    singleton1 = new Singleton1();
                }
            }
            
            return singleton1;
        }

        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <returns></returns>
        public static Singleton1 GetInstanceWithLockWithOptimization()
        {
            if (singleton1 == null)
            {
                //限制并发
                lock (objLock)
                {
                    if (singleton1 == null)
                    {
                        singleton1 = new Singleton1();
                    }
                }
            }

            return singleton1;
        }
    }
}
