using System;

namespace T08BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numberOfKegs = sbyte.Parse(Console.ReadLine());

            decimal biggestVolume = 0;
            string biggestKeg = string.Empty;

            for (int i = 1; i <= numberOfKegs; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                decimal kegVolume = (decimal)(Math.PI * Math.Pow(kegRadius, 2)) * height;
                                          
                if (biggestVolume < kegVolume)
                {
                    biggestVolume = kegVolume;
                    biggestKeg = kegModel;
                }

            }
            Console.WriteLine(biggestKeg);
        }
    }
}
