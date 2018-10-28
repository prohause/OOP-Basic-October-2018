using System;

namespace P01_Person.Models
{
    internal class Person
    {
        private string _name;
        private int _age;

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name\'s length should not be less than 3 symbols!");
                }
                _name = value;
            }
        }

        public virtual int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                _age = value;
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}