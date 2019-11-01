using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDeJeu.View
{
    public interface IPlayerCardsControl
    {
        void AfficheCarteJouer(List<string> cards);

        string GetNomDernierJoueur();
    }
}
