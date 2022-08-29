using System;
using System.Collections.Generic;
using System.Linq;

namespace T06VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Car> allCars = new List<Car>();
            List<Truck> allTrucks = new List<Truck>();

            int countOfCars = 0;
            int countOfTrucks = 0;

            double carAverageHorsePower = 0;
            double carTotalHorsePower = 0;
            double truckAverageHorsePower = 0;
            double truckTotalHorsePower = 0;

            while (command != "End")
            {
                string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string typeOfVehicle = input[0];
                string model = input[1];
                string color = input[2];
                int horsePower = int.Parse(input[3]);

                if (typeOfVehicle == "car")
                {
                    countOfCars++;
                    Car car = new Car();
                    {
                        car.CarType = typeOfVehicle;
                        car.CarModel = model;
                        car.CarColor = color;
                        car.CarHorsePower = horsePower;
                    }
                    carTotalHorsePower += horsePower;
                    carAverageHorsePower = carTotalHorsePower / countOfCars;

                    allCars.Add(car);
                }
                else if (typeOfVehicle == "truck")
                {
                    countOfTrucks++;
                    Truck truck = new Truck();
                    {
                        truck.TruckType = typeOfVehicle;
                        truck.TruckModel = model;
                        truck.TruckColor = color;
                        truck.TruckHorsePower = horsePower;

                    }
                    truckTotalHorsePower += horsePower;
                    truckAverageHorsePower = truckTotalHorsePower / countOfTrucks;
                    allTrucks.Add(truck);
                }

                command = Console.ReadLine();

            }
            

            string newCommand = Console.ReadLine();

            while (newCommand != "Close the Catalogue")
            {
                if (allCars.Any(unit => unit.CarModel == newCommand))
                {
                    Car currentCar = allCars.First(car => car.CarModel == newCommand);
                    Console.WriteLine("Type: Car");
                    Console.WriteLine($"Model: {newCommand}");
                    Console.WriteLine($"Color: {currentCar.CarColor}");
                    Console.WriteLine($"Horsepower: {currentCar.CarHorsePower}");

                }
                else if (allTrucks.Any(unit => unit.TruckModel == newCommand))
                {
                    Truck currentTruck = allTrucks.First(truck => truck.TruckModel == newCommand);
                    Console.WriteLine("Type: Truck");
                    Console.WriteLine($"Model: {newCommand}");
                    Console.WriteLine($"Color: {currentTruck.TruckColor}");
                    Console.WriteLine($"Horsepower: {currentTruck.TruckHorsePower}");
                }

                newCommand = Console.ReadLine();
            }

            Console.WriteLine($"Cars have average horsepower of: {carAverageHorsePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAverageHorsePower:f2}.");
           
        }
        class Car
        {
            public string CarType { get; set; }
            public string CarModel { get; set; }
            public string CarColor { get; set; }
            public int CarHorsePower { get; set; }
        }
        class Truck
        {
            public string TruckType { get; set; }
            public string TruckModel { get; set; }
            public string TruckColor { get; set; }
            public int TruckHorsePower { get; set; }
        }
    }
}
