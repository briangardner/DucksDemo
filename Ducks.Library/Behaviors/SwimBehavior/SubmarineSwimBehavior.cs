using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks.Library.Interfaces;
using Ducks.Library.Interfaces.Behaviors;

namespace Ducks.Library.Behaviors.SwimBehavior
{
    public class SubmarineSwimBehavior : ISwimBehavior
    {
        public void DoSwim()
        {
            Console.WriteLine("Dive Dive Dive!");
        }
    }
}
