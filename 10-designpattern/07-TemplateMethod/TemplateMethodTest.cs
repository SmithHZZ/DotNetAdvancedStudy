using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_designpattern._07_TemplateMethod
{
    /// <summary>
    /// 
    /// 抽象方法没有默认实现
    /// 
    /// 虚方法有默认实现
    /// 
    /// 有一个复杂的多步骤业务，定义一个父类（模板），模板负责完成流程，把步骤分解
    /// 将步骤交给子类去实现
    /// 
    /// 就是把部分行为做了分离
    /// 
    /// 好处就是可以扩展,职责分明
    /// 
    /// 其实就是抽象类+子类
    /// 
    /// 设计模式就是把常用的东西和场景结合起来，沉淀下来起个名字
    /// 
    /// </summary>
    public class TemplateMethodTest
    {
        public static void Test01()
        {
            ChildClass child = new ChildClass();

            child.StepInOnbe();
        }
    }

    class ChildClass : TemplateMethod
    {
        public override void S2()
        {
            Console.WriteLine("2-2");
        }

        public override void S3()
        {
            Console.WriteLine("3"); ;
        }
    }

    abstract class TemplateMethod
    {
        public void StepInOnbe()
        {
            S1();
            S2();
            S3();
        }

        /// <summary>
        /// 有通用的时，将方法定义为虚方法，子类可以根据需要选择是否重写
        /// </summary>
        public virtual void S1()
        {
            Console.WriteLine("1");
        }

        /// <summary>
        /// 有通用的时，将方法定义为虚方法，子类可以根据需要选择是否重写
        /// </summary>
        public virtual void S2()
        {
            Console.WriteLine("2");
        }

        /// <summary>
        /// 没有通用的，或者现在无法确定的，定义为抽象，全部交给子类实现
        /// </summary>
        public abstract void S3();
    }
}
