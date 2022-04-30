using System;

namespace pseudo_démineur
{
    class Program
    {
        private static void AfficherTableauDemineur(int[,] tab)
        {
            //GetLength(0) retourne le nombre de colonne
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                //GetLength(1) retourne le nombre de colonne
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (tab[i,j] == -1)
                    {
                        Console.Write("M");
                    }
                    else
                        Console.Write(tab[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void AfficherTabDemineurClick(int[,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (tab[i, j] >= 10)
                    {
                        Console.Write(tab[i, j] - 10);
                    }

                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        private static void AfficherNbMines1(int[,] tab)
        {
            int mine = 0;

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (tab[i, j] == -1)
                    {
                        mine++;
                    }
                }
                
            }

            Console.WriteLine("Il y a " + mine + " mines");
        }

        private static void AfficherNbClick(int[,] tab)
        {
            int caseClick = 0;

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (tab[i, j] >= 10)
                    {
                        caseClick++;
                    }
                }

            }

            Console.WriteLine("Il y a " + caseClick + " cases cliquées");
        }

        static void Main(string[] args)
        {



            int[,] tabDemineur = new int[5, 5]
            {
                { 1, 2, 1, 1, 0 },
                {-1, 2,-1, 1 ,0 },
                { 1, 2, 1, 1, 0 },
                { 1, 1, 1, 0, 0 },
                { 1,-1, 1, 0, 0 }
            };

            AfficherTableauDemineur(tabDemineur);
            Console.WriteLine();
            Console.WriteLine();

            int[,] tabDemineur2 = new int[5, 5]
            {
                { 1, 2, 1, 1, 10 },
                {-1, 2, -1, 1 ,10 },
                { 1, 12, 1, 1, 10 },
                { 1, 1, 1, 10, 10 },
                { 11,-1, 1, 10, 10 }
            };

            AfficherTabDemineurClick(tabDemineur2);

            AfficherNbMines1(tabDemineur);
            AfficherNbMines1(tabDemineur2);

            AfficherNbClick(tabDemineur2);
        }

        
    }
}
