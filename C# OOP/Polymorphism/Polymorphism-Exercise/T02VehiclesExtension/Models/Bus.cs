using System;
using System.Collections.Generic;
using System.Text;

namespace T02VehiclesExtension.Models
{
    public class Bus :Vehicle
    {
        private const double airConditionerConsumption = 1.4;
        public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
        {
            AirConditionersConsumption = airConditionerConsumption;
        }

        protected override double AirConditionersConsumption { get; set; }

        public void DriveEmpty(double distance)
        {
            AirConditionersConsumption = 0;
            double leftFuel = FuelQuantity - (FuelConsumptionPerKm + AirConditionersConsumption) * distance;

            if (leftFuel < 0)
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
            else
            {
                FuelQuantity -= (FuelConsumptionPerKm + AirConditionersConsumption) * distance;
                Console.WriteLine($"{GetType().Name} travelled {distance} km");
            }
        }
    }
}
