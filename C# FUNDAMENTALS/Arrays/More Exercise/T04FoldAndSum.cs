using System;
using System.Linq;

namespace T04FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            int[] firstArray = new int[numbers.Length / 2];
            

            for (int i = 0; i < numbers.Length/4; i++)
            {

                firstArray[i] = numbers[numbers.Length/4 - 1 - i];
                firstArray[firstArray.Length/2+i] = numbers[numbers.Length - 1 - i];
                
            }

            int[] secondArray = new int[numbers.Length / 2];
            int[] finalArray = new int[numbers.Length / 2];

            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = numbers[numbers.Length / 4 + i];
                finalArray[i] = firstArray[i] + secondArray[i];
            }

           
            Console.WriteLine(String.Join(" ", finalArray));
        }
    }
}
