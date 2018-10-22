using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class Person
    {
        private readonly string _name;
        private string _dateOfBirth;
        private Company _company;
        private readonly List<Pokemon> _pokemons;
        private readonly List<Person> _parents;
        private readonly List<Person> _children;
        private Car _car;

        public Person(string name)
        {
            _name = name;
            _dateOfBirth = null;
            _company = null;
            _pokemons = new List<Pokemon>();
            _parents = new List<Person>();
            _children = new List<Person>();
            _car = null;
        }

        public void SetBirth(string input)
        {
            _dateOfBirth = input;
        }

        public void AddPokemon(Pokemon pokemon)
        {
            _pokemons.Add(pokemon);
        }

        public void AddParent(Person person)
        {
            _parents.Add(person);
        }

        public void AddChildren(Person person)
        {
            _children.Add(person);
        }

        public void SetCar(Car car)
        {
            _car = car;
        }

        public void SetCompany(Company company)
        {
            _company = company;
        }

        public override string ToString()
        {
            return $"{_name} {_dateOfBirth}";
        }

        public string GetName()
        {
            return _name;
        }

        public void Print()
        {
            Console.WriteLine($"{_name}");
            Console.WriteLine($"Company:{_company}");
            Console.WriteLine($"Car:{_car}");
            Console.WriteLine("Pokemon:");
            _pokemons.ForEach(Console.WriteLine);
            Console.WriteLine("Parents:");
            _parents.ForEach(Console.WriteLine);
            Console.WriteLine("Children:");
            _children.ForEach(Console.WriteLine);
        }
    }
}