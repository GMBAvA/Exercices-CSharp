using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Section #1 : Chargement (30%)");
            Console.WriteLine("-------------------------------------");

            RPG rpg = new RPG();

            Console.Write("Entrer le nom du personnage > ");
            string nom = Console.ReadLine();
            Console.Write("Entrer la classe du personnage > ");
            string classe = Console.ReadLine();

            rpg.CreerPersonnage(nom, classe);

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("Section #2 : Affichage (50%)");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine(rpg.GetInfoPersonnage());
            //rpg.GetPersonnage().AjouterBouclier(new Bouclier());//////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("Section #3 : Personnalisation (80%)");
            Console.WriteLine("-------------------------------------");


            rpg.AjouterBouclier(2);      // 3 options (0 (aucune), 1 (petit) ou 2 (grand))
            rpg.AjouterArmure(2);        // 3 options (0 (aucune), 1 (cuir) ou 2 (metal))
            rpg.AjouterHeaume();
            rpg.EnleverHeaume();
            rpg.AjouterArme(2);          // 3 options (0 (aucune), 1 (épée) ou 2 (hache))
            rpg.AjouterEquipement("vetement magique", "bottes elfiques", 0);
            rpg.AjouterEquipement("Anneau", "Le pouvoir de les controler tous", 1);
            rpg.AjouterEquipement("Potion", "Guerison", 2);
            rpg.EnleverEquipement(1);

            Console.WriteLine(rpg.GetInfoPersonnage());



            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("Section #4 : Test (100%)");
            Console.WriteLine("-------------------------------------");

            TestRPG(rpg);
        }

        
        private static void TestRPG(RPG ancienRPG)
        {
            RPG rpg = new RPG();

            Console.WriteLine("\nTest A : Initialisation des attributs du constructeur (85%)");
            Console.WriteLine(rpg.GetInfoPersonnage());



            Console.WriteLine("\nTest B : Passage par reference (90%)");
            TestPassageReference(rpg);
            Console.WriteLine(rpg.GetInfoPersonnage());



            Console.WriteLine("\nTest C : Changement d'armes! (95%)");
            rpg.AjouterArme(0);
            rpg.AjouterArme(1);
            rpg.AjouterArme(2);
            Console.WriteLine(rpg.GetInfoPersonnage());



            Console.WriteLine("\nTest D : Connaitre le total de la protection (100%)");
            Console.WriteLine("PROTECTION Ancien RPG  : " + ancienRPG.GetTotalProtection());
            Console.WriteLine("PROTECTION nouveau RPG : " + rpg.GetTotalProtection());

        }

        private static void TestPassageReference(RPG rpgEnRef)
        {
            rpgEnRef.CreerPersonnage("Conan", "Barbare");
            rpgEnRef.AjouterHeaume();
            rpgEnRef = null;        // Ne fait rien ici car pas en ref
        }

    }
}
