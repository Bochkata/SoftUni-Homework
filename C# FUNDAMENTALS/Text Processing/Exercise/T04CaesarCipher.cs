using System;

namespace T04CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                result[i] = (char)(input[i] + 3);
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
