using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _19_UnitTestWebService.WCFTest01;

namespace _19_UnitTestWebService
{
    /// <summary>
    /// UnitTestWCF 的摘要说明
    /// </summary>
    [TestClass]
    public class UnitTestWCF
    {

        [TestMethod]
        public void TestMethod1()
        {
            using (ServiceTest01Client client = new ServiceTest01Client())
            {
                client.DoWork();

                Assert.AreEqual(client.Sum(1, 2), 3);
            }

                

            //Assert.AreEqual(client.Sum(1, 2), 5);
        }

        [TestMethod]
        public void TestMethod2()
        {
            using (ServiceTest01Client client = new ServiceTest01Client())
            {
                User user = client.GetUserById(10);

            }



            //Assert.AreEqual(client.Sum(1, 2), 5);
        }
    }
}
