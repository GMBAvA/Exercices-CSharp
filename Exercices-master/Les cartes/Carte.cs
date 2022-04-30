namespace Carte
{
    public class Carte
    {
        public enum TYPE_CARTE { COEUR, PIQUE, TREFLE, CARREAU};
        private const int JOKER = 0;

        private int valeur;
        private TYPE_CARTE typeCarte;

        public Carte()
        {
            InitialierJoker();
        }

        public Carte(int valeur, TYPE_CARTE typeCarte)
        {
            this.typeCarte = typeCarte;
            SetValeur(valeur);
        }

        public bool EstJoker()
        {
            if (this.valeur != JOKER)
            {
                return false;
            }
            else
                return true;
            
        }

        public int GetValeur()
        {
            int valeur = this.valeur;
            return valeur;       // pour compiler
        }

        public TYPE_CARTE GetTypeCarte()
        {
            return typeCarte;
        }

        private void InitialierJoker()
        {
            typeCarte = TYPE_CARTE.COEUR;   // Inutile
            valeur = JOKER;
        }

        private void SetValeur(int valeur)
        {
            if (valeur >= 1 && valeur <= 13)
                this.valeur = valeur;
            else if (valeur > 13)
                this.valeur = 13;
            else
                this.valeur = 1;     
            // TODO
            // Faire la validation des valeurs min et max
        }

        public static int operator +(Carte c1, Carte c2)
        {
            int valeur;
            valeur = c1.valeur + c2.valeur;
            // TODO
            // additionner la valeur des cartes
            return valeur;               // pour compiler
        }

        public static bool operator == (Carte c1, Carte c2)
        {
            // TODO
            // VRAI si les cartes ont la meme valeur et le même type
            if (c1.valeur == c2.valeur && c1.typeCarte == c2.typeCarte)
                return true;            // pour compiler
            else
                return false;
        }

        public static bool operator !=(Carte c1, Carte c2)
        {
            // TODO
            if (c1.valeur != c2.valeur && c1.typeCarte != c2.typeCarte)
                return true;            // pour compiler
            else
                return false;
        }

        public static bool operator >(Carte c1, Carte c2)
        {
            // TODO
            // comparer les valeurs
            if (c1.valeur > c2.valeur)
                return true;            // pour compiler
            else
                return false;
        }

        public static bool operator <(Carte c1, Carte c2)
        {
            // TODO
            // comparer les valeurs
            if (c1.valeur > c2.valeur)
                return false;           // pour compiler
            else
                return true;
        }

        // Exemple d'affichage
        // Carte {t:COEUR,v:11}
        // Carte {JOKER}
        public override string ToString()
        {
            return "Carte";
        }
    }
}
