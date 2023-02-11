using Histogram.Constants;
using Histogram.Model;
using Histogram.Services.Interfaces;

namespace Histogram.Services
{
    public class HistogramService : IHistogramService
    {
        public Input CreateInput(IEnumerable<int> numbers)
        {
            int partSize = PartsConstants.MaxNumber / PartsConstants.PartsCount;

            var input = new Input();
            foreach (var number in numbers)
            {
                int numberPart = number / partSize;
                input.NumbersInPart[numberPart]++;
            }

            return input;
        }

        public Model.Histogram CreateHistogram(Input input)
        {
            var histogram = new Model.Histogram();
            for (int i = 0; i < PartsConstants.PartsCount; i++)
            {
                histogram.PartPercents[i] = (double)input.NumbersInPart[i] / input.NumbersCount * 100;
            }

            return histogram;
        }
    }
}
