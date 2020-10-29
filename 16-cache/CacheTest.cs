using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_cache
{
    /// <summary>
    /// 
    /// 系统性能优化的第一步就是使用缓存
    /// 
    /// 缓存：第一次获取数据时放在某个位置，下次直接用，提升后面每次获取数据的效率
    /// 
    /// 读取配置文件信息放在静态字段就是缓存
    /// 
    /// 客户端缓存（浏览器缓存）
    ///     当前用户
    /// 
    /// CDN 缓存
    ///     一群用户
    ///     对内容做缓存
    /// 
    /// 反向代理
    ///     所有用户
    ///     缩短访问路径，加快响应速度，减轻服务器压力
    ///     
    /// 服务器端做缓存
    ///     本地（内存）缓存
    ///     实现形式：静态字典
    ///     
    /// 分布式缓存
    ///     redis
    ///     memorycache
    /// 
    /// 
    /// </summary>
    public class CacheTest
    {

        /// <summary>
        /// 
        /// </summary>
        public static void Test01()
        {

        }

    }
}
