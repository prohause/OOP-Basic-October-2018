using System;

namespace P01_Vehicles
{
    public class Car : Vehicle
    {
        public override void Drive(double distance)
        {
            var fuelNeeded = distance * FuelConsumption;
            if (fuelNeeded > Fuel)
            {
                Console.WriteLine("Car needs refueling");
                return;
            }

            Fuel -= fuelNeeded;
            Distance += distance;
            Console.WriteLine($"Car travelled {distance} km");
        }

        public override void Refuel(double amount)
        {
            Fuel += amount;
        }

        public Car(double fuel, double fuelConsumption, double tankCapacity) : base(fuel, fuelConsumption, tankCapacity)
        {
            FuelConsumption += 0.9;
        }
    }
}