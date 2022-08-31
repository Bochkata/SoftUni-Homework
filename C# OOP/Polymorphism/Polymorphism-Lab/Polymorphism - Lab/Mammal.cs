using System;

namespace PolymorphismDemo
{
    interface IAnimal2
    {
        int MakeSound();
    }

    public abstract class Mammal : IAnimal, IAnimal2
    {
        public abstract void MakeSound();

        public virtual void Move()
        {
        }

        public abstract string Name { get; }

        public abstract string FavouriteFood { get; }

        int IAnimal2.MakeSound()
        {
            return 0;
        }
    }
}
