using System;

namespace Réchauffement
{
    class Program
    {
        static void Main(string[] args)
        {
            PremierJet();
            SecondJet();
            TroisiemeJet(2);
            QuatriemeJet(5);
            CinquiemeJet();
        }

        private static void PremierJet()
        {
            int res = 0;
            De monDe1 = new De();
            monDe1.Initialiser(4);
            res = monDe1.GetValeur();
            monDe1.LancerDe();
            res = res + monDe1.GetValeur();
            res = res + 4;
            Console.WriteLine("(1) 2D4 + 4 : " + res);
        }
        
        private static void SecondJet()
        {
            int res = 0;
            int val1 = 0;
            int val2 = 0;
            int val3 = 0;

            De monDe60 = new De();
            De monDe61 = new De();
            De monDe62 = new De();

            monDe60.Initialiser(6);
            monDe61.Initialiser(6);
            monDe62.Initialiser(6);

            Console.WriteLine("(2) 6 * 3D6 :");
            for (int x = 0; x < 6 ; x++)
            {
                monDe60.LancerDe();
                monDe61.LancerDe();
                monDe62.LancerDe();

                monDe60.GetValeur();
                monDe61.GetValeur();
                monDe62.GetValeur();

                res = monDe60.GetValeur() + monDe61.GetValeur() + monDe62.GetValeur();
                val1 = monDe60.GetValeur();
                val2 = monDe61.GetValeur();
                val3 = monDe62.GetValeur();

                Console.WriteLine(val1 + " " + val2 + " " + val3 + " ==> " + res);
            }          
        }

        private static void TroisiemeJet(int force)
        {
            int res = 0;
            De monDe3 = new De();
            monDe3.Initialiser(8);
            monDe3.LancerDe();
            res = monDe3.GetValeur();

            Console.WriteLine("(3) 1D8 + 2 : " + (res+force));
            
        }

        private static void QuatriemeJet(int force)
        {
            float res = 0;
            float moyenne = 0;
            De monDe4 = new De();
            monDe4.Initialiser(10);

            for (int x = 0; x < 100; x++)
            {
                monDe4.LancerDe();
                monDe4.GetValeur();
                res = res + monDe4.GetValeur();
            }

            moyenne = res / 100;
            Console.WriteLine("(4) " + moyenne + " > 5");
        }

        private static void CinquiemeJet()
        {
            int res = 0;
            int nbLancer = 0;
            De monDe5 = new De();
            monDe5.Initialiser(20);

            do
            {
                monDe5.LancerDe();
                monDe5.GetValeur();
                res = monDe5.GetValeur();
                nbLancer++;
            }
            while (res != 1 && res != 20);

            if (res == 1)
            {
                Console.WriteLine("(5) Nombre de lancements de D20 : " + nbLancer);
                Console.WriteLine("Le résultat est " + res + " - ECHEC");
            }
            else if (res == 20)
            {
                Console.WriteLine("(5) Nombre de lancements de D20 : " + nbLancer);
                Console.WriteLine("Le résultat est " + res + " - REUSSITE");
            }
            else
                Console.WriteLine("WTF");
        }
    }
}
