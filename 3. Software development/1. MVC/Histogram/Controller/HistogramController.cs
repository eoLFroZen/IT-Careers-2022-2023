using Histogram.Controller.Interfaces;
using Histogram.Services.Interfaces;
using Histogram.View.Interfaces;

namespace Histogram.Controller
{
    public class HistogramController : IHistogramController
    {
        private readonly IDisplay display;
        private readonly IHistogramService histogramService;

        public HistogramController(
            IDisplay display,
            IHistogramService histogramService)
        {
            this.display = display;
            this.histogramService = histogramService;
        }

        public void CreateHistogram()
        {
            var numbers = display.ReadNumbers();
            var input = histogramService.CreateInput(numbers);
            var histogram = histogramService.CreateHistogram(input);
            display.PrintHistogram(histogram);
        }
    }
}
