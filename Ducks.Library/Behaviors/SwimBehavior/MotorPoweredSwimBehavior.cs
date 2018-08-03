using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks.Library.Interfaces.Behaviors;

namespace Ducks.Library.Behaviors.SwimBehavior
{
    class MotorPoweredSwimBehavior : ISwimBehavior
    {
        public void DoSwim()
        {
            Console.WriteLine("Vroom Vroom!");
        }
    }
}
