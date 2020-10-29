using _03_Attribute.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Attribute
{
    //[Obsolete("请不要使用学生类了，使用研究生类来代替")]
    [Test01()]
    [Test01(1)]
    [Serializable]
    public class Student
    {
        [Remark("主键")]
        public int Id { set; get; }

        [Remark("用户名")]
        public string UserName { set; get; }

        [Remark("密码")]
        public string PassWord { set; get; }

        [Remark("QQ")]
        [QQ(10000,99999999999)]
        public long QQ { set; get; }
    }

    public enum Status
    {
        [Remark("开启")]
        On,
        [Remark("关闭")]
        Off
    }
}
