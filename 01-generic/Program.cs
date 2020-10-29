using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_generic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listInt = new List<int>();

            new Program().Show("hello").Show(0);


            Console.ReadKey();
        }

        private Program Show<T>(T t)
        {
            Console.WriteLine(t.GetType().Namespace+"."+t.GetType().Name+"========="+t);
            return this;
        }
    }

    interface GenericInterface<T> where T : Program {

        void Show(T t);

    }

    class GenericClass<T> where T : Program
    {

        void Show(T t)
        {
            Console.WriteLine(t.GetType().Namespace + "." + t.GetType().Name + "=========" + t);
        }

    }



}
