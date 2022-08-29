using System;

namespace T04PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }
           
            Console.WriteLine($"\nSum: {sum}");
            
        }
    }
}
