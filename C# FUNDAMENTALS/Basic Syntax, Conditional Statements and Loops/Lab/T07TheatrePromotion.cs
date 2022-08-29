using System;

namespace T07TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Day / Age    0 <= age <= 18  18 < age <= 64  64 < age <= 122
            //    Weekday           12$	            18$	            12$
            //Weekend               15$	            20$	            15$
            //Holiday               5$	            12$	            10$

            var dayType = Console.ReadLine().ToLower();
            var age = int.Parse(Console.ReadLine());
            int ticketprice = 0;

            switch (dayType)
            {
                case "weekday":
                    if ((age >= 0 && age <= 18) || (age > 64 && age <=122))
                    {
                        ticketprice = 12;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        ticketprice = 18;
                    }
                    
                    break;
                    

                case "weekend":
                    if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                    {
                        ticketprice = 15;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        ticketprice = 20;
                    }
                    
                    break;


                case "holiday":
                    if (age >= 0 && age <= 18)
                    {
                        ticketprice = 5;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        ticketprice = 12;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        ticketprice = 10;
                    }
                    break;

                default:
                    break;
            }
            if (ticketprice != 0)
            {

                Console.WriteLine($"{ticketprice}$");
            }
            else
            {

                Console.WriteLine("Error!");
                
            }    
        }
    }
}
