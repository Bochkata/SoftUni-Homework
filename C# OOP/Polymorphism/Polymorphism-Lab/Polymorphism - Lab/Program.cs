using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal = new GermanShepherd();
            mammal.Move();

            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine(new MathOperations().Add(1.2M, 2.3M, 3.4M));

            IAnimal animal = new Person("Niki", 31);

            Console.WriteLine(animal.GetType());

            (animal as GermanShepherd)?.MoveTail();

            if (animal is GermanShepherd)
            {
                ((GermanShepherd)animal).MoveTail();
            }


            int a = 42;
            if (a is 42)// or 102 or 2)
            {
                // ...
            }

            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(new Cat());
            animals.Add(new Dog());

            foreach (var animal2 in animals)
            {
                animal2.Move();
            }

            MoveAnimal(new Cat());
            MoveAnimal(new Dog());
            MoveAnimal(new Person());
        } //  SOLID Open-closed / Liskov Substitution

        public static void MoveAnimal(Mammal animal)
        {
            animal.Move();
            Console.WriteLine($"{animal.Name} moved to his favourite {animal.FavouriteFood}");
        }
    }
}
