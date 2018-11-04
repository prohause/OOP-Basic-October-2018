using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_Border_Control
{
    public class StartUp
    {
        private static void Main(string[] args)
        {
            var allEntities = new List<IIdable>();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 2)
                {
                    allEntities.Add(new Robot(tokens[0], tokens[1]));
                }
                else
                {
                    allEntities.Add(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]));
                }
            }

            var fakeId = Console.ReadLine();
            allEntities.Where(p => p.Id.EndsWith(fakeId)).ToList().ForEach(p => Console.WriteLine(p.Id));
        }
    }
}