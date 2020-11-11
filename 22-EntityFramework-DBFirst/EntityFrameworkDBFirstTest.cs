using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_EntityFramework_DBFirst
{
    /// <summary>
    /// 
    /// EF DbFirst 模式
    /// 
    /// 
    /// 
    /// </summary>
    public class EntityFrameworkDBFirstTest
    {

        /// <summary>
        /// DbFirst使用
        /// </summary>
        public static void Test01()
        {
            using (UserCenter userCenter = new UserCenter())
            {
                //查看日志，包括sql语句
                userCenter.Database.Log += s =>
                {
                    Console.WriteLine(s);
                };

                Console.WriteLine($"userCenter.Base_User.Count() = { userCenter.Base_User.Count()}");

                {
                    //根据主键找
                    Base_User user = userCenter.Base_User.Find("121");

                    Console.WriteLine(user.Code);
                    Console.WriteLine(user.User_Name);
                }

                {
                    //根据条件找
                    List<Base_User> users = userCenter.Base_User.Where(u => u.User_Name.Contains("admin")).ToList();

                    foreach (var user in users)
                    {
                        Console.WriteLine(user.Code);
                        Console.WriteLine(user.User_Name);
                    }

                    
                }
                
            }
        }
    }
}
