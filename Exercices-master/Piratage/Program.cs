using System;

namespace Piratage
{
    class Program
    {
        static void Main(string[] args)
        {
            Routeur monRouteur = new Routeur(6, true);
            Pirate pirate = new Pirate();

            pirate.PiraterRouteur(monRouteur, 6);

            Console.WriteLine("Le mdp est " + pirate.GetMotPasse());
            Console.WriteLine("Recherche de " + pirate.GetNbEssais() + " possibilites sur un total de " + pirate.GetNbPossibilitesMax());
            Console.WriteLine("Execution de " + pirate.GetCompteur() + " ms");
        }
    }
}
