using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ioc.domain.impl
{
    public class Game : IGame
    {
        public Game()
        {
            Console.WriteLine($"{this} 被构造");
        }

        public Game(int a,int b)
        {

            Console.WriteLine($"{this} 带两个整型参数a={a},b={b}  被构造");
        }
    }
}
