using System;

namespace D06_P05
{
    public class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            float kilometeres = meters / 1000f;
            float miles = meters / 1609f;

            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float totalHours = hours + (minutes / 60f) + (seconds / 60f / 60f);
            float totalSeconds = hours * 60 * 60 + minutes * 60f + seconds;

            // S = V * t;
            // V = S / t;

            Console.WriteLine(meters / totalSeconds);
            Console.WriteLine(kilometeres / totalHours);
            Console.WriteLine(miles / totalHours);
        }
    }
}
