using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var searchFor = Console.ReadLine();
            string input;
            var family = new List<Person>();
            var relations = new List<string>();

            while ((input = Console.ReadLine()) != "End")
            {
                if (input.Contains("-"))
                {
                    relations.Add(input);
                    continue;
                }

                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0] + " " + tokens[1];
                var birthday = tokens[2];
                family.Add(new Person(name, birthday));
            }

            foreach (var line in relations)
            {
                var tokens = line.Split(new[] { "-" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => p.Trim()).ToList();
                var parentParams = tokens[0];
                var childrenParams = tokens[1];

                var parent = parentParams.Contains("/")
                    ? family.First(p => p.GetBirth().Equals(parentParams)) : family.First(p => p.GetName().Equals(parentParams));
                var child = childrenParams.Contains("/")
                    ? family.First(p => p.GetBirth().Equals(childrenParams)) : family.First(p => p.GetName().Equals(childrenParams));
                parent.AddChild(child);
                child.AddParent(parent);
            }

            var person = searchFor.Contains("/")
                ? family.First(p => p.GetBirth().Equals(searchFor)) : family.First(p => p.GetName().Equals(searchFor));
            person.Print();
        }
    }
}