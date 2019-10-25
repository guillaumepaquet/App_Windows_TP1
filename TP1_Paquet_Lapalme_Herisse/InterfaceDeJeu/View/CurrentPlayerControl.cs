using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarteLibrairie;
using System.IO;

namespace InterfaceDeJeu.View
{
    public partial class CurrentPlayerControl : UserControl
    {
        private const int WIDTH = 79;
        private const int HEIGHT = 110;
        private const int TOP = 50;
        private const int LEFT = 40;

        public CurrentPlayerControl()
        {
            InitializeComponent();
            Carte card1 = new Carte();
            card1.Valeur = 1;
            card1.Couleur = Couleur.Pique;
            Carte card2 = new Carte();
            card2.Valeur = 2;
            card2.Couleur = Couleur.Pique;
            Carte card3 = new Carte();
            card3.Valeur = 3;
            card3.Couleur = Couleur.Pique;
            Carte card4 = new Carte();
            card4.Valeur = 4;
            card4.Couleur = Couleur.Pique;
            List<Carte> cards = new List<Carte>();
            cards.Add(card1);
            cards.Add(card2);
            cards.Add(card3);
            cards.Add(card4);
            CreateCard(cards);
        }

        public void CreateCard(List<Carte> cards)
        {
            int i = 4;
            foreach (Carte card in cards)
            {
                i++;
                Button button = new Button();
                button.Width = WIDTH;
                button.Height = HEIGHT;
                button.Top = TOP;
                button.Left = 750 - LEFT * i;
                button.Image = Image.FromFile(Directory.GetCurrentDirectory() + $"\\..\\..\\Resources\\{card.NomImageCarte()}.jpg");
                panel1.Controls.Add(button);
            }
            
        }

    }
}
