using System;

namespace P01_Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuel, double fuelConsumption) : base(fuel, fuelConsumption)
        {
            FuelConsumption += 1.6;
        }

        public override void Drive(double distance)
        {
            var fuelNeeded = distance * FuelConsumption;
            if (fuelNeeded > Fuel)
            {
                Console.WriteLine("Truck needs refueling");
                return;
            }

            Fuel -= fuelNeeded;
            Distance += distance;
            Console.WriteLine($"Truck travelled {distance} km");
        }

        public override void Refuel(double amount)
        {
            Fuel += amount * 0.95;
        }
    }
}