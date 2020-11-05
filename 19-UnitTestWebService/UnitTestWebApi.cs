using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace _19_UnitTestWebService
{
    /// <summary>
    /// UnitTestWebApi 的摘要说明
    /// </summary>
    [TestClass]
    public class UnitTestWebApi
    {
        static WebClient client = new WebClient();

        static UnitTestWebApi()
        {
            client.Headers.Add(HttpRequestHeader.Accept, "*/*");
            client.Headers.Add(HttpRequestHeader.UserAgent, "PostmanRuntime/7.26.8");
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
            client.Headers.Add(HttpRequestHeader.Host, "localhost");
            client.Encoding = Encoding.UTF8;
        }

        [TestMethod]
        public void TestMethod1()
        {
            string s = client.DownloadString("http://localhost:2271/api/user/getuserinfo2");

            Console.WriteLine(s);
            
        }
    }
}
