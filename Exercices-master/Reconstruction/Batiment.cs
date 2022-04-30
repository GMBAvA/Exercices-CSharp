using System;
using System.Collections.Generic;
using System.Text;

namespace Reconstruction
{

    enum TypeBatiment { COMMERCIAL, RESIDENTIEL, INDUSTRIEL };
    class Batiment
    {
            private string nom;
            private int nbPieces;
            private int prixConstruction;
            private int largeur;
            private int longueur;
            private TypeBatiment typeBatiment;

        public void Initialiser(string _nom, int _nbPieces, int _prixConstruction, int _largeur, int _longueur, TypeBatiment _typeBatiment)
        {
            nom = _nom;
            nbPieces = _nbPieces;
            prixConstruction = _prixConstruction;
            largeur = _largeur;
            longueur = _longueur;
            typeBatiment = _typeBatiment;
        }

        public void Afficher()
        {
            Console.WriteLine(nom + typeBatiment + " -> " + nbPieces + "P/" + prixConstruction + "/");
        }

        public string GetNom()
        {
            return nom;
        }

        public int GetNbPieces()
        {
            return nbPieces;
        }

        public int GetPrixConstruction()
        {
            return prixConstruction;
        }


        public int GetLongueur()
        {
            return longueur;
        }


        public int GetLargeur()
        {
            return largeur;
        }

        public TypeBatiment GetTypeBatiment()
        {
            return typeBatiment;
        }

        private int CalculerSurface()
        {
            int val1;
            int val2;
            int res;
            val1 = GetLongueur(); ;
            val2 = GetLargeur();
            res = val1 * val2;
            return res;
        }
    }
}
