using System.Text;

namespace MiningSystem
{
    public class SystemManager
    {
        private double totalStoredEnergy;
        private double totalMinedCoal;

        private List<Miner> miners;
        private List<Provider> providers;

        public SystemManager()
        {
            this.miners = new List<Miner>();
            this.providers = new List<Provider>();
        }

        public string RegisterMiner(List<string> arguments)
        {
            string type = arguments[0];
            string id = arguments[1];
            double coalOutput = double.Parse(arguments[2]);
            double energyRequirement = double.Parse(arguments[3]);

            try
            {
                if (type == "Driller")
                {
                    miners.Add(new Driller(id, coalOutput, energyRequirement));
                }
                else
                {
                    int enduranceFactor = int.Parse(arguments[4]);
                    Hewer hewer = new Hewer(id, coalOutput, energyRequirement, enduranceFactor);
                    miners.Add(hewer);
                }

                return $"Successfully registered {type} Miner - {id}";
            }
            catch (ArgumentException ex)
            {
                return $"Miner is not registered, because of it's {ex.Message}";
            }

        }
        public string RegisterProvider(List<string> arguments)
        {
            string type = arguments[0];
            string id = arguments[1];
            double energyOutput = double.Parse(arguments[2]);
            try
            {
                if (type == "Sun")
                {
                    providers.Add(new SunProvider(id, energyOutput));
                }
                else
                {
                    providers.Add(new ElectricityProvider(id, energyOutput));
                }

                return $"Successfully registered {type} Provider - {id}";
            }
            catch (ArgumentException ex)
            {
                return $"Provider is not registered, because of it's {ex.Message}";
            }
        }
        public string Day()
        {
            double collectedEnergy = providers.Sum(p => p.EnergyOutput);
            totalStoredEnergy += collectedEnergy;

            double requiredEnergyToMine = miners.Sum(m => m.EnergyRequirement);
            double collectedCoal = 0;

            if (requiredEnergyToMine < totalStoredEnergy)
            {
                totalStoredEnergy -= requiredEnergyToMine;
                collectedCoal = miners.Sum(m => m.CoalOutput);
                totalMinedCoal += collectedCoal;
            }

            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"A day has passed.");
            builder.AppendLine($"Energy Provided: {collectedEnergy}");
            builder.AppendLine($"Mined Coal: {collectedCoal}");

            return builder.ToString().TrimEnd();

        }
        public string Check(List<string> arguments)
        {
            string id = arguments[0];

            Miner miner = miners.FirstOrDefault(m => m.Id == id);

            if (miner != null)
            {
                return miner.ToString();
            }

            Provider provider = providers.FirstOrDefault(m => m.Id == id);

            if (provider != null)
            {
                return provider.ToString();
            }

            return $"No element found with id - {id}";
        }
        public string ShutDown()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"System Shutdown");
            builder.AppendLine($"Total Energy Stored: {totalStoredEnergy}");
            builder.AppendLine($"Total Mined Coal: {totalMinedCoal}");


            return builder.ToString().TrimEnd();
        }

    }
}
