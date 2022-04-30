using System;
using System.Collections.Generic;
using System.Text;

namespace Bat_Gadgets
{
    class BatVehicule
    {
        private List<BatGadgetVehicule> batGadgets;
        private string description;


        public BatVehicule(string nom)
        {
            Console.WriteLine("Constructeur   : BatVehicule");
            batGadgets = new List<BatGadgetVehicule>();
            this.description = nom;
        }

        public void SetBatGadget(BatGadgetVehicule lui)
        {
            batGadgets.Add(lui);  
        }


        public void GetDescription()
        {
            Console.WriteLine(description);
        }
    }
}
