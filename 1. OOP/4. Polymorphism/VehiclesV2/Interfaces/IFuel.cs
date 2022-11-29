namespace VehiclesV2.Interfaces
{
    public interface IFuel
    {
        double FuelQuantity { get; }

        double LitersPerKm { get; }

        void Refuel(double quantity);
    }
}
