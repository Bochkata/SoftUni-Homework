using System;
using System.Linq;

namespace T04ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int numberOfRotations = int.Parse(Console.ReadLine());



            for (int i = 0; i < numberOfRotations; i++)
            {
                int temp = initialArray[0];

                for (int j = 0; j < initialArray.Length - 1; j++)
                {
                    initialArray[j] = initialArray[j + 1];

                }

                initialArray[initialArray.Length - 1] = temp;

            }

            Console.WriteLine(String.Join(" ", initialArray));
        }

    }
}
