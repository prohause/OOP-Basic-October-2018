using System;

namespace P01_Vehicles
{
    public abstract class Vehicle
    {
        private double _fuel;

        public double Fuel
        {
            get => _fuel;
            set
            {
                if (value + Fuel > TankCapacity)
                {
                    Console.WriteLine($"Cannot fit {value} fuel in the tank");
                    return;
                }

                _fuel += value;
            }
        }

        public double FuelConsumption
        {
            get; set;
        }

        public double Distance
        {
            get; set;
        }

        public double TankCapacity
        {
            get; set;
        }

        protected Vehicle(double fuel, double fuelConsumption, double tankCapacity)
        {
            if (fuel > tankCapacity)
            {
                Fuel = 0;
            }
            else
            {
                Fuel = fuel;
            }
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            Distance = 0;
            TankCapacity = tankCapacity;
        }

        public abstract void Drive(double distance);

        public abstract void Refuel(double amount);
    }
}