using _22_EntityFramework_CodeFirst_Standard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_EntityFramework_CodeFirst_Standard.Model_Standard
{
    /// <summary>
    /// 标准的CodeFirst 模式
    /// 
    /// 不关心数据库的相关细节
    /// 
    /// 只需要关注细节
    /// 
    /// </summary>
    public class CodeFirstTest
    {
        /// <summary>
        /// 如果没有数据库和表结构，会自动创建
        /// 
        /// 
        /// 先编程，从业务出发，自动生成数据库
        /// </summary>
        public static void Test01()
        {
            using (UserCenter userCenter = new UserCenter())
            {
                List<Base_User> users = userCenter.Base_User.ToList();

                Console.WriteLine($"users.Count = {users.Count}");
            }
        }
    }
}
