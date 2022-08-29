using System;

namespace T05Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string input = Console.ReadLine();
            string password = string.Empty;
            int triesCount = 0;

            for (int i = username.Length -1; i >= 0; i--)
            {
                password += username[i];
            }

            while (input != password)
            {
                triesCount++;
                if (triesCount == 4)
                {
                    Console.WriteLine($"User {username} blocked!");  return;
                }

                Console.WriteLine("Incorrect password. Try again.");

                input = Console.ReadLine();
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
