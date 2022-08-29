using System;

namespace T01DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek =
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"

            };
            int dayNumber = int.Parse(Console.ReadLine());

            if (dayNumber > 7 || dayNumber < 1)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(daysOfWeek[dayNumber-1]);
            }
        }
    }
}
