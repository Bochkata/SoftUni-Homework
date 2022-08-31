using System;

namespace T01SquareRoot
{
    public class Program
    {
        static void Main(string[] args)
        {

            int integerValue = int.Parse(Console.ReadLine());

            try
            {
                if (integerValue < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid number.");
                }

                Console.WriteLine(Math.Sqrt(integerValue));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }

        }
    }
}
