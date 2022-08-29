using System;

namespace T08TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            uint population = uint.Parse(Console.ReadLine());
            int areaSq = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {population} and area {areaSq} square km.");
        }
    }
}
