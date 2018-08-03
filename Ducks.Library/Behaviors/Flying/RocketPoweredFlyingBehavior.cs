using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks.Library.Interfaces.Behaviors;

namespace Ducks.Library.Behaviors.Flying
{
    class RocketPoweredFlyingBehavior : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("3 2 1 Liftoff!!");
        }
    }
}
