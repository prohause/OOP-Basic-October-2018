using P06_Football_Team_Generator.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_Football_Team_Generator
{
    internal class StartUp
    {
        private static readonly List<Team> MyTeams = new List<Team>();

        private static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split(new[] { ';' });
                var command = tokens[0];

                switch (command)
                {
                    case "Team":
                        AddTeam(tokens);
                        break;

                    case "Add":
                        AddPlayer(tokens);
                        break;

                    case "Remove":
                        RemovePLayer(tokens);
                        break;

                    case "Rating":
                        PrintRating(tokens);
                        break;
                }
            }
        }

        private static void RemovePLayer(IReadOnlyList<string> tokens)
        {
            var teamName = tokens[1];
            var playerName = tokens[2];

            if (MyTeams.Any(p => p.Name == teamName))
            {
                try
                {
                    MyTeams.First(p => p.Name == teamName).RemovePlayer(playerName);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            else
            {
                Console.WriteLine($"Team {teamName} does not exist.");
            }
        }

        private static void AddPlayer(IReadOnlyList<string> tokens)
        {
            var teamName = tokens[1];
            var playerName = tokens[2];
            var endurance = int.Parse(tokens[3]);
            var sprint = int.Parse(tokens[4]);
            var dribble = int.Parse(tokens[5]);
            var passing = int.Parse(tokens[6]);
            var shooting = int.Parse(tokens[7]);

            if (MyTeams.Any(p => p.Name == teamName))
            {
                try
                {
                    MyTeams.First(p => p.Name == teamName).AddPlayer(new Player(playerName, endurance, sprint, dribble, passing, shooting));
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            else
            {
                Console.WriteLine($"Team {teamName} does not exist.");
            }
        }

        private static void PrintRating(IReadOnlyList<string> tokens)
        {
            var teamName = tokens[1];
            Console.WriteLine(MyTeams.All(p => p.Name != teamName)
                ? $"Team {teamName} does not exist."
                : MyTeams.First(p => p.Name == teamName).ToString());
        }

        private static void AddTeam(IReadOnlyList<string> tokens)
        {
            var teamName = tokens[1];
            try
            {
                var currentTeam = new Team(teamName);
                MyTeams.Add(currentTeam);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}