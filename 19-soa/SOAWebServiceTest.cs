using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_soa
{
    /// <summary>
    /// 
    /// SOA
    /// service-oriented architecture
    /// 面向服务架构
    /// 
    /// 指导如何对服务进行拆分、提供一些标准、规范
    /// 
    /// 1、多个应用通过数据库（或者其他存储方式）进行交互，被动式（更新的内容需要自己去获取才知道更新）
    /// 
    /// 2、服务式 WebService（还有用的，不流行）、WCF（较笨重）、WebApi（主流）
    ///     传递序列化数据（性能比rpc低）、根据数据执行操作、跨平台、跨语言
    ///     
    /// 3、Remoting
    ///     .Net平台内部的（服务和客户端都是.Net平台的）
    ///     服务式是传值的，Remoting传的是引用（委托）（把逻辑传过去了）
    ///     
    /// 
    /// WebService
    /// 
    /// </summary>
    public class SOAWebServiceTest
    {

        /// <summary>
        /// 调用WebService
        /// 
        /// 服务端调用WebService添加服务引用，基于svcUtil.exe生成的基于wsdl生成的一个代理：
        ///     屏蔽服务调用的复杂性
        ///     
        /// 
        /// 
        /// </summary>
        public static void Test01()
        {
            using (WebServiceTest01.WebServiceTest01SoapClient client = new WebServiceTest01.WebServiceTest01SoapClient())
            {
                Console.WriteLine($"client.Sum(1, 2) = {client.Sum(1, 2)}");

            }

        }
    }
}
