using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_reflect
{
    class SqlDemo
    {
        public static string Select<T>(int id)
        {
            Type type = typeof(T);

            string sql = $"select {string.Join(",", type.GetProperties().Select(p=>$"[{p.Name}]"))}  from {type.Name} where id = {id}";

            return sql;
        }

        public static string Delete<T>(int id)
        {
            Type type = typeof(T);

            string sql = $"delete from {type.Name} where id = {id}";

            return sql;
        }

        public static string Insert<T>(T t)
        {
            Type type = typeof(T);

            string sql = $"insert into {type.Name} ( {string.Join(",", type.GetProperties().Select(p => $"[{p.Name}]"))} ) values({string.Join(",", type.GetProperties().Select(p => $"{p.GetValue(t)}"))})";

            return sql;
        }
    }
}
