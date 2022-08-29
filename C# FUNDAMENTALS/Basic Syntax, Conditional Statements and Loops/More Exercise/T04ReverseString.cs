using System;
using System.Linq;

namespace T04ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //string output = String.Empty;

            //for (int i = input.Length-1; i >= 0 ; i--)
            //{
            //    output += input[i];
            //}

            string output = new string(input.ToCharArray().Reverse().ToArray());
            Console.WriteLine(output);
        }
    }
}
