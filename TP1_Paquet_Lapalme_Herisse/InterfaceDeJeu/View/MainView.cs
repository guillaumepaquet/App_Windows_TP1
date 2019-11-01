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
            MainViewPresenter.OtherPlayerChange1 += ChangeOtherPlayer1;
            MainViewPresenter.OtherPlayerChange2 += ChangeOtherPlayer2;
            MainViewPresenter.OtherPlayerChange3 += ChangeOtherPlayer3;
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
        private void ChangeOtherPlayer3(object sender, OtherPlayerChangeEventArgs e)
        {
            otherPlayerControl3.ChangeNom(e.Nom);
            otherPlayerControl3.ChangePosition(e.Position);
            otherPlayerControl3.ChangeNombreCarte(e.NombreCarte);
        }

        private void ChangeOtherPlayer2(object sender, OtherPlayerChangeEventArgs e)
        {
            otherPlayerControl2.ChangeNom(e.Nom);
            otherPlayerControl2.ChangePosition(e.Position);
            otherPlayerControl2.ChangeNombreCarte(e.NombreCarte);
        }

        private void ChangeOtherPlayer1(object sender, OtherPlayerChangeEventArgs e)
        {
            otherPlayerControl1.ChangeNom(e.Nom);
            otherPlayerControl1.ChangePosition(e.Position);
            otherPlayerControl1.ChangeNombreCarte(e.NombreCarte);
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
    }
}
