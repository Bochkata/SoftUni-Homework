using System;
using System.Linq;

namespace T05SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //string [] values = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            
            //int sumEvenValues = 0;

            //for (int i = 0; i < values.Length; i++)
            //{
            //    var temp = int.Parse(values[i]);
            //    if (temp % 2 == 0)
            //    {
            //        sumEvenValues += temp;
            //    }
            //}

            //Console.WriteLine(sumEvenValues);

            int[] values = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int sumEvenValues = 0;

            for (int i = 0; i < values.Length; i++)
            {
                var temp = values[i];
                if (temp % 2 == 0)
                {
                    sumEvenValues += temp;
                }
            }

            Console.WriteLine(sumEvenValues);
           


        }
    }
}
