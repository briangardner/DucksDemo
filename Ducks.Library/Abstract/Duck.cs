using System;
using Ducks.Library.Behaviors.SwimBehavior;
using Ducks.Library.Interfaces;
using Ducks.Library.Interfaces.Abilities;
using Ducks.Library.Interfaces.Behaviors;

namespace Ducks.Library.Abstract
{
    public abstract class Duck : ICanFly, ICanSwim
    {
        protected IFlyBehavior FlyBehavior;
        protected ISoundBehavior SoundBehavior;
        protected ISwimBehavior SwimBehavior;

        protected Duck(IFlyBehavior flyBehavior, ISoundBehavior soundBehavior)
        {
            FlyBehavior = flyBehavior;
            SoundBehavior = soundBehavior;
            SwimBehavior = new FloatSwimBehavior(); // Default swim behavior for ducks
            
        }
        public void MakeSound()
        {
            SoundBehavior.MakeSound();
        }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            FlyBehavior = flyBehavior;
        }


        public abstract void Display();
        public void Swim()
        {
            SwimBehavior.DoSwim();
        }

        public void SetSwimBehavior(ISwimBehavior behavior)
        {
            SwimBehavior = behavior;
        }
    }
}
