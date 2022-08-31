

using System;
using System.Collections.Generic;
using System.Linq;


namespace FootballTeamGenerator
{
    public class Team
    {

        private string name;
        private List<Player> players = new List<Player>();

        public Team(string name)
        {
            Name = name;
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }


        public int Rating(string teamName)
        {
            int result = players.Count > 0 ? (int)Math.Round(players.Average(x => x.Stats)) : 0;
            return result;
        }

        //public IReadOnlyCollection<Player> Players => players;

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }
        public void RemovePlayer(string playerName)
        {

            if (players.All(x => x.Name != playerName))
            {
                Console.WriteLine($"Player {playerName} is not in {Name} team.");
            }
            else
            {
                players.Remove(players.First(x => x.Name == playerName));

            }

        }

    }
}
