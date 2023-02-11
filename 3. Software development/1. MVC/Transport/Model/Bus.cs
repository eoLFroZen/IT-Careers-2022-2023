namespace Transport.Model
{
    public class Bus : Vehicle
    {
        public Bus()
            : base(
                  Constants.BusInitialPrice,
                  Constants.BusPrice,
                  Constants.BusPrice,
                  Constants.BusMinKm)
        { }
    }
}
