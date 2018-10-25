using System;
using System.Collections.Generic;

namespace P05_Pizza_Calories.Models
{
    public class Dough
    {
        private static readonly Dictionary<string, double> DoughTypes = new Dictionary<string, double>
            { {"white",1.5},{ "wholegrain",1.0 } };

        private static readonly Dictionary<string, double> DoughTechnique = new Dictionary<string, double>
            { { "crispy", 0.9 }, { "chewy", 1.1 }, { "homemade", 1.0 } };

        private string _type;
        private string _technique;
        private double _weight;

        public string Type
        {
            get => _type;
            private set
            {
                if (!DoughTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                _type = value;
            }
        }

        public string Technique
        {
            get => _technique;
            private set
            {
                if (!DoughTechnique.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                _technique = value;
            }
        }

        public double Weight
        {
            get => _weight;
            set
            {
                if (value < 1 || 200 < value)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                _weight = value;
            }
        }

        public Dough(string type, string technique, double weight)
        {
            Type = type;
            Technique = technique;
            Weight = weight;
        }

        public double Calories()
        {
            return Weight * 2.0 * DoughTypes[Type.ToLower()] * DoughTechnique[Technique.ToLower()];
        }
    }
}