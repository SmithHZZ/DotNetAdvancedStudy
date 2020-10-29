using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _13_ioc.container
{
    public interface ICustomContainer
    {
        void RegisterType<TFrom, TTo>() where TTo : TFrom;

        T Resolve<T>();
    }

    /// <summary>
    /// 容器 == 工厂
    /// </summary>
    public class CustomContainer : ICustomContainer
    {
        private Dictionary<string, Type> ContainerDictionary = new Dictionary<string, Type>();

        public void RegisterType<TFrom, TTo>() where TTo : TFrom
        {
            ContainerDictionary.Add(typeof(TFrom).FullName, typeof(TTo));
        }

        public T Resolve<T>()
        {
            Type type = ContainerDictionary[typeof(T).FullName];

            ConstructorInfo constructor = null;

            //检查构造函数
            if( type.GetConstructors().Count(c => c.IsDefined(typeof(CustomInjectionConstructorAttribute), true)) > 0)
            {
                constructor = type.GetConstructors().FirstOrDefault(c => c.IsDefined(typeof(CustomInjectionConstructorAttribute), true));
            }
            else
            {
                constructor = type.GetConstructors().OrderByDescending(c => c.GetParameters().Length).FirstOrDefault();
            }

            List<object> paras = new List<object>();
            foreach (var para in constructor.GetParameters())
            {
                Type t = para.ParameterType;
                Type ty = this.ContainerDictionary[t.FullName];
                paras.Add(Activator.CreateInstance(ty));
            }

            object[] paraArray = paras.ToArray();

            return (T)Activator.CreateInstance(type, paraArray);
        }
    }
}
