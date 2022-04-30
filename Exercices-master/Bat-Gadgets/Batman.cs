using System;
using System.Collections.Generic;
using System.Text;

namespace Bat_Gadgets
{

    class Batman
    {
        private List<BatGadgetCape> batGadgets;

        public Batman()
        {
            batGadgets = new List<BatGadgetCape>();
            Console.WriteLine("Constructeur   : Batman");
        }

        public void SetBatGadget(BatGadgetCape lui)
        {
            batGadgets.Add(lui);
        }
    }
}
