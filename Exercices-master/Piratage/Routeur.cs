using System;
using System.Collections.Generic;
using System.Text;

namespace Piratage
{
    class Routeur
    {
        private int niveauSecurite;
        private string motPasse;
        Random random;

        public Routeur(int _niveauSecurite, bool _alphanumérique)
        {
            string lettres = "azertyuiopqsdfghjklmwxcvbn";
            string nb = "0123456789";
            niveauSecurite = _niveauSecurite;
            random = new Random();
            for (int i = 0; i < 6; i++)
            {
                char nombre = nb[random.Next(0, nb.Length)];
                char carac = lettres[random.Next(0, lettres.Length)];
                if (_alphanumérique == true)
                {
                    carac = char.ToUpper(carac);
                    nb = char.ToString(carac);
                }
                else
                {
                    carac = char.ToUpper(carac);
                }
                motPasse += carac;
            }
            Console.WriteLine(motPasse);
        }

        public bool Connexion (string _motPasse)
        {
            if (_motPasse == this.motPasse)
            {
                return true;
            }
            else
                return false;

        }
    }
}
