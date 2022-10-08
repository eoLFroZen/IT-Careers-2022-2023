using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Royal_Gumbit
{
    public class Footman : Servant
    {
        public Footman()
        {

        }

        public Footman(string name) : base(name)
        {
        }

        public override void OnKingAttacked(object sender, EventArgs args)
        {
            Console.WriteLine($"Footman {Name} is panicking!");
        }
    }
}
