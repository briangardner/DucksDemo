using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks.Library.Interfaces;
using Ducks.Library.Interfaces.Abilities;
using Ducks.Library.Interfaces.Behaviors;

namespace Ducks.Library.OtherThings
{
    //Definitely not a duck.  But it can fly.
    public class Airplane : ICanFly
    {
        private IFlyBehavior _flyBehavior;

        public Airplane(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }
        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }
    }
}
