using System;
using System.Collections.Generic;

namespace Carte
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*** paquet1 ***");
            Paquet paquet1 = new Paquet();
            while (!paquet1.EstVide())
                Console.WriteLine(paquet1.Piger().ToString());

            Console.WriteLine("*** paquet2 ***");
            Paquet paquet2 = new Paquet(true);
            while (!paquet2.EstVide())
                Console.WriteLine(paquet2.Piger().ToString());

            Console.WriteLine("*** paquet magique ***");
            Paquet paquetJoueur1 = new Paquet(true);
            Paquet paquetJoueur2 = new Paquet(true);
            int scoreJoueur1 = 0;
            int scoreJoueur2 = 0;

            // Premier tour : piger 3 cartes chacun et additionner les résultats. 
            // Le gagnant gagne la différence des points
            int totalJ1 = GetScoreTotal(paquetJoueur1, 3);
            int totalJ2 = GetScoreTotal(paquetJoueur2, 3);
            if (totalJ1 > totalJ2)
                scoreJoueur1 += (totalJ1 - totalJ2);
            else
                scoreJoueur2 += (totalJ2 - totalJ1);
            Console.WriteLine("> Premier tour : " + scoreJoueur1 + "/" + scoreJoueur2);

            // Second tour : piger 1 carte chacun, si les cartes sont de même type, J1 gagne 12 points. 
            // Autrement, J2 gagne 3 points
            if (paquetJoueur1.Piger().GetTypeCarte() == paquetJoueur2.Piger().GetTypeCarte())
                scoreJoueur1 += 12;
            else
                scoreJoueur2 += 3;
            Console.WriteLine("> Second tour : " + scoreJoueur1 + "/" + scoreJoueur2);

            // Troisième tour : Chaque joueur pige 4 cartes 
            // si la carte pigé est supérieure, le joueur gagne un point. Effectuer 2 fois par joueur
            for (int x = 0; x < 2; x++)
            {
                if (paquetJoueur1.Piger() > paquetJoueur2.Piger())
                    scoreJoueur1++;
                if (paquetJoueur2.Piger() > paquetJoueur1.Piger())
                    scoreJoueur2++;
            }
            Console.WriteLine("> Troisieme tour : " + scoreJoueur1 + "/" + scoreJoueur2);

            // Quatrième tour : Chaque joueur pige 10 cartes
            // si la carte pigée est identique, le joueur gagne 25 points. 
            // Effectuer 5 fois par joueur
            for (int x = 0; x < 5; x++)
            {
                if (paquetJoueur1.Piger() == paquetJoueur2.Piger())
                    scoreJoueur1 += 25;
                if (paquetJoueur2.Piger() == paquetJoueur1.Piger())
                    scoreJoueur2 += 25;
            }
            Console.WriteLine("> Quatrieme tour : " + scoreJoueur1 + "/" + scoreJoueur2);

            // Dernier tour : Jusqu'à la fin du paquet ou jusqu'à ce qu'un joueur pige un JOKER
            // si la carte pigée est un joker, le joueur gagne 10 points.
            // En cas d'égalité, chaque joueur gagne 10 points.

            while (!paquetJoueur1.EstVide())
            {
                if (paquetJoueur1.Piger().EstJoker())
                {
                    scoreJoueur1 += 10;
                    break;
                }
                if (paquetJoueur2.Piger().EstJoker())
                {
                    scoreJoueur2 += 10;
                    break;
                }
            }
            Console.WriteLine("> Cinquieme tour : " + scoreJoueur1 + "/" + scoreJoueur2);

            // Résultats finaux
            Console.WriteLine("Resultat");
            Console.WriteLine("scoreJoueur1 : " + scoreJoueur1);
            Console.WriteLine("scoreJoueur2 : " + scoreJoueur2);

            Console.WriteLine("Le paquet du joueur 1");
            while (!paquetJoueur1.EstVide())
                Console.WriteLine(paquetJoueur1.Piger().ToString());

            Console.WriteLine("Le paquet du joueur 2");
            while (!paquetJoueur2.EstVide())
                Console.WriteLine(paquetJoueur2.Piger().ToString());
        }

        private static int GetScoreTotal(Paquet paquet, int nombreCarteAPiger)
        {
            int total = 0;
            // TODO
            // calcule la somme des "nombreCarteAPiger" cartes provenant du paquet
            return total;
        }
    }
}