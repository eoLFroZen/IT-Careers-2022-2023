using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningSystem
{
    public class Hewer : Miner
    {
        private int enduranceFactor;

        public Hewer(string id, double coalOutput, double energyRequirement, int enduranceFactor)
            : base(id, coalOutput, energyRequirement, nameof(Hewer))
        {
            this.enduranceFactor = enduranceFactor;
            EnergyRequirement /= enduranceFactor;
        }
    }
}
