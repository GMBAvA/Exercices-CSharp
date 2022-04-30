using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Equipement
    {
        private string type, description;

        public Equipement(string _type, string _desc)
        {
            this.type = _type;
            this.description = _desc;
        }

        public string GetGenre()
        {
            return "TYPE : " + type;
        }

        public string GetDescription()
        {
            return "DESCRIPTION : " + description;
        }
    }
}
