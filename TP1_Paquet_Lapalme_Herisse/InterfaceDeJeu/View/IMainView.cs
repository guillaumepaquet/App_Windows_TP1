using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDeJeu.View
{
    public interface IMainView
    {
        event EventHandler Load;

        event EventHandler ResetHand;

        event EventHandler NextPlayer;

        void ResetMain();

        void ProchainJoueur();

        int GetNombreCarteMain();

        int GetValeurCarteMain();

        string GetNomJoueur();

        string GetNomDernierJoueur();

        List<string> GetCartesJouees();

        void ClearCartesJouees();

        int GetEtat();

        void SetEtat(int etat);

        string GetNomCarteMain();
    }
}
