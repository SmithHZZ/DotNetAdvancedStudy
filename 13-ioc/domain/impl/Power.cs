using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ioc.domain.impl
{
    public class Power : IPower
    {
        public Power()
        {
            Console.WriteLine($"{this} 被实例化");
        }
    }
}
