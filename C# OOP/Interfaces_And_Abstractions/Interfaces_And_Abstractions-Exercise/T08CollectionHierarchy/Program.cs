using System;
using T08CollectionHierarchy.Models;

namespace T08CollectionHierarchy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int numberOfElementsToRemove = int.Parse(Console.ReadLine());
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            foreach (string item in input)
            {
                Console.Write(addCollection.Add(item) + " ");
            }

            Console.WriteLine();
            foreach (string item in input)
            {
                Console.Write(addRemoveCollection.Add(item) + " ");
            }

            Console.WriteLine();
            foreach (string item in input)
            {
                Console.Write(myList.Add(item) + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < numberOfElementsToRemove; i++)
            {
                Console.Write(addRemoveCollection.Remove() + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < numberOfElementsToRemove; i++)
            {
                Console.Write(myList.Remove() + " ");
            }
            

        }
    }
}
