using Ducks.Library.Interfaces.Behaviors;

namespace Ducks.Library.Interfaces.Abilities
{
    public interface ICanSwim
    {
        void Swim();
        void SetSwimBehavior(ISwimBehavior behavior);
    }
}
