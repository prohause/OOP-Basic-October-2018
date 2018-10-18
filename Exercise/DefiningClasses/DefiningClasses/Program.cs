using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var rooster = new Dictionary<string, List<Employee>>();

            for (int i = 0; i < count; i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Employee current;
                var department = tokens[3];
                switch (tokens.Length)
                {
                    case 6:
                        current = new Employee(tokens[0], decimal.Parse(tokens[1]), tokens[2], tokens[3], tokens[4], int.Parse(tokens[5]));
                        break;

                    case 5:
                        try
                        {
                            current = new Employee(tokens[0], decimal.Parse(tokens[1]), tokens[2], tokens[3], int.Parse(tokens[4]));
                        }
                        catch (Exception)
                        {
                            current = new Employee(tokens[0], decimal.Parse(tokens[1]), tokens[2], tokens[3], tokens[4]);
                        }

                        break;

                    default:
                        current = new Employee(tokens[0], decimal.Parse(tokens[1]), tokens[2], tokens[3]);
                        break;
                }

                if (!rooster.ContainsKey(department))
                {
                    rooster.Add(department, new List<Employee>());
                }
                rooster[department].Add(current);
            }

            var winner = rooster.OrderByDescending(p => p.Value.Average(x => x.GetSalary())).First();
            Console.WriteLine($"Highest Average Salary: {winner.Key}");
            winner.Value.OrderByDescending(p => p.GetSalary()).ToList().ForEach(Console.WriteLine);
        }
    }
}