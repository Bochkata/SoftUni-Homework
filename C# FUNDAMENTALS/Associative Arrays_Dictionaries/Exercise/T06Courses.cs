using System;
using System.Collections.Generic;

using System.Linq;


namespace T06Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> allCoursesAndUsers = new Dictionary<string, List<string>>();

            while (input != "end")
            {
                string[] courseAndUser = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string course = courseAndUser[0];
                string user = courseAndUser[1];
                if (!allCoursesAndUsers.ContainsKey(course))
                {
                    allCoursesAndUsers.Add(course, new List<string>());
                    allCoursesAndUsers[course].Add(user);
                }
                else
                {
                    if (!allCoursesAndUsers[course].Contains(user))
                    {
                        allCoursesAndUsers[course].Add(user);
                    }
                    
                }
                input = Console.ReadLine();
            }

            allCoursesAndUsers = allCoursesAndUsers.OrderByDescending(x => x.Value.Count).ToDictionary(a => a.Key, b => b.Value);
         
            

            foreach (KeyValuePair<string,List<string>> data in allCoursesAndUsers)
            {
                Console.WriteLine($"{data.Key}: {data.Value.Count}");
                Console.WriteLine($"-- {String.Join("\n-- ", data.Value.OrderBy(x => x))}");
               

            }
        }
    }
}
