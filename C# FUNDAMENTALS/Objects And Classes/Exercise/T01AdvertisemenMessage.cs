using System;
using System.Collections.Generic;

namespace T01AdvertisemenMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = {"Excellent product.", "Such a great product.", "I always use that product.", 
                "Best product of its category.", "Exceptional product.", "I can’t live without this product."};
            string[] events = {"Now I feel good.", "I have succeeded with this product.", 
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", 
                "Try it yourself, I am very satisfied.", "I feel great!"};
            string[] authors = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            string[] cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};


            Random random = new Random();
            int numberOfOutputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfOutputs; i++)
            {
                string currentPhrase = phrases[random.Next(phrases.Length)];
                string currentEvent = events[random.Next(events.Length)];
                string currentAuthor = authors[random.Next(authors.Length)];
                string currentCity = cities[random.Next(cities.Length)];
                Console.WriteLine($"{currentPhrase} {currentEvent} {currentAuthor} - {currentCity}");
            }


        }
    }
}
