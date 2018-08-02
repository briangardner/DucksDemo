using System;
using Ducks.Library.Interfaces.Behaviors;

namespace Ducks.Library.Behaviors.SwimBehavior
{
    public class SinkSwimBehavior : ISwimBehavior
    {
        public void DoSwim()
        {
            Console.WriteLine("I swim as well as a cinder block...");
        }
    }
}