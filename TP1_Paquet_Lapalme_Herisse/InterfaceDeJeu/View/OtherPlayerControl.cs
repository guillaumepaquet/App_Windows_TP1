using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceDeJeu.Presenter;
using InterfaceDeJeu.Model;

namespace InterfaceDeJeu.View
{
    public partial class OtherPlayerControl : UserControl, IOtherPlayerControl
    {
        public OtherPlayerControl()
        {
            InitializeComponent();
        }

        public void ChangeNom(string nom)
        {
            nomJoueur.Text = nom;
        }

        public void ChangeNombreCarte(int nombre)
        {
            nbCartes.Text = $"{nombre} carte(s)";
        }

        public void ChangePosition(string position)
        {
            positionJoueur.Text = position;
        }
    }
}
