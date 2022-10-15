namespace MiningSystem
{
    public class Driller : Miner
    {
        private const int EnergyMultiplier = 2;
        private const int CoalMultiplier = 3;

        public Driller(string id, double coalOutput, double energyRequirement)
            : base(id, coalOutput * CoalMultiplier, energyRequirement * EnergyMultiplier, nameof(Driller)) { }
    }
}
