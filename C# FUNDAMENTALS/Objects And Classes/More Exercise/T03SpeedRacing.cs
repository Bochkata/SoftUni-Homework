using System;
using System.Collections.Generic;

namespace T03SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Car> allCars = new List<Car>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string currentCarModel = input[0];
                double currentFuelAmount = double.Parse(input[1]);
                double currentFuelConsumptionPerKm = double.Parse(input[2]);

                Car newCar = new Car();
                {
                    newCar.Model = currentCarModel;
                    newCar.FuelAmount = currentFuelAmount;
                    newCar.FuelConsumptionPerKm = currentFuelConsumptionPerKm;
                    newCar.TravelDistance = 0;
                }
                allCars.Add(newCar);
            }

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "End")
            {

                string[] subcommands = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentModel = subcommands[1];
                int currentDistanceToTravelInKm = int.Parse(subcommands[2]);

                Car currentCar = allCars.Find(x => x.Model == currentModel);

                if (currentCar.CanMove(currentCar.FuelAmount, currentCar.FuelConsumptionPerKm, currentDistanceToTravelInKm))
                {
                    currentCar.FuelAmount -= currentCar.FuelConsumptionPerKm * currentDistanceToTravelInKm;
                    currentCar.TravelDistance += currentDistanceToTravelInKm;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                
            }

            foreach (Car car in allCars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelDistance}");
            }

        }
        class Car
        {
            public string Model { get; set; }
            public double FuelAmount { get; set; }
            public double FuelConsumptionPerKm { get; set; }
            public int TravelDistance { get; set; }

            public bool CanMove(double fuelAmount, double consumptionKM, double distance)
            {
                double result = fuelAmount - (consumptionKM * distance);
                if (result >= 0)
                {
                    return true;
                }

                return false;
            }

        }
    }
}
