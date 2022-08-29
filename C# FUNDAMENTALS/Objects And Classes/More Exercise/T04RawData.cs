using System;
using System.Collections.Generic;
using System.Linq;

namespace T04RawData
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
                int currentEngineSpeed = int.Parse(input[1]);
                int currentEnginePower = int.Parse(input[2]);
                int currentCargoWeight = int.Parse(input[3]);
                string currentCargoType = input[4];

                Engine currentEngine = new Engine();
                {
                    currentEngine.EngineSpeed = currentEngineSpeed;
                    currentEngine.EnginePower = currentEnginePower;
                }
                Cargo currentCargo = new Cargo();
                {
                    currentCargo.CargoType = currentCargoType;
                    currentCargo.CargoWeight = currentCargoWeight;

                }
                Car currentCar = new Car();
                {
                    currentCar.CarModel = currentCarModel;
                    currentCar.Cargo = currentCargo;
                    currentCar.Engine = currentEngine;
                    
                }
                allCars.Add(currentCar);
                
            }

            string finalCommand = Console.ReadLine();

            switch (finalCommand)
            {
                case "fragile":
                    foreach (Car car in allCars.Where(x=>x.Cargo.CargoType == finalCommand).Where(y=>y.Cargo.CargoWeight<1000))
                    {
                        
                        Console.WriteLine(car.CarModel);
                    }
                    break;


                case "flamable":
                    foreach (Car car in allCars.Where(x => x.Cargo.CargoType == finalCommand).Where(y => y.Engine.EnginePower > 250))
                    {
                        Console.WriteLine(car.CarModel);
                    }
                    break;
            }
            
        }
        class Car
        {
            public Car()
            {
                
                Engine = new Engine();
                Cargo = new Cargo();
            }

            public string CarModel { get; set; }
            public Engine Engine { get; set; }
            public Cargo Cargo { get; set; }
        }
        class Cargo
        {
            public string CargoType { get; set; }
            public int CargoWeight { get; set; }

        }
        class Engine
        {
            public int EngineSpeed { get; set; }
            public int EnginePower { get; set; }
        }
    }
}
