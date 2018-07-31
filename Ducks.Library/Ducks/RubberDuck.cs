using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks.Library.Abstract;
using Ducks.Library.Interfaces;
using Ducks.Library.Interfaces.Abilities;
using Ducks.Library.Interfaces.Behaviors;

namespace Ducks.Library.Ducks
{
    public class RubberDuck : Duck, IDebugCode
    {
        public RubberDuck(IFlyBehavior flyBehavior, ISoundBehavior soundBehavior) : base(flyBehavior, soundBehavior)
        {
        }
        // TODO: I don't quack, I squeak.
        // TODO: I can't fly, unless I get thrown or something.
        // TODO: I guess I can swim... if by swimming you mean floating and not going anywhere under my own power.
        public override void Display()
        {
            Console.WriteLine("I'm small, yellow, and made of rubber.");
        }


        public void Debug()
        {
            Console.WriteLine("I'm listening to you describe your code.  All is well.");
        }
    }
}
