using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ioc.container
{
    [AttributeUsage(AttributeTargets.Constructor)]
    public class CustomInjectionConstructorAttribute : Attribute
    {
        public CustomInjectionConstructorAttribute()
        {

        }
    }
}
