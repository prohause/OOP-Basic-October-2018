using System;

namespace P01_Person.Models
{
    internal class Child : Person
    {
        private int _age1;

        public Child(string name, int age) : base(name, age)
        {
        }

        public override int Age
        {
            get => base.Age;
            set
            {
                if (value >= 15)
                {
                    throw new ArgumentException("Child\'s age must be less than 15!");
                }
                base.Age = value;
            }
        }
    }
}