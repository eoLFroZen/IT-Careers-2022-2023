namespace Transport.Model
{
    public class Taxi : Vehicle
    {
        public Taxi()
            : base(
                  Constants.TaxiInitialPrice,
                  Constants.TaxiDayPrice,
                  Constants.TaxiNightPrice,
                  Constants.TaxiMinKm)
        { }
    }
}
