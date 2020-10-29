using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;

namespace _13_ioc.aop
{
    public class AuthorizeBehavior : IInterceptionBehavior
    {
        public bool WillExecute
        {
            get { return true; }
        }

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Type.EmptyTypes;
        }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            Console.WriteLine("检查当前用户的权限");
            if (true)
            {
                Console.WriteLine("经检查当前用户拥有权限操作");
                return getNext().Invoke(input, getNext);//执行后面的全部动作
            }
            else
            {
                return input.CreateExceptionMethodReturn(new Exception("没有权限"));
            }
        }
    }
}
