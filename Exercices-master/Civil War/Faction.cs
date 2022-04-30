using System;
using System.Collections.Generic;
using System.Text;

namespace Civil_War
{
    class Faction
    {
        private List<SuperHero> membres;
        private string nom;

        public Faction(string nom)
        {
            membres = new List<SuperHero>();
            this.nom = nom;
            Console.WriteLine("Création de la faction " + nom);
        }

        public void AjouterMembre(SuperHero superHero)
        {
            membres.Add(superHero);       
        }

        public void SupprimerMembre(string findHero)
        {
            SuperHero superHero = null;
            foreach (SuperHero lui in membres)
            {
                if (lui.GetNom() == findHero)
                {
                    superHero = lui;
                }
            }

            if (superHero != null)
            {
                membres.Remove(superHero);
            }
        }

        public string GetInfoMembres()
        {
            string txt = "";
            txt += "Les membres de la faction " + nom + "\n";
            foreach (SuperHero sH in membres)
            {
                txt += sH.GetNom();
                txt += sH.GetSuperPouvoir();
                txt += "\n";
            }
            return txt;
        }
    }
}
