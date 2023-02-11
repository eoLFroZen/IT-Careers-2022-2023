using Histogram.View.Interfaces;

namespace Histogram.View
{
    public class Display : IDisplay
    {
        public IEnumerable<int> ReadNumbers()
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int[] numbers = new int[numbersCount];
            for (int i = 0; i < numbersCount; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            return numbers;
        }

        public void PrintHistogram(Model.Histogram histogram)
        {
            Console.WriteLine(histogram);
        }
    }
}
