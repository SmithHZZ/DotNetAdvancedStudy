using _19_soa_webservice.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace _19_soa_webservice.WebService
{
    /// <summary>
    /// WebServiceTest01 的摘要说明
    /// 
    /// 
    /// WebService的五个核心要素
    /// 
    /// 1、Http传输信道
    ///     A服务器到B服务器数据是什么格式传输的
    ///     
    /// 2、XML数据格式
    ///     其中的数据是按照XMl格式包装的
    ///     
    /// 3、SOAP协议
    ///     封装格式、在分布式的环境中描述了如何做数据交换的轻量级协议，如何在跨平台、跨语言中解读方法、参数等
    ///     
    /// 4、WSDL：WebService的标配，标准化描述服务方便调用
    /// 
    /// 5、UDDI：根据描述查找服务的机制
    /// 
    /// 
    /// 
    /// WebService安全认证：
    ///     Form认证、Windows身份认证
    ///     服务方法参数里面添加账号密码
    ///     
    /// SoapHeader验证
    ///     1、创建自定义的SoapHeader，继承SoapHeader
    ///     2、在其中定义需要传递的验证信息，和对应的验证方法
    ///     3、在webservice的类中创建一个自定义的SoapHeader类型的字段
    ///     4、在需要使用SOAPHeader验证的方法上使用SoapHeader注解，同时将3中的字段名作为注解的构造方法的参数穿进去
    ///     5、在调用的时候，第一个参数就会变成自定义的SoapHeader类型的参数
    ///     6、在对应的方法中加入判断信息即可实现验证    
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceTest01 : System.Web.Services.WebService
    {

        public CustomSoapHeader SoapHeader { set; get; }

        
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [SoapHeader("SoapHeader")]
        [WebMethod(Description = "用于求解两个整数的和，传入整数a、b，返回a、b的和")]
        public int Sum(int a,int b)
        {
            if(SoapHeader.Validate())
            {
                return a + b;
            }

            throw new Exception("验证失败");
        }

        [SoapHeader("SoapHeader")]
        [WebMethod(Description = "用于获取用户信息，传入整数Id，返回该编号的用户信息")]
        public string GetUserById(int id)
        {

            if (SoapHeader.Validate())
            {
                Models.User user = new Models.User()
                {
                    Id = id
                };

                return JsonConvert.SerializeObject(user);
            }

            throw new Exception("验证失败");
        }

        //WebService不能重载
    }
}
