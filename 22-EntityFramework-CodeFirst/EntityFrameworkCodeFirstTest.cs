using System;
using System.Collections.Generic;
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
    }
}
