namespace VehiclesV2.Vehicles
{
    public class Truck : Vehicle
    {
        private const double airConditionerFuelPerKm = 1.6;
        private const double refuelRate = 0.95;

        public Truck(double fuelQuantity, double litersPerKm)
            : base(fuelQuantity, litersPerKm, airConditionerFuelPerKm, "Truck")
        {
        }

        public override void Refuel(double quantity)
        {
            FuelQuantity += refuelRate * quantity;
        }
    }
}
