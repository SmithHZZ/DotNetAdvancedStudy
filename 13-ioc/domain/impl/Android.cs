using _13_ioc.container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ioc.domain.impl
{
    public class Android : IPhone
    {
        public Android()
        {
            Console.WriteLine($"{this} 被构造");
        }

        [CustomInjectionConstructor]
        public Android(IPower power)
        {
            Console.WriteLine($"带一个{power}参数的{this} 被构造");
            power.Show();
        }

        public Android(IPower power,int rest)
        {
            Console.WriteLine($"带2个参数power = {power},rest = {rest} 的{this} 被构造");
            power.Show();
        }

        public void Show()
        {
            Console.WriteLine($"type : {this}  now is {DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}");
        }
}
}
