namespace MiningSystem
{
    public class ElectricityProvider : Provider
    {
        public ElectricityProvider(string id, double energyOutput) 
            : base(id, energyOutput * 1.5, "Electricity") { }
    }
}
