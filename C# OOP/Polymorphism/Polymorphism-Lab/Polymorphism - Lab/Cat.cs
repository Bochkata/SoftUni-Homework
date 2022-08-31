using System;

namespace PolymorphismDemo
{
    public class Cat : Mammal
    {
        public override string Name => "Котка";

        public override string FavouriteFood => "Mice";

        public override void MakeSound()
        {
            Console.WriteLine("Meow...");
        }

        public override void Move()
        {
            Console.WriteLine("Sneaking...");
        }
    }
}
