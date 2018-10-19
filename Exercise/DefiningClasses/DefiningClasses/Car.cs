using System;

namespace DefiningClasses
{
    internal class Car
    {
        private string _model;
        private double _fuelAmount;
        private double _fuelConsumption;
        private double _traveledDistance;

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            Model = model;
            _fuelAmount = fuelAmount;
            _fuelConsumption = fuelConsumption;
            _traveledDistance = 0;
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        public void Drive(double distance)
        {
            if (distance * _fuelConsumption <= _fuelAmount)
            {
                _traveledDistance += distance;
                _fuelAmount -= _fuelConsumption * distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{Model} {_fuelAmount:F2} {_traveledDistance:F0}";
        }
    }
}