using System;
using System.Collections.Generic;
using System.Text;

namespace Réchauffement
{
    class De
    {
        private int valeur;
        private int nbFaces;
        private Random md = new Random();

        public void Initialiser(int _nbFaces)
        {
            nbFaces = _nbFaces;
            LancerDe();
        }
        
        public void LancerDe()
        {
            valeur = md.Next(1, nbFaces + 1);
        }

        public int GetValeur()
        {
            return valeur;
        }
    }
}
