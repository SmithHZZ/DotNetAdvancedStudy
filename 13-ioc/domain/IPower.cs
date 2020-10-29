using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ioc.domain
{
    public abstract class IPower
    {

        public void Show()
        {
            Console.WriteLine($"{this} 充上电");
        }
    }
}
