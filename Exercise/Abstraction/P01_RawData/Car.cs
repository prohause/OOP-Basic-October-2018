using System.Collections.Generic;

namespace P01_RawData
{
    internal class Car
    {
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType,
            double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure,
            int tire3Age, double tire4Pressure, int tire4Age)
        {
            Model = model;
            Engine = new Engine(engineSpeed, enginePower);
            Cargo = new Cargo(cargoWeight, cargoType);
            Tires = new List<Tyre>() { new Tyre(tire1Pressure, tire1Age), new Tyre(tire2Pressure, tire2Age),
                new Tyre(tire3Pressure, tire3Age), new Tyre(tire4Pressure, tire4Age) };
        }

        public string Model;
        public Engine Engine;
        public Cargo Cargo;
        public List<Tyre> Tires;
    }
}