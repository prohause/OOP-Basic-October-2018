using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        private static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                    cmdArgs[1],
                    int.Parse(cmdArgs[2]),
                    decimal.Parse(cmdArgs[3]));

                persons.Add(person);
            }
            var myTeam = new Team("Test");
            foreach (var person in persons)
            {
                myTeam.AddPlayer(person);
            }

            Console.WriteLine($"First team has {myTeam.FirstTeam.Count} players." +
                              $"\r\nReserve team has {myTeam.ReserveTeam.Count} players.");
        }
    }
}