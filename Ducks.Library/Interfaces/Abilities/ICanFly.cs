using Ducks.Library.Interfaces.Behaviors;

namespace Ducks.Library.Interfaces.Abilities
{
    public interface ICanFly
    {
        void PerformFly();
        void SetFlyBehavior(IFlyBehavior flyBehavior);
    }
}