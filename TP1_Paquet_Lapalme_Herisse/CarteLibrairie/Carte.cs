using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteLib
{
    public enum Couleur { TREFLE, PIQUE, CARREAU, COEUR};

    public struct Carte
    {
        private Couleur couleur;
        private int valeur;

        public Carte(Couleur couleur, int valeur)
        {
            this.couleur = couleur;
            this.valeur = valeur;
        }

        public Couleur Couleur
        {
            get { return couleur; }
        }

        public string Valeur
        {
            get { return $"{valeur}"; }
        }

        public
        override string ToString()
        {
            string message = "";
            switch (valeur)
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
            }            
            return message + $" de {couleur}";
        }
    }
}
