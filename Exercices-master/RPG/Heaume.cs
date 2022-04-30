using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Heaume
    {
        private string type;
        private int protection;

        public Heaume (string _type, int _protection)
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
            
            return "PROTECTION : " + protection;
        }

        public int GetProtectionEnInt()
        {
            if (protection > 0)
            {
                return protection;
            }
            else return 0;
            
        }
    }
}
