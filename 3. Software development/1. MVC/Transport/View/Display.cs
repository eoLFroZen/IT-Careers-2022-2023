using Transport.View.Interfaces;

namespace Transport.View
{
    public class Display : IDisplay
    {
        public (int km, string dayOrNight) ReadInput()
        {
            int km = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            return (km, dayOrNight);
        }

        public void PrintBestPrice(double bestPrice)
        {
            Console.WriteLine(bestPrice);
        }
    }
}
