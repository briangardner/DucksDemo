using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks.Library.Abstract;
using Ducks.Library.Behaviors.Flying;
using Ducks.Library.Behaviors.Sounds;
using Ducks.Library.Behaviors.SwimBehavior;
using Ducks.Library.Ducks;
using Ducks.Library.Interfaces;
using Ducks.Library.Interfaces.Abilities;
using Ducks.Library.OtherThings;


namespace DucksDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var ducks = new List<Duck>()
            {
                new Mallard(new FlyWithWingsBehavior(), new QuackBehavior()),
                new WoodDuck(new FlyWithWingsBehavior(), new QuackBehavior()),
                // Making changes in the same spot as another user, and I haven't pulled their changes.
                new WoodDuck(new FlyWithWingsBehavior(), new NoSoundBehavior()),
                new WoodDuck(new NoFlyBehavior(), new QuackBehavior()),
                new RubberDuck(new NoFlyBehavior(), new QuackBehavior()),
                // end of changes.
                // This will simulate changes made by another user.
                new Mallard(new NoFlyBehavior(), new NoSoundBehavior()),
                new RubberDuck(new FlyWithWingsBehavior(), new QuackBehavior()), //yes, a quacking, flying rubber duck
                new DecoyDuck(new NoFlyBehavior(), new QuackBehavior()),
                // End of new ducks
                new RubberDuck(new NoFlyBehavior(), new NoSoundBehavior()),
                new DecoyDuck(new NoFlyBehavior(), new NoSoundBehavior())
            };

            foreach (var duck in ducks)
            {
                Console.WriteLine(duck.ToString());
                duck.Display();
                duck.MakeSound();
                duck.PerformFly();
                if (duck is ICanSwim swimmingDuck)
                {
                    swimmingDuck.Swim();
                }
                
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Decoy Duck sample");
            var decoyDuck = new DecoyDuck(new NoFlyBehavior(), new NoSoundBehavior());
            decoyDuck.Swim();
            decoyDuck.SetSwimBehavior(new SubmarineSwimBehavior());
            decoyDuck.Swim();

            ShowFlyableThings();

            Console.ReadKey();
        }

        private static void ShowFlyableThings()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Showing flyable things.");
            var flyableThings = new List<ICanFly>()
            {
                new WoodDuck(new FlyWithWingsBehavior(), new QuackBehavior()),
                new Airplane(new FlyWithWingsBehavior())
            };

            foreach (var flyable in flyableThings)
            {
                Console.WriteLine(flyable.GetType().ToString());
                flyable.PerformFly();
            }
        }
    }
}
