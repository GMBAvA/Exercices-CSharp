using System;

namespace Reconstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            Batiment[] ruePrincipale = new Batiment[3];

            ruePrincipale[0] = new Batiment();
            ruePrincipale[0].Initialiser("Ma maison", 24, 3000000, 500, 300, TypeBatiment.RESIDENTIEL);
            ruePrincipale[1] = new Batiment();
            ruePrincipale[1].Initialiser("Musée Marvel", 36, 8000000, 800, 400, TypeBatiment.COMMERCIAL);
            ruePrincipale[2] = new Batiment();
            ruePrincipale[2].Initialiser("Musée DC Comics", 34, 6000000, 600, 700, TypeBatiment.COMMERCIAL);

            Batiment[] rueSecondaire = new Batiment[2];

            rueSecondaire[0] = new Batiment();
            rueSecondaire[0].Initialiser("Hotel Trump", 50, 500000, 40, 200, TypeBatiment.COMMERCIAL);
            rueSecondaire[1] = new Batiment();
            rueSecondaire[1].Initialiser("LAV-O-2000", 2, 15000, 10, 4, TypeBatiment.INDUSTRIEL);

            AfficherRue1(ruePrincipale);
            AfficherRue2(ruePrincipale);

        }

        static void AfficherRue1(Batiment[] rue)
        {
            Console.WriteLine("\nAfficher rue, methode #1");
            foreach (Batiment batiment in rue)
                batiment.Afficher();
        }
        static void AfficherRue2(Batiment[] rueSecondaire)
        {
            Console.WriteLine("\nAfficher rue, methode #2");
            foreach (Batiment batiment in rueSecondaire)
                Console.WriteLine(batiment.GetNom() + " (" + batiment.GetTypeBatiment() + ")");
        }
    }
}
