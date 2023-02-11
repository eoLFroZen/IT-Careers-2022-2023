using System.Text;

namespace Histogram.Model
{
    public class Histogram
    {
        public static int PartsCount = 5;

        public double[] PartPercents { get; set; }

        public Histogram()
        {
            PartPercents = new double[PartsCount];
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var partPercent in PartPercents)
            {
                stringBuilder.AppendLine($"{partPercent:f2}%");
            }

            return stringBuilder.ToString();
        }
    }
}
