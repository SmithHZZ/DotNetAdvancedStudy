using System;
using _19_UnitTestWebService.WebServiceTest01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _19_UnitTestWebService
{
    /// <summary>
    /// 
    /// 单元测试
    /// 
    /// 
    /// 
    /// </summary>
    [TestClass]
    public class UnitTestWebService
    {

        static UnitTestWebService()
        {
            Console.WriteLine("静态构造函数！！！");
        }
        
        /// <summary>
        /// 执行每个测试方法之前都要执行
        /// 
        /// 该初始化方法
        /// </summary>
        [TestInitialize]
        public void TestInit()
        {
            Console.WriteLine("初始化测试数据！！！");
        }


        [TestMethod]
        public void TestMethod1()
        {
            using (WebServiceTest01.WebServiceTest01SoapClient client = new WebServiceTest01.WebServiceTest01SoapClient())
            {
                //Console.WriteLine($"client.Sum(1, 2) = {client.Sum(1, 2)}");

                CustomSoapHeader header = new CustomSoapHeader();

                header.UserName = "s101";

                header.PassWord = "123";

                Assert.AreEqual(client.Sum(header, 1, 2), 3);

                //Assert.AreEqual(client.Sum(1, 2), 4);

                Assert.AreEqual(client.Sum(header, 3, 2), 5);

                Assert.AreEqual(client.Sum(header, 3, 3), 6);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            using (WebServiceTest01.WebServiceTest01SoapClient client = new WebServiceTest01.WebServiceTest01SoapClient())
            {
                //Console.WriteLine($"client.Sum(1, 2) = {client.Sum(1, 2)}");

                CustomSoapHeader header = new CustomSoapHeader();

                header.UserName = "s101";

                header.PassWord = "23";

                string s = client.GetUserById(header, 10);

                Assert.IsTrue(s.Contains("10"));
            }
        }
    }
}
