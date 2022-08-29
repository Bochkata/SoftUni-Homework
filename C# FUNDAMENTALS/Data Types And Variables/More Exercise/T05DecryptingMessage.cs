using System;
using System.Text;

namespace T05DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            int number = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < number; i++)
            {
                char character = char.Parse(Console.ReadLine());

                char result = (char)(character + key);
                sb.Append(result);

            }

            Console.WriteLine(sb);
        }
    }
}
