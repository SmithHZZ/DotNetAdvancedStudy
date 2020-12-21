using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_EntityFramework_CodeFirst
{
    /// <summary>
    /// 
    /// 来自数据库的CodeFirst模式
    /// 
    /// 
    /// 
    /// 
    /// </summary>
    public class EntityFrameworkCodeFirstTest
    {
        /// <summary>
        /// 来自数据库的CodeFirst模式
        /// 
        /// 使用
        /// 
        /// 类到数据库表的映射几种方式
        ///     1、特性映射
        ///     [Table("table_name")]
        ///     2、在DbContext类中的OnModelCreating方法里进行配置
        ///     modelBuilder.Entity<Base_Comment>().ToTable("Base_Comment");
        ///     modelBuilder.Entity<Base_Comment>().Property(e => e.Description).HasColumnName("Description");
        ///     3、实现自定义的EntityTypeConfiguration，在类中实现映射配置
        /// 
        /// 
        /// </summary>
        public static void Test01()
        {
            using (UserCenter userCenter = new UserCenter())
            {

            }
        }

        /// <summary>
        /// 花式查询
        /// </summary>
        public static void Test02()
        {
            
            using (UserCenter userCenter = new UserCenter())
            {
                userCenter.Database.Log += c=> Console.WriteLine($"sql:{c}");
                //Where查询
                {
                    var list = userCenter.Base_Area.Where(a => new int[] { 110100, 110101, 110102, 110103, 110104, 110105 }.Contains(a.Id));

                    list = list.OrderByDescending(a => a.Id);
                    list.ToList().ForEach(a =>
                    {
                        Console.WriteLine($"Id:{a.Id},FullName:{a.Full_Name}");
                    });
                }
                //Linq查询
                {
                    var list = from a in userCenter.Base_Area
                               where new int[] { 110100, 110101, 110102, 110103, 110104, 110105 }.Contains(a.Id)
                               select a;
                    list.ToList().ForEach(a =>
                    {
                        Console.WriteLine($"Id:{a.Id},FullName:{a.Full_Name}");
                    });
                }
                //分页+投影
                {
                    var list = userCenter.Base_Area.Where(a => new int[] { 110100, 110101, 110102, 110103, 110104, 110105 }.Contains(a.Id)).OrderBy(a => a.Id).Select(a => new { Id = a.Id }).Skip(1).Take(5);

                    list.ToList().ForEach(a =>
                    {
                        Console.WriteLine(a.Id);
                    });
                }
                //模糊查询
                {
                    var list = userCenter.Base_Area.Where(a => a.Full_Name.EndsWith("省") && a.Full_Name.StartsWith("江"))
                        .Where(a => a.Full_Name.Length == 3).OrderBy(a => a.Id);
                    list.ToList().ForEach(a =>
                    {
                        Console.WriteLine($"Id:{a.Id},FullName:{a.Full_Name}");
                    });
                }
                //多表查询 inner join
                {
                    var list = from a in userCenter.Base_Area
                               join b in userCenter.Base_Area on a.Id equals b.Parent_Id
                               where new int[] { 110100, 110101, 110102, 110103, 110104, 110105 }.Contains(b.Id)
                               select new
                               {
                                   Name = b.Full_Name,
                                   PName = a.Full_Name
                               };
                    list.ToList().ForEach(a =>
                    {
                        Console.WriteLine($"Name:{a.Name},PName:{a.PName}");
                    });
                }
                //直接使用原生操作
                {
                    DbContextTransaction transaction = userCenter.Database.BeginTransaction();

                    string sql = "select * from base_area";

                    //userCenter.Database.ExecuteSqlCommand(sql);

                    DbRawSqlQuery<Base_Area> query = userCenter.Database.SqlQuery<Base_Area>(sql);

                    query.ToList().ForEach(temp =>
                    {
                        Console.WriteLine($"ForEachAsync  Id:{temp.Id},FullName:{temp.Full_Name}");
                    });
                }
                
            }
        }

        /// <summary>
        /// 增删改
        /// </summary>
        public static void Test03()
        {
            using (UserCenter userCenter = new UserCenter())
            {
                userCenter.Database.Log += c => Console.WriteLine($"sql:{c}");

                //先查后改
                {
                    Base_Area area = userCenter.Base_Area.Find(86);

                    Console.WriteLine($"Id:{area.Id},FullName:{area.Full_Name}");

                    area.Description = "中华人民共和国";

                    //Modified
                    Console.WriteLine(userCenter.Entry<Base_Area>(area).State);

                    userCenter.SaveChanges();

                    //Unchanged
                    Console.WriteLine(userCenter.Entry<Base_Area>(area).State);
                    //这里的实现机制依赖EntityState 标记对象的状态

                    //表示当前对象和上下文对象没关系 EntityState.Detached

                    //userCenter.Base_Area.Add(new Base_Area());
                    //表示当前对象是新添加的 EntityState.Added

                    //userCenter.Base_Area.Remove(area);
                    //表示当前对象是即将删除的 EntityState.Deleted
                }
            }
        }

        /// <summary>
        /// context生命周期
        /// 
        /// 
        /// </summary>
        public static void Test04()
        {
            using (UserCenter userCenter = new UserCenter())
            {
                userCenter.Database.Log += c => Console.WriteLine($"sql:{c}");

                {
                    var areaList = userCenter.Base_Area.Where(a => a.Id < 100000).ToList();

                    //指明让context不追踪查询出来的数据对象
                    //var areaList = userCenter.Base_Area.Where(a => a.Id < 100000).AsNoTracking().ToList();

                    //find可以使用缓存，优先从内存查找
                    //linq 不能用缓存，每次都去数据库查找

                    var t = userCenter.Base_Area.Find(86);

                    var t2 = userCenter.Base_Area.FirstOrDefault(a => a.Id == 110100);

                    var t3 = userCenter.Base_Area.Find(110100);

                    var t4 = userCenter.Base_Area.FirstOrDefault(a => a.Id == 110100);
                }
                //按需更新
                {

                    //var a = userCenter.Base_Area.Find(86);

                    //a.Description = DateTime.Now.ToString("yyyy-MM-dd");

                    //userCenter.SaveChanges();

                    var t = userCenter.Base_Area.Find(86);
                    t.Description = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
                    userCenter.Entry<Base_Area>(t).Property("Description").IsModified = true;

                    userCenter.SaveChanges();
                }
            }
        }

        /// <summary>
        /// 多个数据操作
        /// 一次SaveChanges，开始事务保存
        /// 
        /// 任何一个失败，事务回滚
        /// 
        /// 整个进程只有一个context实例？不可以
        /// 
        /// 多线能不能是一个实例？ 一般不行，除非自己明确是想要的效果
        /// 
        /// 每个数据操作都去实例化一个context实例？也不好
        /// 1、内存消耗大，没法缓存
        /// 2、多context join不行，因为上下文环境不一样，除非把数据都查到内存，再去linq
        /// 3、多context的事务也不好控制
        /// 
        /// context使用建议
        /// 
        /// 
        /// 延迟查询
        /// 
        /// </summary>
        public static void Test05()
        {
            using (UserCenter userCenter = new UserCenter())
            {

                userCenter.Database.Log += m => Console.WriteLine($"sql:{m}");

                //延迟查询
                {
                    //这时候没去数据库查询
                    var temp = from a in userCenter.Base_Area
                               where a.Id > 109000
                               select a;

                    temp = temp.Where(a => a.Full_Name.Contains("省"));

                    //可以添加多个条件，叠加多次查询，一次提交

                    //这时候才去查询
                    foreach (Base_Area a in temp)
                    {
                        Console.WriteLine($"Id:{a.Id},Name:{a.Full_Name}");
                    }
                    //用完之后才关闭连接
                }

            }


        }
    }
}
