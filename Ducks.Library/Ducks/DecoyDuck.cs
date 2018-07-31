using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks.Library.Abstract;
using Ducks.Library.Behaviors.SwimBehavior;
using Ducks.Library.Interfaces;
using Ducks.Library.Interfaces.Abilities;
using Ducks.Library.Interfaces.Behaviors;

namespace Ducks.Library.Ducks
{
    public class DecoyDuck : Duck, ICanSwim
    {
        private ISwimBehavior _swimBehavior;
        public DecoyDuck(IFlyBehavior flyBehavior, ISoundBehavior soundBehavior) : base(flyBehavior, soundBehavior)
        {
            _swimBehavior = new FloatSwimBehavior();
        }

        //TODO: Yeah, I can't swim either.  Only float.
        //TODO: I don't quack either.  In fact, I'm completely silent......
        public override void Display()
        {
            Console.WriteLine("I look like a normal duck, but I'm made of wood.");
        }

        public void Swim()
        {
            _swimBehavior.DoSwim();
        }

        public void SetSwimBehavior(ISwimBehavior behavior)
        {
            _swimBehavior = behavior;
        }
    }
}
