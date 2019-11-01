using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDeJeu.Model
{

    public struct Carte : IComparable<Carte>
    {
        public Couleur Couleur { get; set; }

        public Valeur Valeur { get; set; }

        public Carte(Couleur couleur, Valeur valeur)
        {
            Couleur = couleur;
            Valeur = valeur;
        }

        // comparer une carte avec une autre pour savoir qui est plus fort
        public int CompareTo(Carte other)
        {
           return Valeur.CompareTo(other.Valeur);
        }

        public string NomCarte()
        {
            return $"{Valeur}-{Couleur}";
        }

        public
        override string ToString()
        {
            return $"{Valeur}-{Couleur}";
        }
    }
}
