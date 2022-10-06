using VehiclesV2.Interfaces;

namespace VehiclesV2.Vehicles
{
    public abstract class Vehicle : IFuel, IDrivable
    {
        public double FuelQuantity { get; protected set; }

        public double LitersPerKm { get; protected set; }

        private readonly double airConditionerFuelPerKm;

        private readonly string vehicleType;

        public Vehicle(double fuelQuantity, double litersPerKm, double airConditionerFuelPerKm, string vehicleType)
        {
            FuelQuantity = fuelQuantity;
            LitersPerKm = litersPerKm;
            this.airConditionerFuelPerKm = airConditionerFuelPerKm;
            this.vehicleType = vehicleType;
        }

        public virtual void Refuel(double quantity)
        {
            FuelQuantity += quantity;
        }

        public string Drive(double distance)
        {
            double neededFuel = (LitersPerKm + airConditionerFuelPerKm) * distance;

            if (neededFuel <= FuelQuantity)
            {
                FuelQuantity -= neededFuel;
                return $"{vehicleType} travelled {distance} km";
            }

            return $"{vehicleType} needs refueling";
        }

        public string GetVehicleWithFuelQuantity()
        {
            return $"{vehicleType}: {FuelQuantity:F2}";
        }
    }
}
