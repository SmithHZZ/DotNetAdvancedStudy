using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;

namespace _19_soa_webservice.Models
{
    public class CustomSoapHeader : SoapHeader
    {
        public string UserName { set; get; }

        public string PassWord { set; get; }

        /// <summary>
        /// 必须有一个无参数的构造方法
        /// </summary>
        public CustomSoapHeader()
        {

        }

        public CustomSoapHeader(string username,string password)
        {
            UserName = username;
            PassWord = password;
        }

        public bool Validate()
        {
            return UserName.Contains("s") && PassWord.Contains("1");
        }

    }
}