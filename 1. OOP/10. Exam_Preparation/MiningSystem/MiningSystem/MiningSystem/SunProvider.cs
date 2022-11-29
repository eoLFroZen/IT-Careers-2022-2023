namespace MiningSystem
{
    public class SunProvider : Provider
    {
        public SunProvider(string id, double energyOutput) 
            : base(id, energyOutput * 1.25, "Sun") { }
    }
}
