using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_designpattern._03_Factory
{
    /// <summary>
    /// 
    /// 三大工厂：
    /// 
    ///     1、简单工厂:不直接new，把对象的创建交给工厂来操作（不属于23种设计模式），对要创建对象的类型进行抽象
    ///     2、工厂方法：把简单工厂中的工厂使用接口拆分成多个工厂，保证每个工厂的相对稳定，不仅对要创建对象的类型进行抽象，还对工厂进行抽象，使用简单工厂来创建工厂，再用工厂来创建对象
    ///     3、抽象工厂：创建对象，创建一组密不可分的对象；约束强制保障产品簇的完整
    ///         
    ///     4、建造者模式：复杂的工厂方法
    /// 
    /// </summary>
    public class SimpleFactory
    {

        public static IPople CreatePople(PopleType type)
        {
            switch(type)
            {
                case PopleType.Student:
                    return new Student();
                case PopleType.Worker:
                    return new Worker();
                case PopleType.Officer:
                    return new Officer();
            }
            return null;
        }

    }

    public interface IPople
    {

    }

    public class Student :  IPople
    {

    }

    public class Worker : IPople
    {

    }

    public class Officer : IPople
    {

    }

    public enum PopleType
    {
        Student,
        Worker,
        Officer
    }
}
