using System;
using System.Collections.Generic;
using System.Text;

namespace L_Arche_de_Noé
{
    class Girafe
    {
        private int hauteur;
        private string nom;

        public Girafe(string _nom, int _hauteur)
        {
            nom = _nom;
            hauteur = _hauteur;
        }

        public string GetNom()
        {
            return nom;
        }

        public int GetHauteur()
        {
            return hauteur;
        }

        public bool PasDansLeCadrageDeLaPorte(int _hauteurMax)
        {
            int hauteurMax = _hauteurMax;

            if (hauteur > hauteurMax)
            {
                Console.WriteLine(nom + ", baisse toi !");
                return true;
            }
            else
                return false;
            
        }
    }
}
