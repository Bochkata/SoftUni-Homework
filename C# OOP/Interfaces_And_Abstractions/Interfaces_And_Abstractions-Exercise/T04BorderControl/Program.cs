using System;
using System.Collections.Generic;

namespace T04BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            string command;
            Dictionary<string, IIdentifiable> Ids_CitizensAndRobots = new Dictionary<string, IIdentifiable>();


            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 3)
                {
                    string citizenName = tokens[0];
                    int citizenAge = int.Parse(tokens[1]);
                    string citizenId = tokens[2];
                    IIdentifiable citizen = new Citizen(citizenName, citizenAge, citizenId);
                    if (!Ids_CitizensAndRobots.ContainsKey(citizenId))
                    {
                        Ids_CitizensAndRobots.Add(citizenId, citizen);
                    }
                }
                else if (tokens.Length == 2)
                {
                    string robotModel = tokens[0];
                    string robotId = tokens[1];
                    IIdentifiable robot = new Robot(robotId, robotModel);
                    if (!Ids_CitizensAndRobots.ContainsKey(robotId))
                    {
                        Ids_CitizensAndRobots.Add(robotId, robot);
                    }
                }
            }

            string lastDigitsOfFakeIDs = Console.ReadLine();

            foreach (KeyValuePair<string, IIdentifiable> being in Ids_CitizensAndRobots)
            {
                if (being.Key.EndsWith(lastDigitsOfFakeIDs))
                {
                    Console.WriteLine(being.Key);
                }
            }
        }
    }
}
