using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_designpattern._01_Singleton
{
    public class SingletonTest
    {
        public static void Test01()
        {
            var s1 = Singleton1.GetInstance();
            var s2 = Singleton1.GetInstance();
            var s3 = Singleton1.GetInstance();
            var s4 = Singleton1.GetInstance();

            Console.WriteLine(s1 == s2);
            Console.WriteLine(s2 == s3);
            Console.WriteLine(s3 == s4);
            Console.WriteLine(s1 == s4);

            
        }

        public static void Test02()
        {
            for (int i = 0; i < 10; i++)
            {
                Task.Run(() =>
                {
                    Console.WriteLine(Singleton1.GetInstance().GetHashCode());
                });
            }
        }

        public static void Test03()
        {
            for (int i = 0; i < 10; i++)
            {
                Task.Run(() =>
                {
                    Console.WriteLine(Singleton1.GetInstanceWithLock().GetHashCode());
                });
            }
        }

        public static void Test04()
        {
            for (int i = 0; i < 10; i++)
            {
                Task.Run(() =>
                {
                    Console.WriteLine(Singleton1.GetInstanceWithLockWithOptimization().GetHashCode());
                });
            }
        }
    }
}
