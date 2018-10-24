using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();
            Dictionary<string, List<List<string>>> departments = new Dictionary<string, List<List<string>>>();

            string command = Console.ReadLine();
            while (command != "Output")
            {
                string[] tokens = command.Split();
                var department = tokens[0];
                var firstName = tokens[1];
                var secondName = tokens[2];
                var patient = tokens[3];
                var fullName = firstName + " " + secondName;

                if (!doctors.ContainsKey(fullName))
                {
                    doctors[fullName] = new List<string>();
                }
                if (!departments.ContainsKey(department))
                {
                    departments[department] = new List<List<string>>();
                    for (int rooms = 0; rooms < 20; rooms++)
                    {
                        departments[department].Add(new List<string>());
                    }
                }

                bool isFreeSpaceLeft = departments[department].SelectMany(x => x).Count() < 60;
                if (isFreeSpaceLeft)
                {
                    int room = 0;
                    doctors[fullName].Add(patient);
                    for (int i = 0; i < departments[department].Count; i++)
                    {
                        if (departments[department][i].Count >= 3)
                        {
                            continue;
                        }

                        room = i;
                        break;
                    }
                    departments[department][room].Add(patient);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] args = command.Split();

                switch (args.Length)
                {
                    case 1:
                        Console.WriteLine(string.Join("\n", departments[args[0]].Where(x => x.Count > 0).SelectMany(x => x)));
                        break;

                    case 2 when int.TryParse(args[1], out int room):
                        Console.WriteLine(string.Join("\n", departments[args[0]][room - 1].OrderBy(x => x)));
                        break;

                    default:
                        Console.WriteLine(string.Join("\n", doctors[args[0] + " " + args[1]].OrderBy(x => x)));
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}