using _10_designpattern._01_Singleton;
using _10_designpattern._07_TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_designpattern
{
    /// <summary>
    /// 
    /// 
    /// 创建型设计模式：关注对象的创建
    /// 
    /// 
    /// 结构型设计模式：关注类与类之间的关系
    /// 
    ///     纵向关系：继承约等于实现，超强关联
    ///     横向关系：组合>聚合>关联>依赖
    ///         依赖出现在方法内部
    ///         另外三个用语义区分
    ///         Person 和 大脑 组合（同生共死）
    ///         Person 和 手脚 聚合（组合成人）
    ///         Person 和 iPhone 关联（可有可无，非必须）
    ///         
    ///     组合优于继承
    ///     
    ///         继承是强侵入的，就是父类的方法会都被继承过来
    ///         而组合可以通过访问修饰符来实现控制
    ///     
    ///         灵活性：继承只为一个类服务
    ///             属性注入：一次性写死
    ///             构造函数注入：在抽象的前提下可以替换
    ///             方法注入：不一定有
    ///     
    /// 
    ///     装饰器模式
    ///     
    ///     
    ///     外观模式/门面模式
    ///     
    ///     组合模式
    ///     
    ///     桥接模式
    ///     
    ///     享元模式
    ///     
    ///     最典型的就是包一层
    /// 
    /// 
    /// 行为型设计模式：关注对象和行为的分离
    ///     11种
    ///     
    ///     1、模板方法设计模式
    ///     
    ///     2、观察者模式
    ///     
    ///     3、责任链模式：行为型设计模式的巅峰之作
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //SingletonTest.Test01();
            //SingletonTest.Test03();
            //SingletonTest.Test04();

            TemplateMethodTest.Test01();



            Console.ReadKey();
               
        }
    }
}
