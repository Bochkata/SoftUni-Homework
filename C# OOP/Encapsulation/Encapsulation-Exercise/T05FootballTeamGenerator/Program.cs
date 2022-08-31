using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string command;
            List<Team> teams = new List<Team>();
            while ((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command.Split(";");
                Player player;
                try
                {
                    if (tokens[0] == "Team")
                    {
                        teams.Add(new Team(tokens[1]));
                    }
                    else if (tokens[0] == "Add")
                    {
                        string currTeamName = tokens[1];

                        if (teams.All(x => x.Name != currTeamName))
                        {
                            Console.WriteLine($"Team {currTeamName} does not exist.");
                        }
                        else
                        {
                            string currPlayerName = tokens[2];
                            int currEndurance = int.Parse(tokens[3]);
                            int currSprint = int.Parse(tokens[4]);
                            int currDribble = int.Parse(tokens[5]);
                            int currPassing = int.Parse(tokens[6]);
                            int currShooting = int.Parse(tokens[7]);
                            player = new Player(currPlayerName, currEndurance, currSprint, currDribble, currPassing,
                                currShooting);
                            Team team = teams.First(x => x.Name == currTeamName);
                            team.AddPlayer(player);
                        }

                    }
                    else if (tokens[0] == "Remove")
                    {
                        string curTeamName = tokens[1];
                        string curPlayerName = tokens[2];
                        if (teams.All(x => x.Name != curTeamName))
                        {
                            Console.WriteLine($"Team {curTeamName} does not exist.");
                        }
                        else
                        {
                            Team team = teams.First(x => x.Name == curTeamName);
                            team.RemovePlayer(curPlayerName);
                        }

                    }
                    else if (tokens[0] == "Rating")
                    {
                        string nameOfTeam = tokens[1];
                        if (!teams.Any(x=>x.Name == nameOfTeam))
                        {
                            Console.WriteLine($"Team {nameOfTeam} does not exist.");
                        }
                        else
                        {
                            Team team = teams.FirstOrDefault(x => x.Name == nameOfTeam);
                            Console.WriteLine($"{team.Name} - {team.Rating(nameOfTeam)}");
                            
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }


            }
        }


    }

}

