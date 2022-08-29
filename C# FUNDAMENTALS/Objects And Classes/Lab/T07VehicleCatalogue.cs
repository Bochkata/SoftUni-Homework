using System;
using System.Collections.Generic;
using System.Linq;


namespace T07VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split("/", StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<Car> allCars = new List<Car>();
            List<Truck> allTrucks = new List<Truck>();


            while (input[0] != "end")
            {

                if (input[0] == "Car")
                {
                    Car car = new Car();
                    {
                        car.CarBrand = input[1];
                        car.CarModel = input[2];
                        car.CarHorsePower = input[3];

                    }
                    allCars.Add(car);

                }
                else if (input[0] == "Truck")
                {
                    Truck truck = new Truck();
                    {
                        truck.TruckBrand = input[1];
                        truck.TruckModel = input[2];
                        truck.TruckWeight = input[3];

                    }
                    allTrucks.Add(truck);

                }

                input = Console.ReadLine().Split("/", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            allCars = allCars.OrderBy(unit => unit.CarBrand).ToList();
            allTrucks = allTrucks.OrderBy(unit => unit.TruckBrand).ToList();

            List<string> carsPrint = new List<string>();
            List<string> trucksprint = new List<string>();

            if (allCars.Count > 0)
            {
                foreach (Car car in allCars)
                {
                    string carsToPrint = $"{car.CarBrand}: {car.CarModel} - {car.CarHorsePower}hp";
                    carsPrint.Add(carsToPrint);

                }

                Console.WriteLine("Cars:");
                Console.WriteLine(String.Join("\n", carsPrint));
            }

            if (allTrucks.Count > 0)
            {
                foreach (Truck truck in allTrucks)
                {

                    string trucksToPrint = $"{truck.TruckBrand}: {truck.TruckModel} - {truck.TruckWeight}kg";
                    trucksprint.Add(trucksToPrint);
                }

                Console.WriteLine("Trucks:");
                Console.WriteLine(String.Join("\n", trucksprint));
            }
        }
        class Car
        {
            public string CarBrand { get; set; }
            public string CarModel { get; set; }
            public string CarHorsePower { get; set; }
        }
        class Truck
        {
            public string TruckBrand { get; set; }
            public string TruckModel { get; set; }
            public string TruckWeight { get; set; }
        }
        class Catalog
        {
            public Catalog()
            {
                Car newCar = new Car();
                Truck newTruck = new Truck();
            }
            public List<Car> Cars { get; set; }
            public List<Truck> Trucks { get; set; }
        }
    }
}
