﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ioc.domain
{
    public abstract class IGame
    {
        public void Play()
        {
            Console.WriteLine($"{this} 玩起来");
        }
    }
}
