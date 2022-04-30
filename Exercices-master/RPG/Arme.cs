using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Arme
    {
        private string type;
        private int dommage;


        public Arme (string _type, int _dommage)
        {
            this.type = _type;
            this.dommage = _dommage;
        }

        public string GetGenre()
        {
            return "TYPE : " + type;
        }

        public string GetDommage()
        {
            return "DOMMAGES : " + dommage;
        }
    }
}
