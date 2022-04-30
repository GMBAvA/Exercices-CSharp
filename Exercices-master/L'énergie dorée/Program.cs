using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace goldenenergy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration des variables
            int Na;
            int H2O;
            int Kr;
            int H2 = 0;
            int OH = 0;
            int Na2 = 0;
            int KrO3H = 0;



            // Lecture des données
            Console.WriteLine("Lecture des éléments chimiques de départ");
            Console.Write(" Na > ");
            Na = Convert.ToInt32(Console.ReadLine());
            Console.Write(" H2O > ");
            H2O = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Kr > ");
            Kr = Convert.ToInt32(Console.ReadLine());



            // réalisation de la réaction #1
            // 2Na + 4H2O -> 2H2 + 4OH + Na2
            while (Na >= 2 && H2O >= 4)
            {
                H2 += 2;
                OH += 4;
                Na2 += 2;
                Na -= 2;
                H2O -= 4;
            }
             

            // Afficher le resultat
            Console.WriteLine("Réaction #1");
            Console.WriteLine(" Na    > " + Na);
            Console.WriteLine(" H2O   > " + H2O);
            Console.WriteLine(" Kr    > " + Kr);
            Console.WriteLine(" H2    > " + H2);
            Console.WriteLine(" OH    > " + OH);
            Console.WriteLine(" Na2   > " + Na2);
            Console.WriteLine(" KrO3H > " + KrO3H);



            // réalisation de la réaction #2
            // 3OH + Kr -> KrO3H + H2
            while (OH >= 3 && Kr >= 1)
            {
                KrO3H++;
                H2++;
                OH -= 3;
                Kr--;
            }



            // Afficher le resultat
            Console.WriteLine("Réaction #2");
            Console.WriteLine(" Na    > " + Na);
            Console.WriteLine(" H2O   > " + H2O);
            Console.WriteLine(" Kr    > " + Kr);
            Console.WriteLine(" H2    > " + H2);
            Console.WriteLine(" OH    > " + OH);
            Console.WriteLine(" Na2   > " + Na2);
            Console.WriteLine(" KrO3H > " + KrO3H);



            Console.ReadKey();
        }
    }
}