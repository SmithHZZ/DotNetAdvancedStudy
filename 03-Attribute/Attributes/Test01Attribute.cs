using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Attribute.Attributes
{
    [AttributeUsage(AttributeTargets.All,AllowMultiple =true)]
    public class Test01Attribute : Attribute
    {
        public int Id;


        public Test01Attribute()
        {

        }

        public Test01Attribute(int Id)
        {
            this.Id = Id;
        }
    }
}
