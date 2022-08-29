using System;

namespace T09SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());

            const byte YIELD_DECREASE_PER_DAY = 10;
            const byte YIELD_CONSUMED_BY_WORKERS = 26;
            const byte PROFITABLE_YIELD = 100;

            int countDays = 0;

            int finalYield = 0;

            while (yield >= PROFITABLE_YIELD)
            {
                finalYield += yield - YIELD_CONSUMED_BY_WORKERS;

                countDays++;

                yield -= YIELD_DECREASE_PER_DAY;
                if (yield < PROFITABLE_YIELD)
                {
                    finalYield -= YIELD_CONSUMED_BY_WORKERS;
                }

            }
           
            Console.WriteLine(countDays);
            Console.WriteLine(finalYield);


        }
    }
}
