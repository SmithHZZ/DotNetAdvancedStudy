using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05_event
{
    public class Program
    {
        static void Main(string[] args)
        {

            EventTest eventTest = new EventTest();

            eventTest.hello += () => {
                Console.WriteLine("时间发生了3");
            };

            eventTest.Test01();

            MainWindow main = new MainWindow();

            //new Thread(new ThreadStart(() =>
            //{
            //    main.ShowDialog();

            //})).Start();



            IPhoneX iPhoneX = new IPhoneX
            {
                Price = 10000
            };

            iPhoneX.DisCount += TellToLZN;
            iPhoneX.DisCount += Buy;

            iPhoneX.Price = 1000;


            Console.ReadKey();
        }

        public static void Buy(object sender, EventArgs e)
        {
             Console.WriteLine("买它，买它，买它");            
        }

        public static void TellToLZN(object sender, EventArgs e)
        {
            Console.WriteLine("LZN,快买");
        }
    }
}
