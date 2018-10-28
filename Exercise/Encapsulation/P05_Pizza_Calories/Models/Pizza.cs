using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_Pizza_Calories.Models
{
    public class Pizza
    {
        public string Name
        {
            get => _name;
            private set
            {
                if ((string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value)) || 15 < value.Length)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                _name = value;
            }
        }

        public Dough Dough
        {
            get; set;
        }

        private readonly List<Topping> _toppings;
        private string _name;

        public Pizza(string name)
        {
            Name = name;
            _toppings = new List<Topping>();
        }

        private int NumberOfToppings()
        {
            return _toppings.Count;
        }

        public double Calories()
        {
            return Dough.Calories() + _toppings.Sum(p => p.Calories());
        }

        public void AddTopping(Topping topping)
        {
            if (NumberOfToppings() < 10)
            {
                _toppings.Add(topping);
            }
            else
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }
    }
}