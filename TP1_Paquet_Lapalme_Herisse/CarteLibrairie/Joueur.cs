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
        public Role Role { get; set; }

        // Le joueur a une main et non un paquet
        public Main SaMain { get; set; }

        public Joueur(string nom)
        {
            Nom = nom;
        }
    }
}
