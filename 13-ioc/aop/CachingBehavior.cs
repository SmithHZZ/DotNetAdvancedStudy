using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;

namespace _13_ioc.aop
{
    public class CachingBehavior : IInterceptionBehavior
    {
        public bool WillExecute { get; set; } = true;

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Type.EmptyTypes;
        }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            Console.WriteLine("CachingBehavior");
            Console.WriteLine(input.MethodBase.Name);
            Console.WriteLine("正在查询缓存");
            if(false)
            {
                Console.WriteLine("有缓存了，不用查数据库了");
                WillExecute = false;
                return input.CreateMethodReturn("....");
            }
            else
            {
                Console.WriteLine("没有缓存，继续查数据库");
            }

            return getNext().Invoke(input, getNext);
        }
    }
}
