


using System;

namespace T02VehiclesExtension
{
    public class Truck : Vehicle
    {
        private const double airConditionerConsumption = 1.6;

        public Truck(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) : base(fuelQuantity,
            fuelConsumptionPerKm, tankCapacity)
        {
            AirConditionersConsumption = airConditionerConsumption;
        }

        protected override double AirConditionersConsumption { get; set; }

        public override double Refuel(double amountOfFuel)
        {
            
            base.Refuel(amountOfFuel);
            return FuelQuantity -= 0.05 * amountOfFuel;

        }
    }

}
