using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace _19_soa_webservice.Models
{
    [Serializable]
    [DataContract]
    public class User
    {
        [DataMember]
        public int Id { set; get; }

        [DataMember]
        public string UserName { set; get; } = "Json";

        [DataMember]
        public int Age { set; get; } = 18;

        [DataMember]
        public string PassWord { set; get; } = "123456";

        [DataMember]
        public string Address { set; get; } = "北京市东城区中南海";

    }
}