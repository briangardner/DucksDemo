using System;
using Ducks.Library.Interfaces;
using Ducks.Library.Interfaces.Behaviors;

namespace Ducks.Library.Behaviors.SwimBehavior
{
    public class FloatSwimBehavior : ISwimBehavior
    {
        public void DoSwim()
        {
            Console.WriteLine("I'm Floating!");
        }
    }
}