using System;

namespace POO_Alexandre_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int na = 0;
            int h2O = 0;
            int kr = 0;
            int oH = 0;
            int krO3H = 0;
            int h2 = 0;

            Console.WriteLine("Entrer la qtt de Na");
            na = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrer la qtt de H2O");
            h2O = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrer la qtt de Kr");
            kr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Première réaction");

            while (na >= 2 && h2O >= 4)
            {
                h2O = h2O + 2;
                oH = oH + 4;
                na = na + 2;
                na = na - 2;
                h2O = h2O - 4;
            }

            Console.WriteLine("Il y a " + na + " Na, " + h2O + " H2O, " + kr + " Kr, " + oH + " OH.");
            Console.ReadKey();
            Console.WriteLine("Deuxième réaction");

            while (oH >= 3 && kr >= 1)
            {
                krO3H++;
                h2++;
                oH = oH - 3;
                kr--;
            }

            Console.WriteLine("Il y a " + na + " Na, " + h2O + " H2O, " + kr + " Kr, " + oH + " OH, " + krO3H + " KrO3H, " + h2 + " H2.");
            Console.ReadKey();


        }
    }
}
