using System;
using System.Linq;


namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] urls = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            SmartPhone smartPhone = new SmartPhone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                try
                {
                    if (!phoneNumbers[i].All(x => Char.IsDigit(x)))
                    {
                        throw new ArgumentException("Invalid number!");
                    }

                    if (phoneNumbers[i].Length == 10)
                    {

                        Console.WriteLine(smartPhone.CanCall(phoneNumbers[i]));
                    }
                    else if (phoneNumbers[i].Length == 7)
                    {

                        Console.WriteLine(stationaryPhone.CanCall(phoneNumbers[i]));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }

            }

            for (int i = 0; i < urls.Length; i++)
            {
                try
                {
                    if (urls[i].Any(x => Char.IsDigit(x)))
                    {
                        throw new ArgumentException("Invalid URL!");
                    }


                    Console.WriteLine(smartPhone.CanBrowse(urls[i]));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }

            }

        }
    }
}
