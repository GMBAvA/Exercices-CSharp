using System;
using System.Collections.Generic;
using System.Text;

namespace Les_Justiciers_Masqués
{
    class Candidat
    {

        public string surnom;
        public string nom;
        public string atout;
        public bool selectionne;
        public void Initialiser(string _surnom, string _nom, string _atout)
        {
            surnom = _surnom;
            nom = _nom;
            atout = _atout;
            selectionne = false;
        }
        public void Afficher()
        {
            Console.WriteLine("Surnom             : " + surnom);
            Console.WriteLine("Nom                : " + nom);
            Console.WriteLine("Atout              : " + atout);
        }
        public void Accepter()
        {
            selectionne = true;
        }

        public void Refuser()
        {
            selectionne = false;
        }

        public bool EstSelectionne()
        {
            
            return selectionne;
        }

        public string GetSurnom()
        {
            return surnom;
        }
    }
}
