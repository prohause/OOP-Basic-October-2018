using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class Person
    {
        private readonly string _name;
        private readonly string _dateOfBirth;
        private readonly List<Person> _parents;
        private readonly List<Person> _children;

        public Person(string name, string birthday)
        {
            _name = name;
            _dateOfBirth = birthday;
            _parents = new List<Person>();
            _children = new List<Person>();
        }

        public void AddParent(Person person)
        {
            _parents.Add(person);
        }

        public void AddChild(Person person)
        {
            _children.Add(person);
        }

        public override string ToString()
        {
            return $"{_name} {_dateOfBirth}";
        }

        public string GetName()
        {
            return _name;
        }

        public string GetBirth()
        {
            return _dateOfBirth;
        }

        public void Print()
        {
            Console.WriteLine(this);
            Console.WriteLine("Parents:");
            _parents.ForEach(Console.WriteLine);
            Console.WriteLine("Children:");
            _children.ForEach(Console.WriteLine);
        }
    }
}