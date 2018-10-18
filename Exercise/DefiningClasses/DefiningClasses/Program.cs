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
            var myFamily = new List<Person>();
            for (int i = 0; i < count; i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var age = int.Parse(tokens[1]);
                var newMember = new Person(name, age);
                myFamily.Add(newMember);
            }

            myFamily.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList().ForEach(p => Console.WriteLine($"{p.Name} - {p.Age}"));
        }
    }
}