using System;

namespace T02_PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNumbers = int.Parse(Console.ReadLine());

            int[] intArray = new int[nNumbers];

            for (int i = 0; i < nNumbers; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = intArray.Length - 1; i >= 0; i--)
            {
                Console.Write($"{intArray[i]} ");
            }




        }
    }
}
