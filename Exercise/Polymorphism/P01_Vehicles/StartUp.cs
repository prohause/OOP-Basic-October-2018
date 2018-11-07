using System;
using System.Linq;

namespace P01_Vehicles
{
    public class StartUp
    {
        private static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(" ").Skip(1).Select(double.Parse).ToList();
            var myCar = new Car(tokens[0], tokens[1]);
            tokens = Console.ReadLine().Split(" ").Skip(1).Select(double.Parse).ToList();
            var myTruck = new Truck(tokens[0], tokens[1]);

            var lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split(" ");
                var command = input[0];
                var vehicleType = input[1];

                if (command == "Drive")
                {
                    var distance = double.Parse(input[2]);
                    if (vehicleType == "Car")
                    {
                        myCar.Drive(distance);
                    }
                    else
                    {
                        myTruck.Drive(distance);
                    }
                }
                else
                {
                    var amount = double.Parse(input[2]);
                    if (vehicleType == "Car")
                    {
                        myCar.Refuel(amount);
                    }
                    else
                    {
                        myTruck.Refuel(amount);
                    }
                }
            }

            Console.WriteLine($"Car: {myCar.Fuel:F2}");
            Console.WriteLine($"Truck: {myTruck.Fuel:F2}");
        }
    }
}