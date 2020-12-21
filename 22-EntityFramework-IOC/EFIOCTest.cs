using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_EntityFramework_IOC
{
    /// <summary>
    /// 
    /// 每个Services都提供增删改查方法，让其继承父类，实现接口
    /// 
    /// 做一些常规的API和入门实现，
    /// 
    /// 每张表都来一个Service？
    /// 很多时候没法满足业务需求
    /// 所以在封装service时，需要划分边界，完成组合
    /// 
    /// 一个Service完成一个常用的整体操作
    /// 
    /// //订单和商品（订单项）
    /// OrderItemService
    /// 
    /// 根据项目实际情况，主外键关系的一般在一个Service
    /// 
    /// </summary>
    public class EFIOCTest
    {

        public void Test01()
        {

        }

    }
}
