using System;
using System.Globalization;

namespace T13HolidaysBetweenTwoDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);
            var holidaysCount = 0;
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    holidaysCount++;

            Console.WriteLine(holidaysCount);

            //var startDt = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            //var endDt = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

            //var holidaysCount = 0;

            //for (var i = startDt; i <= endDt; i = i.AddDays(1))
            
            //    if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday)
                
            //        holidaysCount++;
                
            
            //Console.WriteLine(holidaysCount);
            

        }
    }
}
