using System;

namespace Défense_du_Wakanda
{
    class Program
    {

        //            
        static void Main(string[] args)
        {
            PanthereNoire BlackPanther = new PanthereNoire(8,100);
            int skrullConteur = 0;
            int dommageSK = 0;
            int dommageBP = 0;

            while (BlackPanther.EstVivant())
            {
                //Un Skrull apparait et attaque
                Skrull Skrull = new Skrull(5, 3);
                skrullConteur++;
                Console.WriteLine("Un Skrull apparait et attaque");
                if (Skrull.Touche() == true)
                {
                    dommageSK = Skrull.GetDommage();
                    BlackPanther.SubirDommage(dommageSK);
                }

                while (Skrull.EstVivant())
                {
                    Console.WriteLine("Un Skrull attaque la Panthère Noire");
                    //La Panthere Noire frappe le Skrull
                    if (BlackPanther.Touche() == true)
                    {
                        //La Panthere Noire frappe le Skrull
                        Console.WriteLine("     La Panthère Noire frappe le Skrull");
                        dommageBP = BlackPanther.GetDommage();
                        Skrull.SubirDommage(dommageBP);
                    }

                    //Le Skrull est vivant ?
                    if (Skrull.EstVivant() == true)
                    {
                        if (Skrull.Touche() == true)
                        {
                            Console.WriteLine("     Le Skrull frappe la Panthère Noire");
                            dommageSK = Skrull.GetDommage();
                            BlackPanther.SubirDommage(dommageSK);
                        }
                    }
                }
            }
            Console.WriteLine("Le roi T'Challa a été terrassé mais " + skrullConteur + " Skrulls sont morts au combat");
        }
    }
}
