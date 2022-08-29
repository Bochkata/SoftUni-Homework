using System;
using System.Collections.Generic;
using System.Linq;

namespace T03MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;

            Dictionary<string, Dictionary<string, int>> allPlayers_Positions_Points =
                new Dictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "Season end")
            {

                string[] commands = input.Split(" -> ");
                if (commands.Length == 3)
                {
                    string currentPlayer = commands[0];
                    string currentPosition = commands[1];
                    int currentPoints = int.Parse(commands[2]);

                    if (!allPlayers_Positions_Points.ContainsKey(currentPlayer))
                    {
                        allPlayers_Positions_Points.Add(currentPlayer, new Dictionary<string, int>());
                    }

                    if (!allPlayers_Positions_Points[currentPlayer].ContainsKey(currentPosition))
                    {

                        allPlayers_Positions_Points[currentPlayer].Add(currentPosition, currentPoints);
                    }

                    if (allPlayers_Positions_Points[currentPlayer][currentPosition] < currentPoints)
                    {
                        allPlayers_Positions_Points[currentPlayer][currentPosition] = currentPoints;
                    }
                }

                else if (commands.Length == 1)
                {
                    string[] subCommands = input.Split(" vs ");
                    string currentFirstPlayer = subCommands[0];
                    string currentSecondPlayer = subCommands[1];
                    if (allPlayers_Positions_Points.ContainsKey(currentFirstPlayer) &&
                        allPlayers_Positions_Points.ContainsKey(currentSecondPlayer))
                    {
                        int firstPlayerTotalPoints = 0;
                        int secondPlayerTotalPoints = 0;
                        foreach (KeyValuePair<string, int> game in allPlayers_Positions_Points[currentFirstPlayer])
                        {
                            foreach (KeyValuePair<string, int> position in allPlayers_Positions_Points[currentSecondPlayer])
                            {
                                if (game.Key == position.Key)
                                {
                                    firstPlayerTotalPoints += game.Value;
                                    secondPlayerTotalPoints += position.Value;
                                }
                            }
                        }

                        if (firstPlayerTotalPoints > secondPlayerTotalPoints)
                        {
                            allPlayers_Positions_Points.Remove(currentSecondPlayer);
                        }
                        else if (secondPlayerTotalPoints > firstPlayerTotalPoints)
                        {
                            allPlayers_Positions_Points.Remove(currentFirstPlayer);
                        }
                    }
                    
                }

            }

            allPlayers_Positions_Points = allPlayers_Positions_Points.OrderByDescending(x => x.Value.Values.Sum())
                .ThenBy(x => x.Key).ToDictionary(k => k.Key, v => v.Value);

            foreach (KeyValuePair<string, Dictionary<string, int>> player in allPlayers_Positions_Points)
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                foreach (KeyValuePair<string, int> position in player.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }




        }
    }
}
