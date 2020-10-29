using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_homework
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DescAttribute : Attribute
    {
        public string Desc { set; get; }
        public DescAttribute(string desc)
        {
            Desc = desc;
        }
    }
}
