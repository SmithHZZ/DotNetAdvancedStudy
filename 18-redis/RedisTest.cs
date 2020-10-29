using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_redis
{

    /// <summary>
    /// Redis
    /// 
    /// 分布式缓存
    /// 
    /// Memcache现在较少
    /// 
    /// nosql - redis 主流
    /// 
    /// NoSql 非关系型数据库：Not Only Sql
    ///     web 1.0 服务端提供数据，客户端只看
    ///     web 2.0 可以互动了，评论等
    ///         数据的关系复杂：好友关系
    ///         数据读写压力，硬盘无法满足
    ///         数据量较大
    ///         
    /// 特点：
    ///     1、基于内存，效率高
    ///     2、没有严格的数据格式
    ///     3、丰富的类型，满足web2.0需求
    ///     
    /// Redis：Remote Dictionary Server
    /// 
    ///     远程字典服务器
    /// 
    /// 基于内存管理，实现了五种数据结构，分别应对各种具体需求
    /// 单进程、单线程
    /// 
    /// 对外提供了插入-查询-固化-集群等功能
    /// 
    /// RDB
    /// 
    /// 可以配置保存内存快照
    /// 
    /// AOF
    ///     有数据增加就加日志
    /// 
    /// 
    /// 五种数据结构
    /// 
    /// string: key-value 缓存 value不超过512M
    /// hash
    /// set
    /// zset
    /// list
    /// 
    /// </summary>
    public class RedisTest
    {

        /// <summary>
        /// 
        /// </summary>
        public static void Test01()
        {

        }
    }
}
