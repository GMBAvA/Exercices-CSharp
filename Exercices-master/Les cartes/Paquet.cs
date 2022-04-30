using System;
using System.Collections.Generic;

namespace Carte
{
    class Paquet
    {
        private Stack<Carte> pileCartes;

        public Paquet(bool melanger = false)
        {
            pileCartes = new Stack<Carte>();
            if (melanger)
                PilerCartes(GenererCartesAleatoire());
            else
                PilerCartes(GenererCartes());
        }

        private Carte[] GenererCartes()
        {
            Carte[] cartes = new Carte[54];

            cartes[0] = new Carte();
            cartes[1] = new Carte();
            int position = 2;
            for (int v = 1; v <= 13; v++)
                foreach (Carte.TYPE_CARTE typeCarte in Enum.GetValues(typeof(Carte.TYPE_CARTE)))
                    cartes[position++] = new Carte(v, typeCarte);
            return cartes;
        }

        private Carte[] GenererCartesAleatoire()
        {
            Carte[] cartes = GenererCartes();
            Random random = new Random();

            for (int nbPermutations = 0; nbPermutations < 1000000; nbPermutations++)
                PermuterCartes(cartes, random.Next(0, 54), random.Next(0, 54));

            return cartes;
        }

        private void PermuterCartes(Carte[] cartes, int posCarte1, int posCarte2)
        {
            // TODO : Rechercher comment faire une permutation sur Google au besoin (en anglais : swap)
            // Il y a seulement 3 lignes de code à écrire
            int swap = posCarte1;
            posCarte1 = posCarte2;
            posCarte2 = swap;
        }

        private void PilerCartes(Carte[] cartes)
        {
            foreach (Carte carte in cartes)
                pileCartes.Push(carte);
        }

        public Carte Piger()
        {
            return pileCartes.Pop();
        }

        public bool EstVide()
        {
            return pileCartes.Count == 0;
        }
    }
}
