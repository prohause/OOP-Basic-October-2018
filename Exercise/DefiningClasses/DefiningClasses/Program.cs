using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var allPersons = new List<Person>();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var command = tokens[1];
                if (!allPersons.Any(p => p.GetName().Equals(name)))
                {
                    allPersons.Add(new Person(name));
                }

                switch (command)
                {
                    case "company":
                        SetCompany(name, allPersons, tokens);
                        break;

                    case "pokemon":
                        AddPokemon(name, allPersons, tokens);
                        break;

                    case "parents":
                        AddParent(name, allPersons, tokens);
                        break;

                    case "children":
                        AddChild(name, allPersons, tokens);
                        break;

                    case "car":
                        SetCar(name, allPersons, tokens);
                        break;
                }
            }

            var searchFor = Console.ReadLine();
            allPersons.First(p => p.GetName().Equals(searchFor)).Print();
        }

        private static void SetCar(string name, List<Person> allPersons, string[] tokens)
        {
            var carModel = tokens[2];
            var carSpeed = int.Parse(tokens[3]);
            var car = new Car(carModel, carSpeed);
            allPersons.First(p => p.GetName().Equals(name)).SetCar(car);
        }

        private static void AddChild(string name, List<Person> allPersons, string[] tokens)
        {
            var childName = tokens[2];
            var childBirthday = tokens[3];
            var child = new Person(childName);
            child.SetBirth(childBirthday);
            allPersons.First(p => p.GetName().Equals(name)).AddChildren(child);
        }

        private static void AddParent(string name, List<Person> allPersons, string[] tokens)
        {
            var parentName = tokens[2];
            var parentBirthday = tokens[3];
            var parent = new Person(parentName);
            parent.SetBirth(parentBirthday);
            allPersons.First(p => p.GetName().Equals(name)).AddParent(parent);
        }

        private static void AddPokemon(string name, List<Person> allPersons, string[] tokens)
        {
            var pokemonName = tokens[2];
            var pokemonType = tokens[3];
            var pokemon = new Pokemon(pokemonName, pokemonType);
            allPersons.First(p => p.GetName().Equals(name)).AddPokemon(pokemon);
        }

        private static void SetCompany(string personName, List<Person> allPersons, string[] tokens)
        {
            var name = tokens[2];
            var department = tokens[3];
            var salary = double.Parse(tokens[4]);
            var company = new Company(name, department, salary);
            allPersons.First(p => p.GetName().Equals(personName)).SetCompany(company);
        }
    }
}