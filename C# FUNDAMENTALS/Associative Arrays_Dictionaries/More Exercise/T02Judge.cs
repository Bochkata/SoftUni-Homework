using System;
using System.Collections.Generic;
using System.Linq;


namespace T02Judge
{
    class Program
    {
        static void Main(string[] args)

        {
            Dictionary<string, Dictionary<string, int>> allContests_AllUsers_AllPoints =
                new Dictionary<string, Dictionary<string, int>>();
            

            string[] input = Console.ReadLine().Split(" -> ");

            while (input[0] != "no more time")
            {

                string currentUser = input[0];
                string currentContest = input[1];
                int currentPoints = int.Parse(input[2]);

                if (!allContests_AllUsers_AllPoints.ContainsKey(currentContest))
                {
                    allContests_AllUsers_AllPoints.Add(currentContest, new Dictionary<string, int>());

                }

                if (!allContests_AllUsers_AllPoints[currentContest].ContainsKey(currentUser))
                {
                    allContests_AllUsers_AllPoints[currentContest].Add(currentUser, currentPoints);
                   
                }

                if (allContests_AllUsers_AllPoints[currentContest][currentUser] < currentPoints)
                {
                    allContests_AllUsers_AllPoints[currentContest][currentUser] = currentPoints;
                    

                }


                input = Console.ReadLine().Split(" -> ");

            }


            foreach (KeyValuePair<string, Dictionary<string, int>> contest in allContests_AllUsers_AllPoints)
            {

                Console.WriteLine($"{contest.Key}: {contest.Value.Keys.Count} participants");
                int position = 1;
                foreach (KeyValuePair<string, int> person in contest.Value.OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {

                    Console.WriteLine($"{position++}. {person.Key} <::> {person.Value}");
                }

            }

            Dictionary<string, int> allUsers_TotalPoints = new Dictionary<string, int>();

            foreach (KeyValuePair<string, Dictionary<string, int>> item in allContests_AllUsers_AllPoints)
            {
                foreach (KeyValuePair<string, int> person in item.Value)
                {
                    if (!allUsers_TotalPoints.ContainsKey(person.Key))

                    {
                        allUsers_TotalPoints.Add(person.Key, 0);
                    }
                    
                    allUsers_TotalPoints[person.Key] += person.Value;
                    
                }
            }

            int count = 1;
            Console.WriteLine("Individual standings:");
            foreach (KeyValuePair<string, int> name in allUsers_TotalPoints.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{count++}. {name.Key} -> {name.Value}");
            }
        }
    }
}
           
             
                    
                
            
           
            
