namespace Histogram.View.Interfaces
{
    public interface IDisplay
    {
        public IEnumerable<int> ReadNumbers();

        public void PrintHistogram(Model.Histogram histogram);
    }
}
