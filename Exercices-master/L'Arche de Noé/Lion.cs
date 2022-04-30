using System;
using System.Collections.Generic;
using System.Text;

namespace L_Arche_de_Noé
{
    class Lion
    {
        private string nom;
        private int poids;
        private bool male;

        public Lion(string _nom, bool _male, int _poids)
        {
            nom = _nom;
            male = _male;
            poids = _poids;
        }

        public string GetNom()
        {
            return nom;
        }

        public int GetPoids()
        {
            return poids;
        }

        public bool IsMale()
        {
            if (male == true)
            {
                ChangerSexe();
            }
            return male;
        }

        public void ChangerSexe()
        {
            if (nom == "Nala")
            {
                male = false;
            }
            else
                male = true;
        }
    }
}
