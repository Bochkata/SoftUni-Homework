using System;
using System.Collections.Generic;

namespace T05SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            Dictionary<string, string> allUsers = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "register")
                {

                    string user = commands[1];
                    string registrationPlate = commands[2];

                    if (!allUsers.ContainsKey(user))
                    {
                        allUsers[user] = registrationPlate;
                        Console.WriteLine($"{user} registered {registrationPlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {allUsers[user]}");
                    }
                }
                else if (commands[0] == "unregister")
                {
                    string userToUnregister = commands[1];

                    if (!allUsers.ContainsKey(userToUnregister))
                    {
                        Console.WriteLine($"ERROR: user {userToUnregister} not found");
                    }
                    else
                    {
                        allUsers.Remove(userToUnregister);
                        Console.WriteLine($"{userToUnregister} unregistered successfully");
                    }
                }
            }

            foreach (KeyValuePair<string, string> user in allUsers)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
