

using System;

namespace T02VehiclesExtension
{
    public class Car: Vehicle
    {
        private const double airConditionersConsumption = 0.9;
        public Car(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
        {
            AirConditionersConsumption = airConditionersConsumption;
        }

        protected override double AirConditionersConsumption { get; set; }
    }

       
    }

