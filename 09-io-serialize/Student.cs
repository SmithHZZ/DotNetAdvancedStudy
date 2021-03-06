﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_io_serialize
{
    [Serializable]
    public class Student
    {

        public int Id { set; get; }

        public string UserName { set; get; }

        public string Password { set; get; }

        public static Student operator +(Student stu1, Student stu2)
        {
            return new Student() { Id = stu1.Id+stu2.Id,UserName = stu1.UserName+"-"+stu2.UserName,Password = stu1.Password+"-"+stu2.Password };
        }
    }

    public class VoStudent
    {
        public int Id { set; get; }

        public string UserName { set; get; }

        public string Password { set; get; }

        public string ClassName { set; get; }

        public string SchoolName { set; get; }
    }
}
