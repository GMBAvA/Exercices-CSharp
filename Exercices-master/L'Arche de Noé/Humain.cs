using System;
using System.Collections.Generic;
using System.Text;

namespace L_Arche_de_Noé
{
    class Humain
    {
        private string nom;
        private char genre;
        private bool capitaine;

        public Humain(string _nom, char _genre)
        {
            nom = _nom;
            genre = _genre;
        }

        public string GetNom()
        {
            return nom;
        }

        public char GetGenre()
        {
            return genre;
        }

        public bool IsCapitaine()
        {
            if (genre == 'H')
            {
                capitaine = true;
            }
            return capitaine;
        }
    }
}
