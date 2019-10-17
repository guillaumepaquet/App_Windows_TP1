using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteLibrairie
{
    class Jeu
    {
        public event EventHandler<ChangeJoueurEventArgs> ChangeJoueur;

        public Joueur PremierJoueur { get; set; }

        public int ValeurCarteJouer { get; set; }

        public int NombreCarteJouer { get; set; }

        public void ChangerJoueur(Joueur dernierJoueur, Joueur joueurSuivant, int valeurCarte, int nombreCarte)
        {
            ChangeJoueurEventArgs eventArgs = new ChangeJoueurEventArgs();
            eventArgs.PremierJoueur = PremierJoueur;
            eventArgs.DernierJoueurAJouer = dernierJoueur;
            eventArgs.JoueurSuivant = joueurSuivant;
            eventArgs.ValeurCarteJouer = valeurCarte;
        }
    }
}
