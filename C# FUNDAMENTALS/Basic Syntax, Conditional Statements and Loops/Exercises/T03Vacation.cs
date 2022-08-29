using System;

namespace T03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();  // (Students, Business, or Regular)
            string dayOfWeek = Console.ReadLine(); // (Friday, Saturday, or Sunday)

            double totalPrice = 0;

           //             Friday Saturday    Sunday
           // Students    8.45    9.80    10.46
           // Business    10.90   15.60   16
           //Regular      15      20      22.50


            switch (groupType)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday": totalPrice = countOfPeople * 8.45;
                            if (countOfPeople >= 30)
                            {
                                totalPrice *= 0.85; 

                            }break;
                        case "Saturday": totalPrice = countOfPeople * 9.80;
                            if (countOfPeople >= 30)
                            {
                                totalPrice *= 0.85; 

                            }break;
                        case "Sunday": totalPrice = countOfPeople * 10.46;
                            if (countOfPeople >= 30)
                            {
                                totalPrice *= 0.85; 

                            }break;


                        default:
                            break;
                             
                    }
                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday": totalPrice = countOfPeople * 10.90; 
                            if (countOfPeople >= 100)
                            {
                                totalPrice = (countOfPeople - 10) * 10.90;
                            }break;
                        case "Saturday": totalPrice = countOfPeople * 15.60;
                            if (countOfPeople >= 100)
                            {
                                totalPrice = (countOfPeople - 10) * 15.60;
                            }break;
                        case "Sunday": totalPrice = countOfPeople * 16.00;
                            if (countOfPeople >= 100)
                            {
                                totalPrice = (countOfPeople - 10) * 16.00;
                            }
                            break; 
                        default:
                            break;
                    }
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday": totalPrice = countOfPeople * 15.00;
                            if (countOfPeople >= 10 && countOfPeople <= 20)
                            {
                                totalPrice *= 0.95;
                            }break;

                        case "Saturday": totalPrice = countOfPeople * 20.00;
                            if (countOfPeople >= 10 && countOfPeople <= 20)
                            {
                                totalPrice *= 0.95;
                            }
                            break;
                        case "Sunday": totalPrice = countOfPeople * 22.50;
                            if (countOfPeople >= 10 && countOfPeople <= 20)
                            {
                                totalPrice *= 0.95;
                            }
                            break;
                        default:
                            break;
                    }
                    break;

                default:
                    break;


            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
