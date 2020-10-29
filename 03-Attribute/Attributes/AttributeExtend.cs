using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03_Attribute.Attributes
{
    public static class AttributeExtend
    {
        public static string GetRemark(this Status status)
        {
            Type type = status.GetType();
            var filed = type.GetField(status.ToString());
            if(filed.IsDefined(typeof(RemarkAttribute),true))
            {
                RemarkAttribute atts = (RemarkAttribute)filed.GetCustomAttributes(typeof(RemarkAttribute),true)[0];

                return atts.Remark;
            }
            return "";
        }

        public static bool Vaildate<T>(this T t)
        {
            Type type = t.GetType();
            foreach(var prop in type.GetProperties())
            {
                if(prop.IsDefined(typeof(QQAttribute),true))
                {
                    QQAttribute att = (QQAttribute)prop.GetCustomAttributes(typeof(QQAttribute), true)[0];

                    if(!att.Vaildate(prop.GetValue(t)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
