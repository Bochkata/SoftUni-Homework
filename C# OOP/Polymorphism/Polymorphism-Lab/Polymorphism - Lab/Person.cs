using System;

namespace PolymorphismDemo
{
    public class Person : Mammal
    {
        public Person()
        {
        }

        public Person(string name)
        {
        }

        public Person(string name, int age)
        {
        }

        public override string Name => "Човек";

        public override string FavouriteFood => "Spagetti";

        public override void MakeSound()
        {
            Console.WriteLine("Talking...");
        }

        public override void Move()
        {
            Console.WriteLine("Walking...");
        }
    }
}
