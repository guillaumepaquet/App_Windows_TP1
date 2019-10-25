using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteLibrairie
{
    public enum Couleur { TREFLE, PIQUE, CARREAU, COEUR};
    // Liste des Valeur avec des indexs pour indiquer quel carte est la plus forte
    public enum  Valeur { TROIS = 1, QUATRE = 2, CINQ = 3, SIX = 4 , SEPT = 5 , HUIT = 6,
                          NEUF = 7, DIX = 8, VALET = 9, DAME = 10, ROI = 11, AS = 12, DEUX = 13, JOKER = 14  }

    public struct Carte : IComparable<Carte>
    {

        private Couleur couleur;
        private Valeur valeur;

        public Carte(Couleur couleur, Valeur valeur)
        {
            this.couleur = couleur;
            this.valeur = valeur;
        }

        //Probleme avec le Joker plus que c'est un strut la couleur doit etre initialiser mais le joker n'a pas de couleur
       /* public Carte(Valeur joker)
        {
            if(Valeur.JOKER == joker)
            {
                valeur = joker;
            }
            couleu
           
            
            
            
        }*/

        public Couleur Couleur
        {
            get { return couleur; }
        }

        public Valeur Valeur
        {
            // get { return $"{valeur}"; }
            get { return valeur; }
        }

        // comparer une carte avec une autre pour savoir qui est plus fort
        public int CompareTo(Carte other)
        {
           return (int)this.Valeur.CompareTo((int)other.valeur);
        }

        public
        override string ToString()
        {

            string message = "";
            // solution pas tres bonne pour le joker
            if (valeur == Valeur.JOKER)
            {
                message = $" le {valeur}";
            }
            else
                message = $"{valeur} de {couleur}";
           
          /*  switch (valeur)
            {
                case 11:
                    message += "Valet";
                    break;
                case 12:
                    message += "Dame";
                    break;
                case 13:
                    message += "Roi";
                    break;
                case 1:
                    message += "As";

                    break;
                default:
                    message += $"{valeur}";
                    break;
            }            */
            return  message;
        }
    }
}
