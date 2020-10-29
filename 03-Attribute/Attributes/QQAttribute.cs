using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Attribute.Attributes
{
    [AttributeUsage(AttributeTargets.Field|AttributeTargets.Property)]
    public class QQAttribute : Attribute
    {
        private long _Min = 0;
        private long _Max = 0;

        public QQAttribute(long min,long max)
        {
            this._Max = max;
            this._Min = min;
        }

        public bool Vaildate(object value)
        {
            return value != null 
                && long.TryParse(value.ToString(), out long iValue) 
                && iValue >= _Min 
                && iValue <= _Max;
        }

    }
}
