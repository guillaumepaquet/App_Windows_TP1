using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteLibrairie
{    

    public struct Carte
    {

        public Couleur Couleur { get; set; }

        public int Valeur { get; set; }

        public string NomImageCarte()
        {
            string message = "";
            if (Valeur == 14)
            {
                return message + $"Joker-{Couleur}";
            }
            else
            {
                switch (Valeur)
                {
                    case 11:
                        message += "VALET";
                        break;
                    case 12:
                        message += "DAME";
                        break;
                    case 13:
                        message += "ROI";
                        break;
                    case 1:
                        message += "AS";
                        break;
                    default:
                        message += $"{Valeur}";
                        break;
                }
                return message + $"-{Couleur}";
            }
        }
    }
}
