using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var allCars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var model = tokens[0];
                var fuelAmount = double.Parse(tokens[1]);
                var fuelConsumption = double.Parse(tokens[2]);

                if (allCars.Any(p => p.Model.Equals(model)))
                {
                    continue;
                }
                allCars.Add(new Car(model, fuelAmount, fuelConsumption));
            }

            string input;

            while (!(input = Console.ReadLine()).Equals("End"))
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var model = tokens[1];
                var distance = double.Parse(tokens[2]);

                if (allCars.Any(p => p.Model.Equals(model)))
                {
                    allCars.First(p => p.Model.Equals(model)).Drive(distance);
                }
            }

            allCars.ForEach(Console.WriteLine);
        }
    }
}