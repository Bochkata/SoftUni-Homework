using System;

namespace T01DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "END")
            {

               
                if (int.TryParse(input, out int result))
                {
                    Console.WriteLine($"{input} is integer type");

                }
                else if (double.TryParse(input, out double output))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (input.Length == 1)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (input.ToLower() == "true" || input.ToLower() == "false")
                {

                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

                
            }

            
        }

    }
}
