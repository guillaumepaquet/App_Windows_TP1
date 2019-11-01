using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using InterfaceDeJeu.Presenter;
using InterfaceDeJeu.Model;

namespace InterfaceDeJeu.View
{
    public partial class PlayedCardsControl : UserControl, IPlayerCardsControl
    {
        private List<Label> cartesJouees = new List<Label>();

        public PlayedCardsControl()
        {
            InitializeComponent();
        }

        public void ChangeNom(string nom)
        {
            lastPlayerName.Text = nom;
        }

        public void ChangePosition(string position)
        {
            positionDernierJoueur.Text = position;
        }

        public void AfficheCarteJouer(List<string> cards)
        {
            ClearCards();
            cartesJouees.Clear();
            int i = 0;
            foreach (string cardPath in cards)
            {
                i++;
                Label carte = new Label();
                string path = Path.GetDirectoryName(Application.ExecutablePath);
                Image image = Image.FromFile(path + "\\..\\..\\Resources\\" + cardPath + ".jpg");
                carte.BackgroundImage = image;
                carte.BackgroundImageLayout = ImageLayout.Center;
                carte.Width = 79;
                carte.Height = 110;
                carte.Left = (50 * i) + 250;
                carte.Top = 50;
                cartesJouees.Add(carte);
                this.Controls.Add(carte);
            }
        }

        private void ClearCards()
        {
            foreach (Label label in cartesJouees)
            {
                this.Controls.Remove(label);
            }
        }

        public string GetNomDernierJoueur() {
            return lastPlayerName.Text;
        }
    }
}
