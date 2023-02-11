using Histogram.Model;

namespace Histogram.Services.Interfaces
{
    public interface IHistogramService
    {
        Input CreateInput(IEnumerable<int> numbers);

        Model.Histogram CreateHistogram(Input input);
    }
}
