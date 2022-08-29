using System;
using System.Collections.Generic;
using System.Linq;



namespace T05TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());

            List<Team> allTeams = new List<Team>();

            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] creatorAndTeamName = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);

                string creatorOrUser = creatorAndTeamName[0];
                string teamName = creatorAndTeamName[1];

                if (allTeams.Any(item=> item.CreatorOrUser == creatorOrUser))
                {
                    Console.WriteLine($"{creatorOrUser} cannot create another team!");
                }
                else if (allTeams.Any(item => item.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else
                {
                    Team team = new Team();
                    {
                        team.CreatorOrUser = creatorOrUser;
                        team.TeamName = teamName;
                        team.Members = new List<string>();

                    }
                    allTeams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creatorOrUser}!");
                }
            }

            string[] joinerAndTeamName = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries);

            while (joinerAndTeamName[0] != "end of assignment")
            {
                string joiner_user = joinerAndTeamName[0];
                string newTeam = joinerAndTeamName[1];

                if (!allTeams.Any(item => item.TeamName == newTeam))
                {
                    Console.WriteLine($"Team {newTeam} does not exist!");
                }
                else if (allTeams.Any(item => item.CreatorOrUser == joiner_user
                || item.Members.Contains(joiner_user)))

                {
                    Console.WriteLine($"Member {joiner_user} cannot join team {newTeam}!");
                }
                else if (allTeams.Any(item => item.TeamName == newTeam)
                         && !allTeams.Any(item => item.Members.Contains(joiner_user)))
                {
                    Team currentTeam = allTeams.First(team => team.TeamName == newTeam);
                    currentTeam.Members.Add(joiner_user);
                    currentTeam.Members.Sort();

                }

                joinerAndTeamName = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries);

            }

            allTeams = allTeams.OrderByDescending(el => el.Members.Count).ThenBy(el => el.TeamName).ToList();
            
            

            foreach (Team eachTeam in allTeams.Where(team => team.Members.Count > 0))
            {

                Console.WriteLine($"{eachTeam.TeamName}");
                Console.WriteLine($"- {eachTeam.CreatorOrUser}");
                foreach (string member in eachTeam.Members)
                {
                    Console.WriteLine($"-- {member}");
                }

            }


            Console.WriteLine("Teams to disband:");
            foreach (Team eachTeam in allTeams.Where(team => team.Members.Count == 0))
            {
                Console.WriteLine(eachTeam.TeamName);
            }


        }
        class Team
        {
            public string TeamName { get; set; }
            public string CreatorOrUser { get; set; }
            public List<string> Members { get; set; }
        }

    }
}
