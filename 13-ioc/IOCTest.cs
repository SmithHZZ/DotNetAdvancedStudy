using _13_ioc.container;
using _13_ioc.domain;
using _13_ioc.domain.impl;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;
using Unity;
using Unity.Interception;
using Unity.Interception.ContainerIntegration;
using Unity.Interception.Interceptors.InstanceInterceptors.InterfaceInterception;
using Unity.Lifetime;

namespace _13_ioc
{
    /// <summary>
    /// 
    /// IOC  控制反转
    /// 
    /// 是面向对象编程中的一种设计原则，可以用来减低计算机代码之间的耦合度。
    /// 其中最常见的方式叫做依赖注入（Dependency Injection，简称DI），
    /// 还有一种方式叫“依赖查找”（Dependency Lookup）。
    /// 通过控制反转，对象在被创建的时候，由一个调控系统内所有对象的外界实体，将其所依赖的对象的引用传递(注入)给它。
    /// 
    /// 传统开发，上端依赖下端对象，会有以来
    ///     把对下端对象的依赖转移到第三方容器
    ///     能够让程序有更好的扩展性
    /// 
    /// 
    /// DI  依赖注入能够做到构造对象时，将依赖的对象自动初始化并注入
    ///     IOC是效果，需要DI依赖注入的手段
    ///     
    /// 
    /// 
    /// 初步实现：配置文件+工厂+反射创建对象
    /// 
    /// 使用框架：Unity 5.11.7
    /// 
    /// nuget 添加 Unity
    /// 
    /// 容器三部曲：
    ///     1、实例化容器
    ///     2、注册类型
    ///     3、获取实例
    ///     
    /// 项目版本和服务层的版本一致
    /// 
    /// </summary>
    public class IOCTest
    {

        /// <summary>
        /// 容器的最初级使用
        /// </summary>
        public static void Test01()
        {
            //实例化容器
            IUnityContainer container = new UnityContainer();

            //注册类型

            //前面抽象类，后面子类
            container.RegisterType<IPhone,Android>();

            //获取实例
            IPhone iphone = container.Resolve<IPhone>();

            iphone.Show();

        }

        /// <summary>
        /// 构造方法注入
        ///     容器优先调用参数较多的
        /// 
        /// 属性注入
        /// 
        /// 方法注入
        /// </summary>
        public static void Test02()
        {
            //实例化容器
            IUnityContainer container = new UnityContainer();

            //注册类型

            //前面抽象类，后面子类
            container.RegisterType<IPhone, Android>();
            container.RegisterType<IPower, Power>();
            container.RegisterType<IGame, Game>();
            container.RegisterType<IPhone, Apple12>();

            //获取实例
            IPhone huawei = container.Resolve<Android>();

            Apple12 apple12 = container.Resolve<Apple12>();

            huawei.Show();

            //Apple12对象的创建依赖IPower，容器给我们自动创建IPower的实例并自动注入，最终创建Apple12对象
            apple12.Show();

            //属性注入 检测到需要的对象时，自动帮我们注入
            apple12.Game.Play();

            //未加上[Dependency] 特性的字段不自动注入
            if (apple12.Game1 != null)
            {
                apple12.Game1.Play();
            }
            else
            {
                System.Console.WriteLine("Game1为空");
            }
            
            //方法注入穿进去的Game对象调用的Play()方法
            apple12.Play();

        }


        /// <summary>
        /// 自定义容器  尝鲜
        /// </summary>
        public static void Test03()
        {
            ICustomContainer container = new CustomContainer();

            container.RegisterType<IPhone, Android>();
            container.RegisterType<IPower, Power>();

            IPhone phone = container.Resolve<IPhone>();

            phone.Show();
        }

        /// <summary>
        /// 
        /// 容器对对象声明周期的管理
        /// 
        /// 
        /// 
        /// 
        /// </summary>
        public static void Test04()
        {
            //实例化容器
            IUnityContainer container = new UnityContainer();
            //注册类型
            //前面抽象类，后面子类
            //默认的是瞬时对象
            //container.RegisterType<IPhone, Android>(new TransientLifetimeManager());
            ////获取实例
            //IPhone huawei = container.Resolve<Android>();
            ////瞬时对象，每次都是构造一个新的
            //for (int i = 0; i < 10; i++)
            //{
            //    huawei = container.Resolve<Android>();
            //    System.Console.WriteLine(huawei);
            //}
            //huawei.Show();

            //全局单例模式
            //container.RegisterType<IPhone, Android>(new SingletonLifetimeManager());
            //IPhone huawei = container.Resolve<IPhone>();
            //for (int i = 0; i < 10; i++)
            //{
            //    huawei = container.Resolve<IPhone>();
            //    System.Console.WriteLine(huawei);
            //}
            //huawei.Show();

            //线程单例
            //多线程处理事务，希望每个线程中公用一个context，不同线程中使用不同context
                 
            container.RegisterType<IPhone, Android>(new PerThreadLifetimeManager());
            IPhone huawei = container.Resolve<IPhone>();
            for (int i = 0; i < 2; i++)
            {
                huawei = container.Resolve<IPhone>();
                System.Console.WriteLine(huawei);
            }
            Task.Run(() =>
            {
                IPhone huawei1 = container.Resolve<IPhone>();
                IPhone huawei2 = container.Resolve<IPhone>();

                System.Console.WriteLine($"huawei1 == huawei2 = {huawei1 == huawei2}");

                System.Console.WriteLine($"huawei == huawei1 = {huawei == huawei1}");

                System.Console.WriteLine($"huawei == huawei2 = {huawei == huawei2}");
            });
            huawei.Show();


            //还有很多单例模式：分级容器单例,同一个子容器里面创建的实例是单例的
            container.RegisterType<IPhone, Android>(new HierarchicalLifetimeManager());
            var childContainer = container.CreateChildContainer();

            //外部可释放单例，只要不释放一直用这个，一旦释放，就会创建新的
            container.RegisterType<IPhone, Android>(new ExternallyControlledLifetimeManager());

            //支持循环引用,不提倡使用
            container.RegisterType<IPhone, Android>(new PerResolveLifetimeManager());
        }

        /// <summary>
        /// 使用配置文件进行解耦
        /// </summary>
        public static void Test05()
        {
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();

            //找配置文件的路径
            fileMap.ExeConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CfgFiles\\Unity.Config");

            Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

            UnityConfigurationSection section = (UnityConfigurationSection) configuration.GetSection(UnityConfigurationSection.SectionName);

            IUnityContainer container = new UnityContainer();

            section.Configure(container, "testContainer1");

            container.AddNewExtension<Interception>().Configure<Interception>().SetInterceptorFor<IPhone>(new InterfaceInterceptor());

            IPhone apple = container.Resolve<IPhone>();

            apple.Show();

            IPhone android = container.Resolve<IPhone>("Android");

            android.Show();
        }

        /// <summary>
        /// AOP
        /// 
        /// 先按照配置文件里配置的拦截器顺序执行
        /// 
        /// 再按照每个拦截器里的代码逻辑执行
        /// </summary>
        public static void Test06()
        {
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();

            //找配置文件的路径
            fileMap.ExeConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CfgFiles\\Unity.Config");

            Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

            UnityConfigurationSection section = (UnityConfigurationSection)configuration.GetSection(UnityConfigurationSection.SectionName);

            IUnityContainer container = new UnityContainer();

            section.Configure(container, "testContainer");

            IPhone apple = container.Resolve<IPhone>();

            apple.Show();
        }
    }
}
