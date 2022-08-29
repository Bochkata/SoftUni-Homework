using System;

namespace T10PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int powerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            sbyte exhaustFactorY = sbyte.Parse(Console.ReadLine());

            int targets = 0;
            int leftPowerN = powerN;

            while (distanceM <= leftPowerN)
            {

                targets++;
                leftPowerN -= distanceM;
                if (leftPowerN == powerN * 0.50)
                {
                    
                    if (exhaustFactorY == 0)
                    {
                        continue;
                    }
                    leftPowerN /= exhaustFactorY;
                }

            }
            Console.WriteLine(leftPowerN);
            Console.WriteLine(targets);

        }
    }
}
