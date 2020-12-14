using _18_redis.Entity;
using _18_redis.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// redis中每个命令都是原子性的
    /// 
    /// 五大结构理解
    /// string key-value的存储，支持过期，value不超过512M
    ///     redis是单线程的，比如setall
    ///     缓存用户信息的方案：
    ///         1、k-v id-序列化字符串
    ///             修改和查询都比较麻烦，因为不可能每次都是需要获取用户的所有信息
    ///         2、k-v 
    ///             userinfo_id_username-hello
    ///             userinfo_id_age-18
    ///             数据项很多修改方便
    ///     string类型的value最小值是512byte
    /// hash
    ///     会为各种开发问题提供解决方案
    ///     hash是一种zipmap存储，数据紧密排列，可以节约空间
    ///     配置zip的两个属性，只要都满足就可以zipmap存储
    ///     
    /// set 无序 去重
    /// 
    /// zset 有序集合
    /// 
    /// list
    ///     方便添加
    ///     
    ///     每次写入数据的时把标题_Id写入List，查询最近的200个
    ///     用户刷新页面就不需要去数据库，直接redis
    ///     
    ///     第一次的时候可以不管分页只拿，最新数据
    ///     
    ///     存数据的时候可以仅保存Id+表名称
    ///     
    ///     主要是数据库量大，变化快的分页数据查询
    ///     
    ///     80%的访问集中在20%的数据
    ///     
    ///     list里面只保存大概的量就够用了
    ///     
    ///     可以重复
    ///     队列，生产者消费者，一个数据只有一个消费对
    ///     
    ///     发布订阅，观察者弄湿：微信订阅号 群聊天 数据同步
    ///     MSMQ RabbitMQ ZeroMQ
    ///     
    ///     项目中使用场景 与mq的使用场景相同：
    ///         异步 解耦 削峰
    /// 
    ///     
    /// 
    /// </summary>
    public class RedisTest
    {

        static StudentInfo student = new StudentInfo()
        {
            Id = 0,
            UserName = "Hello",
            Age = 18,
            Address = "北京市东城区中南海"
        };

        /// <summary>
        /// 
        /// 测试string操作
        /// 
        /// newtonsoft 和 redis一起使用时会出现各种问题
        /// 
        /// 建议使用servicestack自带的
        /// 
        /// </summary>
        public static void Test01()
        {
            RedisStringService stringService = new RedisStringService();

            var str = JsonConvert.SerializeObject(student);

            StringBuilder sb = new StringBuilder();
            string[] parts = str.Split(new char[] { ' ', '\n', '\t', '\r', '\f', '\v', '\\' }, StringSplitOptions.RemoveEmptyEntries);
            int size = parts.Length;
            for (int i = 0; i < size; i++)
                sb.AppendFormat("{0}", parts[i]);
            str = sb.ToString();

            stringService.Set($"UserInfo:{student.Id}", str);

            string temp = stringService.Get($"UserInfo:{student.Id}");

            sb = new StringBuilder();
            for (int i = 0; i<size; i++)
                sb.AppendFormat("{0}", parts[i]);
            temp = sb.ToString();
            StudentInfo s1 = JsonConvert.DeserializeObject<StudentInfo>(temp);


            stringService.Set($"student_name_{student.UserName}", student);

            temp = stringService.Get($"student_name_{student.UserName}");

            StudentInfo s2 = JsonConvert.DeserializeObject<StudentInfo>(temp);
        }

        /// <summary>
        /// 
        /// 测试hash操作
        /// 
        /// </summary>
        public static void Test02()
        {
            using (RedisHashService hashService = new RedisHashService())
            {
                hashService.SetEntryInHash("student", "id", "123456");
                hashService.SetEntryInHash("student", "name", "王哥");
                hashService.SetEntryInHash("student", "age", "18");
                hashService.SetEntryInHash("student", "address", "中南海");

                var keys = hashService.GetHashKeys("student");
                var values = hashService.GetHashValues("students");
                var keyvalues = hashService.GetAllEntriesFromHash("student");
                Console.WriteLine(hashService.GetValueFromHash("student","id"));

                //设置一下值如果不存在
                hashService.SetEntryInHashIfNotExists("student", "id", "987654");
                hashService.SetEntryInHashIfNotExists("student", "desc", "this is test");

                hashService.SetEntryInHash("student", "id", "753951");
                

                //包含Id的实体可以直接存储和读取
                hashService.StoreAsHash(student);
                StudentInfo s3 = hashService.GetFromHash<StudentInfo>(student.Id);


            }
        }

        /// <summary>
        /// 
        /// Set 无序去重
        /// 
        /// 一个key 一堆value
        /// 
        /// </summary>
        public static void Test03()
        {
            using (RedisSetService setService = new RedisSetService())
            {
                setService.Add("hello", "world");
                setService.Add("hello", "world1");
                setService.Add("hello", "world3");
                setService.Add("hello", "world2");
                setService.Add("hello", "world4");
                setService.Add("hello", "world2");

                string res = setService.GetRandomItemFromSet("hello");

                HashSet<string> data = setService.GetAllItemsFromSet("hello");
                foreach (var item in data)
                {
                    Console.WriteLine(item);
                }

                //使用场景：
                //好友管理 共同好友 可能认识

                //Ip统计 投票限制 好友关系 点赞数

                //交叉并补的操作
                setService.GetIntersectFromSets("");
                //第一个集合中出现的，但是不在第二个集合中出现的
                setService.GetDifferencesFromSet("","");
                setService.GetUnionFromSets("");
                
            }

        }


        /// <summary>
        /// 一个key
        /// 对应一组value
        /// 
        /// 每个value带一个排序的分数
        /// 
        /// 使用场景：实时排行榜
        /// 刷礼物
        /// 维度很多，平台/房间/主播/日/周/月/年
        /// A对B刷个礼物，影响很多
        /// 
        /// 刷礼物只影响流水，不影响排行，凌晨跑任务更新
        /// </summary>
        public static void Test04()
        {
            using (RedisZSetService zSetService = new RedisZSetService())
            {
                zSetService.Add("hellozset", "world");
                zSetService.Add("hellozset", "hello");
                zSetService.Add("hellozset", "99");
                zSetService.Add("hellozset", "59");
                zSetService.Add("hellozset", "101");

                //正序
                List<string> res1 = zSetService.GetAll("hellozset");
                //倒序
                List<string> res2 = zSetService.GetAllDesc("hellozset");

                //设置数据和分数
                zSetService.AddItemToSortedSet("hellozset", "test", 1);

                zSetService.AddRangeToSortedSet("hellozset", new List<string>() { "1", "2", "3" }, 2);
            }
        }

        /// <summary>
        /// list的基本操作
        /// 
        /// 
        /// </summary>
        public static void Test05()
        {
            using (RedisListService listService = new RedisListService())
            {
                listService.Add("hellolist", "hello");
                listService.Add("hellolist", "world");
                listService.Add("hellolist", "jack");
                listService.Add("hellolist", "tom");

                List<string> list = listService.Get("hellolist");

                list.ForEach(s =>
                {
                    Console.WriteLine(s);
                });

                listService.LPush("hellolist", "1");
                listService.RPush("hellolist", "2");

                //从list获取方法，阻塞式的
                listService.BlockingPopItemFromList("hellolist", TimeSpan.FromHours(3));

                Task.Run(() =>
                {
                    //
                    new RedisListService().Subscribe("hellops", (c, m, sub) =>
                    {
                        Console.WriteLine($"注册{c}:{m}");
                    });
                });

                Thread.Sleep(1000);

                listService.Publish("hellops", "1234");
            }
        }
    }
}
