using System;

namespace Bat_Signal
{
    class Program
    {
        static void analyserBatParkour(double vDeplacement, double vDescente, float distance, float hauteurMin, float hauteur)
        {
            double distanceCourante = 0;
            double duree = 0; 
            Console.WriteLine("Vitesse de déplacement : " + vDeplacement + ", vitesse de descente : " + vDescente + ", distance : " + distance + ", hauteur minimum : " + hauteurMin + ", hauteur : " + hauteur);
            while (distanceCourante < distance)
            {
                duree++;
                distanceCourante = distanceCourante + vDeplacement;
                vDescente--;
            }
            Console.WriteLine("Durée du vol : " + duree + ", distance : " + distance + ", hauteur : " + hauteur);

            if (hauteur > hauteurMin + 50)
            {
                Console.WriteLine("Batman passe au-dessus du GCPD");
            }
            else if (hauteur < hauteurMin)
            {
                Console.WriteLine("Batman arrive dans le mur du GCPD");
            }
            else
                Console.WriteLine("Batman atterri sur le toit");
        }

        static void Main(string[] args)
        {
            float hauteurMin = 50;
            float hauteur = 445;
            float distance = 168;

            double[] vDescente = { 8.5, 5.5, 4, 2, 1.5 };
            double[] vDeplacement = { 3, 2.5, 2, 1.5, 1 };
            double vitDeplacement = 0;
            double vitDescente = 0;

            for (int i = 0; i < vDeplacement.Length; i++)
            {
                vitDeplacement = vDeplacement[i];
                vitDescente = vDescente[i];
                analyserBatParkour(vitDeplacement, vitDescente, distance, hauteurMin, hauteur);
            }
        }
    }
}
