using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _19_soa_webservice.Models
{
    [Serializable]
    public class User
    {
        public int Id { set; get; }

        public string UserName { set; get; } = "Json";

        public int Age { set; get; } = 18;

        public string PassWord { set; get; } = "123456";

        public string Address { set; get; } = "北京市东城区中南海";

    }
}