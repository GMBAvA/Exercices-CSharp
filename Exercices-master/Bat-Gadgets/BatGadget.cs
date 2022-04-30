using System;
using System.Collections.Generic;
using System.Text;

namespace Bat_Gadgets
{
    class BatGadget
    {
        private string nom;
        public BatGadget(string nom)
        {
            this.nom = nom;
            Console.WriteLine("Constructeur   : BatGadget");
        }

        public string GetNom()
        {
            return nom;
        }
    }
}
