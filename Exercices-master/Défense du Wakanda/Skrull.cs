using System;
using System.Collections.Generic;
using System.Text;

namespace Défense_du_Wakanda
{
    class Skrull
    {
        private static readonly int DOMMAGE_MAX = 10;
        private static readonly int POURCENTAGE_TOUCHER = 15;
        private int protection;
        private int pointVie;
        private Random random;

        public Skrull(int _protection, int _pv)
        {
            protection = _protection;
            pointVie = _pv;
            random = new Random();
        }

        public int GetDommage()
        {
            int degats = random.Next(0, DOMMAGE_MAX);
            return degats;
        }

        public bool Touche()
        {
            int chance = random.Next(1, 101);
            if (chance <= POURCENTAGE_TOUCHER)
            {
                return true;
            }
            else
                return false;
        }

        public void SubirDommage(int _dommageEnnemi)
        {
            if (_dommageEnnemi > protection)
            {
                pointVie = pointVie - 1;
            }
        }

        public bool EstVivant()
        {
            if (pointVie > 0)
            {
                return true;
                
            }
            else
                return false;
        }
    }
}
