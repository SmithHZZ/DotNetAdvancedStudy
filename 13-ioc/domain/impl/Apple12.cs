using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace _13_ioc.domain.impl
{
    public class Apple12 : IPhone
    {
        //属性注入，加上这个特性才行
        [Dependency]
        public IGame Game { set; get; }

        public IGame Game1 { set; get; }

        private IGame game;

        //容器优先构造参数较多的构造函数
        public Apple12()
        {
            Console.WriteLine($" {this} 被构造");
        }

        //构造函数注入
        [InjectionConstructor]
        public Apple12(IPower power)
        {
            Console.WriteLine("带IPower参数类型的对象被构造");
            power.Show();
        }

        //方法注入，不加特性不好使
        //[InjectionMethod]
        public void InitGame(IGame game)
        {
            this.game = game;
        }

        public void Play()
        {
            Console.WriteLine("我是方法注入的game");
            game.Play();
        }

        public void Show()
        {
            Console.WriteLine($"type : {this}  now is {DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}");
        }

    }
}
