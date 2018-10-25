using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Shopping_Spree.Models
{
    public class Person
    {
        public string Name
        {
            get => _name;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                _name = value;
            }
        }

        public double Money
        {
            get => _money;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                _money = value;
            }
        }

        private readonly List<Product> _bag;
        private string _name;
        private double _money;

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            _bag = new List<Product>();
        }

        public void BuyProduct(Product product)
        {
            if (product.Cost > Money)
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} bought {product.Name}");
                _bag.Add(product);
                Money -= product.Cost;
            }
        }

        public override string ToString()
        {
            return _bag.Count == 0 ? $"{Name} - Nothing bought" : $"{Name} - {string.Join(", ", _bag.Select(x => x.Name))}";
        }
    }
}