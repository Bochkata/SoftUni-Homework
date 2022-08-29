using System;
using System.Collections.Generic;
using System.Linq;

namespace T01RankingVer2
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

                    }
                    if (!users_Contests_Points[userName].ContainsKey(contest))
                    {
                        users_Contests_Points[userName].Add(contest, points);

                    }

                    if (users_Contests_Points[userName][contest] < points)
                    {
                        users_Contests_Points[userName][contest] = points;
                    }
                }

                command2 = Console.ReadLine();
            }

           
            string bestUser = users_Contests_Points.OrderByDescending(x => x.Value.Values.Sum())
                .First().Key;
            int bestResult = users_Contests_Points.OrderByDescending(x => x.Value.Values.Sum())
                .First().Value.Values.Sum();

            Console.WriteLine($"Best candidate is {bestUser} with total {bestResult} points.");

            Console.WriteLine("Ranking: ");
            foreach (KeyValuePair<string, Dictionary<string, int>> user in users_Contests_Points
                .OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{user.Key}");
                foreach (KeyValuePair<string, int> contest in user.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
                
               
            }
            
        }
    }
}
