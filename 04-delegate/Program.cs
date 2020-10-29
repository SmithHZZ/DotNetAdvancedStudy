using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateTest delegateTest = new DelegateTest();

            delegateTest.Show();

            delegateTest.ActionTest();

            delegateTest.FuncTest();

            Console.ReadLine();
        }
    }
}
