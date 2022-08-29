using System;
using System.Globalization;
using System.Linq;

namespace T05LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            int[] len = new int[array.Length];
            int[] previous = new int[array.Length];

            int maxlength = 0;
            int lastIndexOfSequence = -1;


            for (int i = 0; i < array.Length; i++)
            {
                previous[i] = -1;
                len[i] = 1;
                for (int j = 0; j < i; j++)
                {

                    if (array[i] > array[j] && len[j] >= len[i])
                    {
                        previous[i] = j;
                        len[i] = len[j] + 1;

                    }

                }

                if (len[i] > maxlength)
                {
                    maxlength = len[i];
                    lastIndexOfSequence = i;
                }
                
            }

            int[] LIS = new int[maxlength];

            for (int i = 0; i < maxlength; i++)
            {
                LIS[i] = array[lastIndexOfSequence];
                lastIndexOfSequence = previous[lastIndexOfSequence];

            }

            
            int[] LISlast = new int[maxlength];

            for (int i = 0; i < maxlength; i++)
            {
                LISlast[i] = LIS[LIS.Length - 1 - i];
            }

            Console.WriteLine(String.Join(" ", LISlast));
        }
    }
}
