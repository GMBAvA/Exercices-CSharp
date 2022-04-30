using System;
using System.Collections.Generic;
using System.Text;

namespace Civil_War
{
    class IronMan : SuperHero
    {
        public IronMan() : base ("Iron Man", "Milliardaire")
        {
            Console.WriteLine("Constructeur : Iron Man");
        }
    }
}
