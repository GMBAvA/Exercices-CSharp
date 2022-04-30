using System;
using System.Collections.Generic;
using System.Text;

namespace L_Arche_de_Noé
{
    class Elephant
    {
        private string nom;
        private int vitesse;


        public Elephant(string _nom, int _vitesse)
        {
            nom = _nom;
            vitesse = _vitesse;
        }

        public int GetVitesse()
        {
            return vitesse;
        }

        public string GetNom()
        {
            return nom;
        }

        public void Accelerer(int _variation)
        {
            while (vitesse != 100)
            {
                vitesse += _variation;
            }
            
        }

        public void Decelerer(int _variation)
        {
            while (vitesse != 0)
            {
                vitesse -= _variation;
            }
            
        }
    }
}
