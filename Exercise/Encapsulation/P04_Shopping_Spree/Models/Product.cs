using System;

namespace P04_Shopping_Spree.Models
{
    public class Product
    {
        private string _name;
        private double _cost;

        public double Cost
        {
            get => _cost;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                _cost = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                _name = value;
            }
        }

        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}