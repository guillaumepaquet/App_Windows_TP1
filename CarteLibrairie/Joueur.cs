using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteLibrairie
{
    class Joueur
    {
        public string Nom { get; set; }

        public Paquet Paquet { get; set; }

        public Joueur(string nom)
        {
            Nom = nom;
        }
    }
}
