using System;
using System.Collections.Generic;
using System.Text;

namespace Piratage
{
    class Pirate
    {
        private long nbEssais;
        private string motPasse;
        private long compteur;
        private int niveauSecuriteTest;

        public Pirate()
        {
            nbEssais = 0;
            compteur = 0;
        }

        public void PiraterRouteur(Routeur routeur, int niveauSecuriteTest)
        {
            while (routeur.Connexion(motPasse) == false)
            {

            }
        }

        public long GetNbEssais()
        {

        }

        public long GetNbPossibilitesMax()
        {

        }

        public string GetMotPasse()
        {

        }

        public long GetCompteur()
        {
            compteur++;
            return compteur;
        }
    }
}
