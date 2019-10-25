using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteLibrairie
{

    public struct Carte : IComparable<Carte>
    {

        private Couleur couleur;
        private Valeur valeur;

        public Carte(Couleur couleur, Valeur valeur)
        {
            this.couleur = couleur;
            this.valeur = valeur;
        }

        public Couleur Couleur
        {
            get { return couleur; }
        }

        public Valeur Valeur
        {
            get { return valeur; }
        }

        // comparer une carte avec une autre pour savoir qui est plus fort
        public int CompareTo(Carte other)
        {
           return Valeur.CompareTo((int)other.valeur);
        }

        public
        override string ToString()
        {
            return $"{Valeur}-{Couleur}";
        }
    }
}
