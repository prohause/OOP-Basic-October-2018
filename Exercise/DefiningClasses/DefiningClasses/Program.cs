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
                var engineSpeed = int.Parse(tokens[1]);
                var enginePower = int.Parse(tokens[2]);
                var cargoWeight = int.Parse(tokens[3]);
                var cargoType = tokens[4];
                var tyre1Pressure = double.Parse(tokens[5]);
                var tyre2Pressure = double.Parse(tokens[7]);
                var tyre3Pressure = double.Parse(tokens[9]);
                var tyre4Pressure = double.Parse(tokens[11]);
                var tyre1Age = int.Parse(tokens[6]);
                var tyre2Age = int.Parse(tokens[8]);
                var tyre3Age = int.Parse(tokens[10]);
                var tyre4Age = int.Parse(tokens[12]);

                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoWeight, cargoType);
                var tyres = new List<Tyre>
                {
                    new Tyre(tyre1Pressure,tyre1Age),new Tyre(tyre2Pressure,tyre2Age),
                    new Tyre(tyre3Pressure,tyre3Age),new Tyre(tyre4Pressure,tyre4Age)
                };
                allCars.Add(new Car(model, engine, cargo, tyres));
            }

            var search = Console.ReadLine();
            if (search.Equals("fragile"))
            {
                allCars.Where(p => p.Cargo1.GetCargoType().Equals("fragile") && p.Tyres.Any(x => x.UnderInflated())).ToList().ForEach(Console.WriteLine);
            }
            else if (search.Equals("flamable"))
            {
                allCars.Where(p => p.Cargo1.GetCargoType().Equals("flamable") && p.Engine1.OverPower()).ToList().ForEach(Console.WriteLine);
            }
        }
    }
}