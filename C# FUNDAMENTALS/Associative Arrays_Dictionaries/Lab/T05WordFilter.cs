using System;
using System.Linq;

namespace T05WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join("\n", Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length % 2 == 0)).ToArray());
        }
    }
}
