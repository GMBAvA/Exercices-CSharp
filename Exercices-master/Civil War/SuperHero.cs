using System;
using System.Collections.Generic;
using System.Text;

namespace Civil_War
{
    class SuperHero
    {
        private string nom;
        private string superPouvoir;

        public SuperHero(string nom, string superPouvoir)
        {
            this.nom = nom;
            this.superPouvoir = superPouvoir;
            Console.WriteLine("Constructeur : Super Héro");
        }

        public string GetNom()
        {
            return nom;
        }

        public string GetSuperPouvoir()
        {
            return "(" + superPouvoir + ")";
        }
    }
}
