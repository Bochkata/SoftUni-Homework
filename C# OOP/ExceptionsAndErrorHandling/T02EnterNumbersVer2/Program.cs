using System;

namespace T02EnterNumbersVer2
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = ReadNumber(start, end);
                if (array[i] <= start)
                {
                    i--;
                }
                else
                {
                    start = array[i];
                }

            }

            Console.WriteLine(string.Join(", ", array));

        }

        public static int ReadNumber(int start, int end)
        {
            int readValue = 0;
            string input = Console.ReadLine();

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
            if (readValue > start && readValue < end)
            {
                return readValue;
            }
            return start;

        }
    }
}
