using System;

namespace L_Arche_de_Noé
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creer les animaux
            Humain noe = new Humain("Noe", 'H');
            Humain emzara = new Humain("Emzara", 'F');
            Lion simba = new Lion("Simba", true, 100);
            Lion nala = new Lion("Nala", true, 70);
            Elephant manny = new Elephant("Manny", 5);
            Elephant ellie = new Elephant("Ellie", 15);
            Girafe melman = new Girafe("Melman", 20);
            Girafe twiga = new Girafe("Twiga", 15);
            // Afficher l'arche
            AfficherArche(noe, emzara, simba, nala, manny, ellie, melman, twiga);

            /* La vie sur l'arche
            Vérifier que Nala est bien une lionne
            Si ce n'est pas le cas, changer-le de sexe
            Afficher la lionne en détail */
            AfficherNala(nala);

            /* L'éléphant male traine de la patte, il faut l'accélérer
            Accélérer Manny jusqu'à vitesse=100 avec une variation=5 (par tour)
            Ensuite, attendre 5 tours puis décélérer de 10 (par tour) jusqu'à un arrêt complet (vitesse <= 0)
            Afficher l'éléphant male en détail */
            VitesseManny(manny);

            /* La hauteur du cadrage de la porte de l'arche est de 18,
            Il faudrait peut-être indiquer aux girafes trop grandes de se pencher
            Afficher la girafe femelle en détail */
            AvertissementGirafesTropGrandes(melman, twiga);

            /* Qui est le capitaine a bord?
            Afficher les deux humains en détails */
            QuiCestQuiCommande(noe, emzara);
        }
        public static void AfficherArche(Humain humain1, Humain humain2, Lion lion1, Lion lion2, Elephant elephant1, Elephant elephant2, Girafe girafe1, Girafe girafe2)
        {
            Console.WriteLine("");
            Console.WriteLine("Humain     ->   " + humain1.GetNom());
            Console.WriteLine("Humain     ->   " + humain2.GetNom());
            Console.WriteLine("Lion       ->   " + lion1.GetNom());
            Console.WriteLine("Lion       ->   " + lion2.GetNom());
            Console.WriteLine("Eléphant   ->   " + elephant1.GetNom());
            Console.WriteLine("Eléphant   ->   " + elephant2.GetNom());
            Console.WriteLine("Girafe     ->   " + girafe1.GetNom());
            Console.WriteLine("Girafe     ->   " + girafe2.GetNom());
            Console.WriteLine("");
        }

        public static void AfficherNala(Lion nala)
        {
            Console.WriteLine(nala.GetNom() + "(" + nala.GetPoids() + "," + nala.IsMale() +")");
            Console.WriteLine("");
        }

        public static void VitesseManny(Elephant manny)
        {
            manny.Accelerer(5);
            manny.Decelerer(10);
            Console.WriteLine(manny.GetNom() + "(" + manny.GetVitesse() + ")");
            Console.WriteLine("");
        }

        public static void AvertissementGirafesTropGrandes(Girafe girafe1, Girafe girafe2)
        {
            girafe1.PasDansLeCadrageDeLaPorte(18);
            girafe2.PasDansLeCadrageDeLaPorte(18);
            Console.WriteLine(girafe2.GetNom() + "(" + girafe2.GetHauteur() + ")");
            Console.WriteLine("");
        }

        public static void QuiCestQuiCommande(Humain humain1, Humain humain2)
        {
            if (humain1.IsCapitaine() == true)
            {
                Console.WriteLine(humain1.GetNom() + " est le capitaine !");
            }
            else
                Console.WriteLine(humain2.GetNom() + " est le capitaine !");
            Console.WriteLine(humain1.GetNom() + "(" + humain1.GetGenre() + "," + humain1.IsCapitaine() + ")");
            Console.WriteLine(humain2.GetNom() + "(" + humain2.GetGenre() + "," + humain2.IsCapitaine() + ")");
        }


    }
}
