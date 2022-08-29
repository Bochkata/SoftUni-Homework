using System;
using System.Collections.Generic;
using System.Linq;


namespace T09ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> allForceSideAllForceUsers = new Dictionary<string, List<string>>();


            while (input != "Lumpawaroo")
            {

                if (input.Contains("|"))
                {
                    string[] commands = input.Split(" | ");
                    string forceSide = commands[0];
                    string forceUser = commands[1];

                    if (!allForceSideAllForceUsers.Values.Any(x => x.Contains(forceUser)))
                    {
                        if (!allForceSideAllForceUsers.ContainsKey(forceSide))
                        {
                            allForceSideAllForceUsers.Add(forceSide, new List<string>());
                        }
                        allForceSideAllForceUsers[forceSide].Add(forceUser);
                    }

                }
                else if (input.Contains("->"))
                {
                    string[] commands = input.Split(" -> ");
                    string forceUser = commands[0];
                    string forceSide = commands[1];


                    if (allForceSideAllForceUsers.Values.Any(x => x.Contains(forceUser)))
                    {
                        allForceSideAllForceUsers.Values.Any(x => x.Remove(forceUser));
                    }

                    if (!allForceSideAllForceUsers.ContainsKey(forceSide))
                    {
                        allForceSideAllForceUsers.Add(forceSide, new List<string>());
                    }

                    allForceSideAllForceUsers[forceSide].Add(forceUser);
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }


                input = Console.ReadLine();
            }

            allForceSideAllForceUsers = allForceSideAllForceUsers.OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (KeyValuePair<string, List<string>> item in allForceSideAllForceUsers)
            {
                if (item.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                    Console.WriteLine($"! {String.Join("\n! ", item.Value.OrderBy(x => x))}");
                }
            }
        }
    }
}

