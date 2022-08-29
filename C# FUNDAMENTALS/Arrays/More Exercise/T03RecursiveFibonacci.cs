using System;
using System.ComponentModel.Design;

namespace T03RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] array = new int[number];
            array[0] = 1;
            if (number == 1)
            {
                Console.WriteLine(String.Join(" ", array));
                return;
            }

            array[1] = 1;
            if (number == 2)
            {
                Console.WriteLine(String.Join(" ", array));
                return;
            }

            for (int i = 2; i < number; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }

            Console.WriteLine(array[number-1]);
        }
    }
}
