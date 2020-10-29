using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Attribute.Attributes
{
    [AttributeUsage(AttributeTargets.Field|AttributeTargets.Property)]
    public class RemarkAttribute : Attribute
    {
        public string Remark { get; private set; }

        public RemarkAttribute(string remark)
        {
            Remark = remark;
        }
    }
}
