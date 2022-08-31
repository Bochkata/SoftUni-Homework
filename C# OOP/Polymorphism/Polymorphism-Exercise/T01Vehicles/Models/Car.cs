

using System;

namespace T01Vehicles
{
    public class Car: Vehicle
    {
        private const double airConditionersConsumption = 0.9;
        public Car(double fuelQuantity, double fuelConsumptionPerKm) : base(fuelQuantity, fuelConsumptionPerKm)
        {
        }

        protected override double AirConditionersConsumption => airConditionersConsumption;

       
    }
}
