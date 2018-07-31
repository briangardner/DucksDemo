﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks.Library.Interfaces;

namespace Ducks.Library.Behaviors.Flying
{
    public class NoFlyBehavior : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly. :(");
        }
    }
}
