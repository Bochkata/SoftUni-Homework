using System;
using System.Collections.Generic;


namespace T02EnterNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            ReadNumber(start, end);
        }

        public static void ReadNumber(int start, int end)
        {
            int readValue = 0;
            List<int> list = new List<int>();
            string input = Console.ReadLine();
            while (list.Count < 10)
            {
                try
                {
                    if (int.TryParse(input, out readValue) == false)
                    {
                        throw new FormatException();

                    }

                    if (readValue >= end || readValue <= start)
                    {

                        throw new ArgumentOutOfRangeException();
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"Your number is not in range {start} - 100!");
                }
                if (readValue > start & readValue < end)
                {
                    list.Add(readValue);
                    start = readValue;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", list));

        }

    }

}

