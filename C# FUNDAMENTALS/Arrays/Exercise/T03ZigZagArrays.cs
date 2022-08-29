using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace T03ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int[] array1 = new int[numberOfLines];
            int[] array2 = new int[numberOfLines];
            int countOfLines = 0;

            while (numberOfLines > 0)
            {
                int[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                countOfLines++;
                numberOfLines--;
                for (int i = 0; i < 2; i++)
                {
                    if (countOfLines % 2 != 0)
                    {
                        array1[countOfLines - 1] = line[0];
                        array2[countOfLines - 1] = line[1];
                    }
                    else
                    {
                        array1[countOfLines - 1] = line[1];
                        array2[countOfLines - 1] = line[0];
                    }
                }

            }

            Console.WriteLine(String.Join(" ", array1));
            Console.WriteLine(String.Join(" ", array2));


        }
    }
}
