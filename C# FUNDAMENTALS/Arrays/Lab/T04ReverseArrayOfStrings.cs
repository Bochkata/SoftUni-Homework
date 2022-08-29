using System;
using System.Linq;

namespace T04ReverseArrayOfStringsver2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] inputArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Reverse().ToArray();
            //Console.WriteLine(String.Join(" ", inputArray));

            string[] inputArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < inputArray.Length/2; i++)
            {
                var tempArray = inputArray[i];
                inputArray[i] = inputArray[inputArray.Length - 1 - i];
                inputArray[inputArray.Length - 1 - i] = tempArray;
            }

            Console.WriteLine(string.Join(" ", inputArray));

        }
    }
}
