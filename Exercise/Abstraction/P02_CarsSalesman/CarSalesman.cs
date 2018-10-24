using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_CarsSalesman
{
    public class CarSalesman
    {
        private static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();
            int engineCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < engineCount; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = parameters[0];
                int power = int.Parse(parameters[1]);

                switch (parameters.Length)
                {
                    case 3 when int.TryParse(parameters[2], out var displacement):
                        engines.Add(new Engine(model, power, displacement));
                        break;

                    case 3:
                        {
                            string efficiency = parameters[2];
                            engines.Add(new Engine(model, power, efficiency));
                            break;
                        }
                    case 4:
                        {
                            string efficiency = parameters[3];
                            engines.Add(new Engine(model, power, int.Parse(parameters[2]), efficiency));
                            break;
                        }
                    default:
                        engines.Add(new Engine(model, power));
                        break;
                }
            }
            int carCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carCount; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = parameters[0];
                string engineModel = parameters[1];
                Engine engine = engines.FirstOrDefault(x => x.Model == engineModel);

                switch (parameters.Length)
                {
                    case 3 when int.TryParse(parameters[2], out var weight):
                        cars.Add(new Car(model, engine, weight));
                        break;

                    case 3:
                        {
                            string color = parameters[2];
                            cars.Add(new Car(model, engine, color));
                            break;
                        }
                    case 4:
                        {
                            string color = parameters[3];
                            cars.Add(new Car(model, engine, int.Parse(parameters[2]), color));
                            break;
                        }
                    default:
                        cars.Add(new Car(model, engine));
                        break;
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}