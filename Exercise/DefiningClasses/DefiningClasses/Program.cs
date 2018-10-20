using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var engineCount = int.Parse(Console.ReadLine());
            var allEngines = new List<Engine>();

            for (int i = 0; i < engineCount; i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var model = tokens[0];
                var power = int.Parse(tokens[1]);

                switch (tokens.Length)
                {
                    case 4:
                        allEngines.Add(new Engine(model, power, int.Parse(tokens[2]), tokens[3]));
                        break;

                    case 3:
                        try
                        {
                            allEngines.Add(new Engine(model, power, int.Parse(tokens[2])));
                        }
                        catch (Exception)
                        {
                            allEngines.Add(new Engine(model, power, tokens[2]));
                        }

                        break;

                    case 2:
                        allEngines.Add(new Engine(model, power));
                        break;
                }
            }
            var allCars = new List<Car>();
            var carCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carCount; i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var carModel = tokens[0];
                var engineModel = tokens[1];
                var currentEngine = allEngines.First(p => p.GetModel().Equals(engineModel));

                if (tokens.Length == 4)
                {
                    allCars.Add(new Car(carModel, currentEngine, int.Parse(tokens[2]), tokens[3]));
                }
                else if (tokens.Length == 3)
                {
                    try
                    {
                        allCars.Add(new Car(carModel, currentEngine, int.Parse(tokens[2])));
                    }
                    catch (Exception)
                    {
                        allCars.Add(new Car(carModel, currentEngine, tokens[2]));
                    }
                }
                else if (tokens.Length == 2)
                {
                    allCars.Add(new Car(carModel, currentEngine));
                }
            }

            allCars.ForEach(Console.WriteLine);
        }
    }
}