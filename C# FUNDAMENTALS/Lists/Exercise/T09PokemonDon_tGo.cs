using System;
using System.Collections.Generic;
using System.Linq;

namespace T09PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersInSequence = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            int sumOfRemovedElements = 0;
            int removedElement = 0;

            while (numbersInSequence.Count > 0)
            {
                int indexToRemove = int.Parse(Console.ReadLine());


                if (indexToRemove < 0)
                {
                    
                    removedElement = numbersInSequence[0];
                    numbersInSequence.RemoveAt(0);
                    numbersInSequence.Insert(0, numbersInSequence[numbersInSequence.Count-1]);
                }
                else if (indexToRemove > numbersInSequence.Count-1)
                {
                    
                    removedElement = numbersInSequence[numbersInSequence.Count - 1];
                    numbersInSequence.RemoveAt(numbersInSequence.Count-1);
                    numbersInSequence.Add(numbersInSequence[0]);
                }
                else
                {
                    removedElement = numbersInSequence[indexToRemove];
                    numbersInSequence.RemoveAt(indexToRemove);
                }

                
                for (int i = 0; i < numbersInSequence.Count; i++)
                {
                    if (numbersInSequence[i] <= removedElement)
                    {
                        numbersInSequence[i] += removedElement;
                    }
                    else if (numbersInSequence[i] > removedElement)
                    {
                        numbersInSequence[i] -= removedElement;
                    }
                }

                sumOfRemovedElements += removedElement;

            }

            Console.WriteLine(sumOfRemovedElements);
        }
    }
}
