using System.Text;

namespace MiningSystem
{
    public abstract class Miner
    {
        private double coalOutput;
        private double energyRequirement;
        private string type;

        protected Miner(string id, double coalOutput, double energyRequirement, string type)
        {
            Id = id;
            CoalOutput = coalOutput;
            EnergyRequirement = energyRequirement;
            this.type = type;
        }

        public string Id { get; private set; }


        public double CoalOutput
        {
            get { return coalOutput; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(nameof(CoalOutput));
                }

                coalOutput = value;
            }
        }

        public double EnergyRequirement
        {
            get { return energyRequirement; }
            protected set
            {
                if (value < 0 || value > 20_000)
                {
                    throw new ArgumentException(nameof(EnergyRequirement));
                }

                energyRequirement = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"{type} Miner - {Id}");
            builder.AppendLine($"Coal Output: {CoalOutput}");
            builder.AppendLine($"Energy Requirement: {EnergyRequirement}");

            return builder.ToString().TrimEnd();
        }
    }
}
