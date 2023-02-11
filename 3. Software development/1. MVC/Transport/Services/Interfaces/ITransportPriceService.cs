namespace Transport.Services.Interfaces
{
    public interface ITransportPriceService
    {
        double GetBestTransportPrice(int km, string dayOrNight);
    }
}
