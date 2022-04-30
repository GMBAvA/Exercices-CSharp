using System;
using System.Collections.Generic;
using System.Text;

namespace Bat_Gadgets
{
    class BatGadgetVehicule : BatGadget
    {
        public BatGadgetVehicule(string nom) : base (nom)
        {
            Console.WriteLine("Constructeur   : BatGadgetVehicule");
        }
    }
}
