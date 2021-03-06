﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using _19_soa_webservice.Models;

namespace _19_soa_webservice.WCF
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“ServiceTest01”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 ServiceTest01.svc 或 ServiceTest01.svc.cs，然后开始调试。
    public class ServiceTest01 : IServiceTest01
    {
        public void DoWork()
        {
            Console.WriteLine("DoWork");
        }

        public User GetUserById(int id)
        {
            return new User() { Id = id };
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sum2(int a, int b)
        {
            return a + b;
        }
    }
}
