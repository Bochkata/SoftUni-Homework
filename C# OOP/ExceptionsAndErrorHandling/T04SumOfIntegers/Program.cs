using System;


namespace T04SumOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            long currentSum = 0;

            for (int i = 0; i < input.Length; i++)
            {

                try
                {

                    if (long.Parse(input[i]) > int.MaxValue || long.Parse(input[i]) < int.MinValue)
                    {
                        throw new OverflowException();
                    }

                    if (int.TryParse(input[i], out int element) == false)
                    {
                        throw new FormatException();
                    }

                    currentSum += int.Parse(input[i]);

                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{input[i]}' is in wrong format!");

                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{input[i]}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{input[i]}' processed - current sum: {currentSum}");
                }

            }
            Console.WriteLine($"The total sum of all integers is: {currentSum}");
        }

    }
}

