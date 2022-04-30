using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class RPG
    {
        private Personnage personnage;

        public RPG()
        {
            personnage = null;
        }

        public void CreerPersonnage(string nom, string classe)
        {
            personnage = new Personnage(nom, classe);
        }

        public string GetInfoPersonnage()
        {
            if (personnage == null)
            {
                return "Aucun personnage";
            }
            return personnage.GetInfoPersonnage();
        }




        public void AjouterBouclier(int taille)
        {
            switch (taille)
            {
                case 0:
                    personnage.EnleverBouclier();
                    break;
                case 1:
                    personnage.AjouterBouclier(new Bouclier("petit", 10));         // ==           Equipement e = new Equipement(type, desc);
                                                                                                // personnage.AjouterEquipement(e, emplacement);
                    break;

                case 2:
                    personnage.AjouterBouclier(new Bouclier("grand", 40));
                    break;
            }
        }

        public void AjouterArmure(int type) // 3 options (0 (aucune), 1 (cuir) ou 2 (metal))
        {
            switch(type)
            {
                case 0:
                    personnage.EnleverArmure();
                    break;
                case 1:
                    personnage.AjouterArmure(new Armure("cuir", 20));
                    break;
                case 2:
                    personnage.AjouterArmure(new Armure("métal", 30));
                    break;
            }
        }

        public void AjouterHeaume()
        {

            personnage.AjouterHeaume(new Heaume("Classique", 5));
        }
        public void EnleverHeaume()
        {
            personnage.EnleverHeaume();
        }

        public void AjouterArme(int type)           // 3 options (0 (aucune), 1 (épée) ou 2 (hache))
        {
            switch (type)
            {
                case 0:
                    personnage.EnleverArme();
                    break;
                case 1:
                    personnage.AjouterArme(new Arme("épée", 50));
                    break;
                case 2:
                    personnage.AjouterArme(new Arme("hache", 80));
                    break;
            }
        }

        public void AjouterEquipement(string type, string desc, int emplacement)
        {
            Equipement e = new Equipement(type, desc);
            personnage.AjouterEquipement(e, emplacement);
        }
        public void EnleverEquipement(int emplacement)
        {
            personnage.EnleverEquipement(emplacement);
        }




        public int GetTotalProtection()
        {
                return personnage.GetTotalProtection();
        }
    }
}