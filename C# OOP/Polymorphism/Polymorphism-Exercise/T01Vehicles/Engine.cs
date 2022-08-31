

using System;


namespace T01Vehicles
{
    public class Engine
    {
        public string[] CarInput { get; set; }
        public string[] TruckInput { get; set; }

        public void Run()
        {
            CarInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            TruckInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double carFuelQnty = double.Parse(CarInput[1]);
            double carFuelConsumption = double.Parse(CarInput[2]);
            double truckFuelQnty = double.Parse(TruckInput[1]);
            double truckFuelConsumption = double.Parse(TruckInput[2]);

            Car car = new Car(carFuelQnty, carFuelConsumption);
            Truck truck = new Truck(truckFuelQnty, truckFuelConsumption);

            int numbeOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbeOfCommands; i++)
            {

                string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "Drive")
                {
                    double distance = double.Parse(commands[2]);
                    if (commands[1] == nameof(Car))
                    {
                        car.Drive(distance);
                    }
                    else if (commands[1] == nameof(Truck))
                    {
                        truck.Drive(distance);
                    }

                }
                else if (commands[0] == "Refuel")
                {
                    double refuelQuantity = double.Parse(commands[2]);
                    if (commands[1] == nameof(Car))
                    {
                        car.Refuel(refuelQuantity);
                    }
                    else if (commands[1] == nameof(Truck))
                    {
                        truck.Refuel(refuelQuantity);
                    }
                }

            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            
        }

    }

}

