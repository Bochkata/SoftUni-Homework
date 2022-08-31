using System;

namespace PolymorphismDemo
{
    public class Dog : Mammal
    {
        public override string Name => "Куче";

        public override string FavouriteFood => "Bones";

        public override void MakeSound()
        {
            Console.WriteLine("Bau, bau...");
        }

        public override void Move()
        {
            Console.WriteLine("Running...");
        }

        public void MoveTail()
        {
            Console.WriteLine("Tail move...");
        }
    }
}
