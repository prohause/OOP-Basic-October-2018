namespace P01_Vehicles
{
    public abstract class Vehicle
    {
        public double Fuel
        {
            get; set;
        }

        public double FuelConsumption
        {
            get; set;
        }

        public double Distance
        {
            get; set;
        }

        protected Vehicle(double fuel, double fuelConsumption)
        {
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            Distance = 0;
        }

        public abstract void Drive(double distance);

        public abstract void Refuel(double amount);
    }
}