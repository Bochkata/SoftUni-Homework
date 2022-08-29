using System;
using System.Collections.Generic;
using System.Linq;


namespace T01SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List <double>  numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < numbers.Count-1; i++)
            {
                if (numbers.Count == 1)
                {
                    break;
                }

                if (numbers[i] == numbers[i+1])
                    {
                        numbers[i] += numbers[i+1];
                        numbers.Remove(numbers[i+1]);
                        i = -1;
                    }
                
            }


            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
