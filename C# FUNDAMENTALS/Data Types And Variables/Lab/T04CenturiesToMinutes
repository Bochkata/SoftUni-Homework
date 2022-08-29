using System;
using System.Numerics;

namespace T04CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            ulong hours =(ulong)days * 24;
            BigInteger minutes = hours * 60;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", 
                centuries, years, days, hours, minutes);
        }
    }
}
