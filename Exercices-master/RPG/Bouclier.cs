using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Bouclier
    {
        private string type;
        private int protection;

        public Bouclier(string _type, int _protection)
        {
            this.type = _type;
            this.protection = _protection;
        }

        public string GetGenre()
        {
            return "TYPE : " + type;
        }

        public string GetProtection()
        {
            return "PROTECTION : " + protection.ToString();
        }

        public int GetProtectionEnInt()
        {
            return protection;
        }
    }
}
