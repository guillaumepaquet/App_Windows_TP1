using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDeJeu.View
{
    public interface IOtherPlayerControl
    {
        void ChangeNom(string nom);

        void ChangePosition(string position);

        void ChangeNombreCarte(int nombre);
    }
}
