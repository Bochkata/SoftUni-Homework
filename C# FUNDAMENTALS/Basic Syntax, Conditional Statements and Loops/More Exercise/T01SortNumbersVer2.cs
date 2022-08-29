using System;

namespace T01SortNumbersVer2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int maxNum = Math.Max((Math.Max(n1, n2)),n3);
            int minNum = Math.Min((Math.Min(n1, n2)), n3);
            int middleNum = (n1 + n2 + n3) - maxNum - minNum;
            Console.WriteLine(maxNum);
            Console.WriteLine(middleNum);
            Console.WriteLine(minNum);

        }
    }
}
