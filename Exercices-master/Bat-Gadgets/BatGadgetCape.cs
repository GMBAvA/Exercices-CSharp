using System;
using System.Collections.Generic;
using System.Text;

namespace Bat_Gadgets
{
    class BatGadgetCape : BatGadget
    {
        public BatGadgetCape(string nom) : base (nom)
        {
            Console.WriteLine("Constructeur   : BatGadgetCape");
        }
    }
}
