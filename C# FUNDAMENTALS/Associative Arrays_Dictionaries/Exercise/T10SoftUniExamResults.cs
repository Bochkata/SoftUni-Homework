using System;
using System.Collections.Generic;

using System.Linq;

namespace T10SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> allUsersAndPoints = new Dictionary<string, int>();
            Dictionary<string, int> allLanguagesAndSubmissions = new Dictionary<string, int>();

            while (input != "exam finished")
            {

                string[] command = input.Split("-");

                string currentUser = command[0];

                if (command[1] != "banned")
                {
                    string currentLanguage = command[1];
                    int currentPoints = int.Parse(command[2]);
                    
                    if (!allUsersAndPoints.ContainsKey(currentUser))
                    {
                        allUsersAndPoints.Add(currentUser, currentPoints);
                        
                    }
                    else if (allUsersAndPoints.ContainsKey(currentUser) &&
                             allUsersAndPoints[currentUser] < currentPoints)
                    {
                        allUsersAndPoints[currentUser] = currentPoints;
                    }
                    
                    if (!allLanguagesAndSubmissions.ContainsKey(currentLanguage))
                    {
                        allLanguagesAndSubmissions.Add(currentLanguage, 0);
                    }

                    allLanguagesAndSubmissions[currentLanguage]++;

                }
                else if (command[1] == "banned")
                {
                    allUsersAndPoints.Remove(currentUser);
                }

                input = Console.ReadLine();
            }

            allUsersAndPoints = allUsersAndPoints.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            allLanguagesAndSubmissions = allLanguagesAndSubmissions.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            Console.WriteLine("Results:");
            foreach (KeyValuePair<string, int> user in allUsersAndPoints)
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (KeyValuePair<string, int> language in allLanguagesAndSubmissions)
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }

    }
