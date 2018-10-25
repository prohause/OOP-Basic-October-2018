using System;
using System.Collections.Generic;

namespace P05_Pizza_Calories.Models
{
    public class Topping
    {
        private static readonly Dictionary<string, double> ToppingTypes = new Dictionary<string, double>
            { {"meat",1.2},{ "veggies",0.8 },{"cheese",1.1},{"sauce",0.9} };

        private string _type;
        private double _weight;

        public string Type
        {
            get => _type;
            private set
            {
                if (!ToppingTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                _type = value;
            }
        }

        public double Weight
        {
            get => _weight;
            private set
            {
                if (value < 1 || 50 < value)
                {
                    throw new ArgumentException($"{Type} weight should be in the range [1..50].");
                }
                _weight = value;
            }
        }

        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }

        public double Calories()
        {
            return Weight * 2.0 * ToppingTypes[Type.ToLower()];
        }
    }
}