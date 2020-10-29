using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_homework
{
    public class Student
    {
        [Desc("编号")]
        public int Id { set; get; }

        [Desc("姓名")]
        public string UserName { set; get; }

        [Desc("密码")]
        public string Password { set; get; }

        public static Student operator +(Student stu1, Student stu2)
        {
            return new Student() { Id = stu1.Id+stu2.Id,UserName = stu1.UserName+"-"+stu2.UserName,Password = stu1.Password+"-"+stu2.Password };
        }
    }
}
