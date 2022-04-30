using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Personnage
    {
        private string nom, classe;
        private int pointVie;
        private Arme arme;
        private Bouclier bouclier;
        private Armure armure;
        private Heaume heaume;
        private Equipement[] equipement;

        public Personnage(string nom, string classe)
        {
            Random random = new Random();
            pointVie = random.Next(6, 11);

            this.nom = nom;
            this.classe = classe;

            arme = null;
            bouclier = null;
            armure = null;
            heaume = null;
            equipement = new Equipement[3];
        }

        public void AjouterArme(Arme _arme)
        {
            arme = _arme;
        }
        public void EnleverArme()
        {
            arme = null;
        }


        public void AjouterArmure(Armure _armure)
        {
            armure = _armure;
        }
        public void EnleverArmure()
        {
            armure = null;
        }


        public void AjouterBouclier(Bouclier _bouclier)
        {
            bouclier = _bouclier;
        }
        public void EnleverBouclier()
        {
            bouclier = null;
        }


        public void AjouterHeaume(Heaume _heaume)
        {
            heaume = _heaume;
        }
        public void EnleverHeaume()
        {
            heaume = null;
        }

        public void AjouterEquipement(Equipement _equipement, int position)
        {
            equipement[position] = _equipement;
        }
        public void EnleverEquipement(int position)
        {
            equipement[position] = null;
        }

        public int GetTotalProtection()
        {
            int total = 0;
            if (armure != null)
            {
                total += armure.GetProtectionEnInt();
            }
            if (bouclier != null)
            {
                total += bouclier.GetProtectionEnInt();
            }
            if (heaume != null)
            {
                total += heaume.GetProtectionEnInt();
            }
            
            return total;
        }

        public string GetInfoPersonnage()
        {
            string txt = "PERSONNAGE :" +
                "\nNOM           : " + nom +
                "\nCLASSE        : " + classe +
                "\nPV            : " + pointVie;

            if (arme == null)
            {
                txt += "\nARME          : { }";
            }
            else
                txt += "\nARME          : { " + arme.GetGenre() + " / " + arme.GetDommage() + " }";

            if (armure == null)
            {
                txt += "\nARMURE        : { }";
            }
            else
                txt += "\nARMURE        : { " + armure.GetGenre() + " / " + armure.GetProtection() + " }";

            if (bouclier == null)
            {
                txt += "\nBOUCLIER      : { }";
            }
            else
                txt += "\nBOUCLIER      : { " + bouclier.GetGenre() + " / " + bouclier.GetProtection() + "}";

            if (heaume == null)
            {
                txt += "\nHEAUME        : { }";
            }
            else
                txt += "\nHEAUME        : { " + heaume.GetGenre() + " / " + heaume.GetProtection() + "}";

            if (equipement[0] == null)
            {
                txt += "\nEQUIPEMENT    : { { }";
            }
            else
                txt += "\nEQUIPEMENT    : { { " + equipement[0].GetGenre() + " / " + equipement[0].GetDescription() +" }";
            if (equipement[1] == null)
            {
                txt += " { }";
            }
            else
                txt += " {" + equipement[1].GetGenre() + " / " + equipement[1].GetDescription() +"}";
            if (equipement[2] == null)
            {
                txt += " { } }";
            }
            else if (equipement[2] != null)
            {
                txt += " {" + equipement[2].GetGenre() + " / " + equipement[2].GetDescription() + "} }";
            }
            return txt;
        }
    }
}
