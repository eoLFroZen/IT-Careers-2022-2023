using System.Text;

namespace MiningSystem
{
    public class Provider
    {
        private double energyOutput;
        private string type;

        public Provider(string id, double energyOutput, string type)
        {
            Id = id;
            EnergyOutput = energyOutput;
            this.type = type;
        }

        public string Id { get; set; }

        public double EnergyOutput
        {
            get { return energyOutput; }
            private set
            {
                if (value < 0 || value > 10_000)
                {
                    throw new ArgumentException(nameof(EnergyOutput));
                }

                energyOutput = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"{type} Provider - {Id}");
            builder.AppendLine($"Energy Output: {EnergyOutput}");

            return builder.ToString().TrimEnd();
        }
    }
}
