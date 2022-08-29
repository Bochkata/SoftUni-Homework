using System;

namespace T02PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            int[] prevArray = new int[] { 1 };

            Console.WriteLine(String.Join(" ", prevArray));
            if (number == 1)
            {
                return;
            }

            prevArray = new int[] { 1, 1 };
            Console.WriteLine(String.Join(" ", prevArray));
            if (number == 2)
            {
                return;
            }


            for (int i = 1; i < number - 1; i++)
            {
                int[] arrayNew = new int[prevArray.Length + 1];
                arrayNew[0] = 1;
                arrayNew[arrayNew.Length - 1] = 1;
                for (int j = 1; j < i + 1; j++)
                {
                    arrayNew[j] = prevArray[j] + prevArray[j - 1];
                }
                prevArray = arrayNew;
                Console.WriteLine(string.Join(" ", prevArray));
            }


        }
    }
}
