using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteLibrairie
{
    class ChangeJoueurEventArgs : EventArgs
    {
        public Joueur PremierJoueur { get; set; }

        public Joueur DernierJoueurAJouer { get; set; }

        public Joueur JoueurSuivant { get; set; }

        public int ValeurCarteJouer { get; set; }

        public int NombreCarteJouer { get; set; }
    }
}
