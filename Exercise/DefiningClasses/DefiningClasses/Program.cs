using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var allTrainers = new List<Trainer>();
            string input;

            while (!(input = Console.ReadLine()).Equals("Tournament"))
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var trainerName = tokens[0];
                var pokemonName = tokens[1];
                var pokemonElement = tokens[2];
                var pokemonHealth = int.Parse(tokens[3]);

                if (!allTrainers.Any(p => p.GetName().Equals(trainerName)))
                {
                    allTrainers.Add(new Trainer(trainerName));
                }

                allTrainers.First(p => p.GetName().Equals(trainerName))
                    .AddPokemon(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
            }

            while (!(input = Console.ReadLine()).Equals("End"))
            {
                foreach (var trainer in allTrainers)
                {
                    if (trainer.HAsElement(input))
                    {
                        trainer.AddBadge();
                    }
                    else
                    {
                        trainer.DecreaseHealth();
                    }
                }
            }

            allTrainers.OrderByDescending(p => p.GetBadges()).ToList().ForEach(Console.WriteLine);
        }
    }
}