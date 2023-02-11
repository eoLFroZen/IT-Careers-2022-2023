namespace Transport.View.Interfaces
{
    public interface IDisplay
    {
        (int km, string dayOrNight) ReadInput();

        void PrintBestPrice(double bestPrice);
    }
}
