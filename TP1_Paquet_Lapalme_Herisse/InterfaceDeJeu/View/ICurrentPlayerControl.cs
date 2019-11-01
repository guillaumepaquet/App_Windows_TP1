using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDeJeu.View
{
    public interface ICurrentPlayerControl
    {
        event EventHandler ResetHand;

        event EventHandler NextPlayer;

        void ResetMain();

        void ChangeNomJoueur(string nom);

        void ChangePositionJoueur(string position);

        void PlaceCards(List<string> cards);

        int ValeurCarteMain { get; set; }

        int NombreCarteMain { get; set; }

        int ValeurCarteJouer { get; set; }

        int NombreCarteJouer { get; set; }

        int Etat { get; set; }
    }
}
