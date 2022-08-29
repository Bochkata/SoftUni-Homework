using System;
using System.Collections.Generic;
using System.Linq;

namespace T01Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string command1 = Console.ReadLine();

            Dictionary<string, string> contestAndPassword = new Dictionary<string, string>();

            while (command1 != "end of contests")
            {
                string[] subCommand1 = command1.Split(":");

                string competition = subCommand1[0];
                string password = subCommand1[1];

                contestAndPassword[competition] = password;

                command1 = Console.ReadLine();
            }

            Dictionary<string, int> usersAndTotalPoints = new Dictionary<string, int>();

            Dictionary<string, Dictionary<string, int>> users_Contests_Points =
                new Dictionary<string, Dictionary<string, int>>();



            string command2 = Console.ReadLine();

            while (command2 != "end of submissions")
            {

                string[] subcommand2 = command2.Split("=>");

                string contest = subcommand2[0];
                string contestPassword = subcommand2[1];
                string userName = subcommand2[2];
                int points = int.Parse(subcommand2[3]);


                bool isValid = false;

                if (contestAndPassword.ContainsKey(contest) && contestAndPassword[contest] == contestPassword)
                {
                    isValid = true;
                }

                if (isValid)
                {
                    if (!users_Contests_Points.ContainsKey(userName))
                    {
                        users_Contests_Points.Add(userName, new Dictionary<string, int>());
                        users_Contests_Points[userName].Add(contest, points);
                        usersAndTotalPoints.Add(userName, points);

                    }
                    else
                    {
                        if (!users_Contests_Points[userName].ContainsKey(contest))
                        {
                            users_Contests_Points[userName].Add(contest, points);
                            usersAndTotalPoints[userName] += points;
                        }
                        else
                        {

                            if (users_Contests_Points[userName][contest] < points)
                            {
                                usersAndTotalPoints[userName] -= users_Contests_Points[userName][contest];
                                users_Contests_Points[userName][contest] = points;
                                usersAndTotalPoints[userName] += points;
                            }
                        }

                    }
                }


                command2 = Console.ReadLine();

            }

            foreach (KeyValuePair<string, int> user in usersAndTotalPoints.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"Best candidate is {user.Key} with total {user.Value} points.");
                break;
            }

            users_Contests_Points = users_Contests_Points.OrderBy(x => x.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            Console.WriteLine("Ranking: ");
            foreach (KeyValuePair<string, Dictionary<string, int>> user in users_Contests_Points)
            {
                Console.WriteLine($"{user.Key}");
                foreach (KeyValuePair<string, int> contest in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }

}





