using Histogram.Constants;

namespace Histogram.Model
{
    public class Input
    {
        public int[] NumbersInPart { get; set; }

        public Input()
        {
            NumbersInPart = new int[PartsConstants.PartsCount];
        }

        public int NumbersCount
            => NumbersInPart.Sum();
    }
}
