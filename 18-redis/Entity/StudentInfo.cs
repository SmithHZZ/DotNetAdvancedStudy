using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_redis.Entity
{
    [Serializable]
    public class StudentInfo
    {
        public int Id { set; get; }

        public string UserName { set; get; }

        public int Age { set; get; }

        public string Address { set; get; }
    }
}
