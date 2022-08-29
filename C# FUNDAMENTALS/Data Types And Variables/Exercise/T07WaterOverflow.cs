using System;

namespace T07WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numberOfPours = sbyte.Parse(Console.ReadLine());

            int litresInTank = 0;
            while (numberOfPours > 0)
            {
                short pouredLitres = short.Parse(Console.ReadLine());
                numberOfPours--;
                litresInTank += pouredLitres;
                if (litresInTank > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    litresInTank -= pouredLitres;
                    continue;
                }

            }

            Console.WriteLine(litresInTank);
        }

    }
}
