using _19_soa.WCFTest01;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_soa
{

    /// <summary>
    /// 
    /// WCF shi.NetFramework3.5出现的
    /// 
    /// 被称为分布式服务的集大成者
    /// 
    /// 新建WCF项目，或者在web项目中添加WCF服务都可以快速创建一个wcf服务
    /// 
    /// 支持不同的协议：http tcp ipc msmq p2p
    /// 支持不同的宿主：控制台 网站 winform windows服务
    /// 
    /// 双工
    ///     http不行，无状态
    ///     tcp/pipeline
    ///     核心思路就是回调
    /// 
    /// 1、抽象接口
    ///     ServiceContract
    ///     
    /// 2、方法
    ///     OperationContract
    ///     
    /// 3、实体
    ///     有无参构造的情况下，可以传过去
    ///     没有无参构造的情况下，需要加上DataContract特性
    ///     类上有特性的情况下，那么成员上需要DataMember特性，否则不可见
    ///     都不添加可以，要是添加了都要写
    ///     真实工作中都要带上
    /// 
    /// 
    /// 
    /// </summary>
    public class WCFTest
    {
        /// <summary>
        /// 
        /// WCF调用的一般模式
        /// 
        /// 
        /// </summary>
        public static void Test01()
        {
            ServiceTest01Client client = null;
            try
            {
                client = new ServiceTest01Client();

                User user = client.GetUserById(100);

                Console.WriteLine(JsonConvert.SerializeObject(user));
            }
            catch(Exception exc)
            {
                if(client != null)
                {
                    client.Abort();
                }
                Console.WriteLine(exc.Message);
            }
            finally
            {
                client.Close();
            }
        }
    }
}
