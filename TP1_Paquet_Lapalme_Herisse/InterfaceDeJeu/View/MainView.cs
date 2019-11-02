using InterfaceDeJeu.Model;
using InterfaceDeJeu.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceDeJeu.View
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }


        public event EventHandler ResetHand
        {
            add { currentPlayerControl1.ResetHand += value; }
            remove { currentPlayerControl1.ResetHand -= value; }
        }

        public void ResetMain()
        {
            currentPlayerControl1.ResetMain();
        }

        public event EventHandler NextPlayer
        {
            add { currentPlayerControl1.NextPlayer += value; }
            remove { currentPlayerControl1.NextPlayer -= value; }
        }

        public void ProchainJoueur()
        {
            currentPlayerControl1.ProchainJoueur();
        }

        public int GetNombreCarteMain()
        {
            return currentPlayerControl1.NombreCarteMain;
        }

        public int GetValeurCarteMain()
        {
            return currentPlayerControl1.ValeurCarteMain;
        }

        public int GetEtat()
        {
            return currentPlayerControl1.Etat;
        }

        public void SetEtat(int etat)
        {
            currentPlayerControl1.Etat = etat;
        }

        public string GetNomCarteMain()
        {
            return currentPlayerControl1.NomCarteMain;
        }

        public List<string> GetCartesJouees()
        {
            return currentPlayerControl1.CartesJouees;
        }

        public void ClearCartesJouees()
        {
            currentPlayerControl1.CartesJouees.Clear();
        }

        public string GetNomJoueur()
        {
            return currentPlayerControl1.Nom;
        }

        public string GetNomDernierJoueur()
        {
            return playedCardsControl1.GetNomDernierJoueur();
        }

        public void ChangeCurrentJoueur(string nom, string position, List<string> cartes, int valeurCarteJouer, int nombreCarteJouer)
        {
            currentPlayerControl1.ChangeNomJoueur(nom);
            currentPlayerControl1.ChangePositionJoueur(position);
            currentPlayerControl1.PlaceCards(cartes);
            currentPlayerControl1.ValeurCarteJouer = valeurCarteJouer;
            currentPlayerControl1.NombreCarteJouer = nombreCarteJouer;
        }

        public void ChangeOtherJoueur1(string nom, string position, int nbCarte)
        {
            otherPlayerControl1.ChangeNom(nom);
            otherPlayerControl1.ChangePosition(position);
            otherPlayerControl1.ChangeNombreCarte(nbCarte);
        }

        public void ChangeOtherJoueur2(string nom, string position, int nbCarte)
        {
            otherPlayerControl2.ChangeNom(nom);
            otherPlayerControl2.ChangePosition(position);
            otherPlayerControl2.ChangeNombreCarte(nbCarte);
        }

        public void ChangeOtherJoueur3(string nom, string position, int nbCarte)
        {
            otherPlayerControl3.ChangeNom(nom);
            otherPlayerControl3.ChangePosition(position);
            otherPlayerControl3.ChangeNombreCarte(nbCarte);
        }

        public void ChangeLastCardPlayed(string nom, string position, List<string> cartes)
        {
            playedCardsControl1.ChangeNom(nom);
            playedCardsControl1.ChangePosition(position);
            playedCardsControl1.AfficheCarteJouer(cartes);
        }
    }
}
