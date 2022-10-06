namespace VehiclesV2.Vehicles
{
    public class Car : Vehicle
    {
        private const double airConditionerFuelPerKm = 0.9;

        public Car(double fuelQuantity, double litersPerKm)
            : base(fuelQuantity, litersPerKm, airConditionerFuelPerKm, "Car")
        {
        }
    }
}
