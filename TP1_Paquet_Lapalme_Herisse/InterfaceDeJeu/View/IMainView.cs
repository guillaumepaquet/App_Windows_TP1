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

        void ChangeCurrentJoueur(string nom, string position, List<string> cartes, int valeurCarteJouer, int nombreCarteJouer);

        void ChangeOtherJoueur1(string nom, string position, int nbCarte);

        void ChangeOtherJoueur2(string nom, string position, int nbCarte);

        void ChangeOtherJoueur3(string nom, string position, int nbCarte);

        void ChangeLastCardPlayed(string nom, string position, List<string> cartes);
    }
}
