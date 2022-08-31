

using System;
using T02VehiclesExtension.Models;


namespace T02VehiclesExtension
{
    public class Engine
    {
        public string[] CarInput { get; set; }
        public string[] TruckInput { get; set; }
        public string[] BusInput { get; set; }

        public void Run()
        {
            CarInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            TruckInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            BusInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double carFuelQnty = double.Parse(CarInput[1]);
            double carFuelConsumption = double.Parse(CarInput[2]);
            double carTankCapacity = double.Parse(CarInput[3]);

            double truckFuelQnty = double.Parse(TruckInput[1]);
            double truckFuelConsumption = double.Parse(TruckInput[2]);
            double truckTankCapacity = double.Parse(TruckInput[3]);

            double busFuelQnty = double.Parse(BusInput[1]);
            double busFuelConsumption = double.Parse(BusInput[2]);
            double busTankCapacity = double.Parse(BusInput[3]);


            Car car = new Car(carFuelQnty, carFuelConsumption, carTankCapacity);
            Truck truck = new Truck(truckFuelQnty, truckFuelConsumption, truckTankCapacity);
            Bus bus = new Bus(busFuelQnty, busFuelConsumption, busTankCapacity);

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
                    else if (commands[1] == nameof(Bus))
                    {
                        bus.Drive(distance);
                    }

                }
                else if (commands[0] == "Refuel")
                {
                    double refuelQuantity = double.Parse(commands[2]);
                    try
                    {
                        if (commands[1] == nameof(Car))
                        {
                            car.Refuel(refuelQuantity);
                        }
                        else if (commands[1] == nameof(Truck))
                        {
                            truck.Refuel(refuelQuantity);
                        }
                        else if (commands[1] == nameof(Bus))
                        {
                            bus.Refuel(refuelQuantity);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                       
                    }
                    
                    
                }
                else if (commands[0] == "DriveEmpty")
                {
                    double distance = double.Parse(commands[2]);
                    bus.DriveEmpty(distance);
                }

            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
            
        }

    }

}

