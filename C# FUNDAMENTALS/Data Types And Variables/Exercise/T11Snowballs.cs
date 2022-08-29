using System;
using System.Numerics;

namespace T11Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numberOfSnowballs = sbyte.Parse(Console.ReadLine());

            BigInteger snowballValue = 0;
            BigInteger bestsnowballValue = 0;
            string bestResult = string.Empty;

            for (int i = 1; i <= numberOfSnowballs; i++)
            {

                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                sbyte snowballQuality = sbyte.Parse(Console.ReadLine());

                snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                //snowballValue = (BigInteger)(Math.Pow((snowballSnow / snowballTime), snowballQuality));
                
                if (bestsnowballValue < snowballValue)
                {
                    bestsnowballValue = snowballValue;
                    bestResult = $"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})";
                }
            }

            Console.WriteLine(bestResult);


        }
    }
}
