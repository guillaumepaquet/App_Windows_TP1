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

namespace InterfaceDeJeu.View
{
    public partial class CurrentPlayerControl : UserControl
    {
        public int ValeurCarteJouer { get; set; }

        public int NombreCarteJouer { get; set; }

        private int ValeurCarteMain { get; set; }

        private int NombreCarteMain { get; set; }

        private List<CarteButton> carteButtons;

        public CurrentPlayerControl()
        {
            InitializeComponent();
        }
        
        public void PlaceCards(List<string> cards)
        {
            NombreCarteMain = 0;
            ValeurCarteMain = 0;
            int i = 0;
            foreach (string cardPath in cards)
            {
                i++;
                CarteButton carte = new CarteButton();
                Image image = Image.FromFile("\\..\\..\\Resources\\" + cardPath + ".jpg");
                carte.HiddenText = cardPath;
                carte.BackgroundImage = image;
                carte.Width = 79;
                carte.Height = 110;
                carte.Left = 69 * i;
                carte.Top = 10;
                carte.Click += OnCardClick;
                carteButtons.Add(carte);
            }            
        }

        private void OnCardClick(object sender, EventArgs e)
        {
            if (!(sender is CarteButton))
            {
                return;
            }
            buttonProchainJoueur.Enabled = true;
            CarteButton CarteClicked = (CarteButton)sender;
            string carte = CarteClicked.HiddenText;
            string valeurString = carte.Substring(0, carte.IndexOf('-'));
            int valeur = 0;
            switch (valeurString)
            {
                case "TROIS":
                    valeur = 1;
                    break;
                case "QUATRE":
                    valeur = 2;
                    break;
                case "CINQ":
                    valeur = 3;
                    break;
                case "SIX":
                    valeur = 4;
                    break;
                case "SEPT":
                    valeur = 5;
                    break;
                case "HUIT":
                    valeur = 6;
                    break;
                case "NEUF":
                    valeur = 7;
                    break;
                case "DIX":
                    valeur = 8;
                    break;
                case "VALET":
                    valeur = 9;
                    break;
                case "DAME":
                    valeur = 10;
                    break;
                case "ROI":
                    valeur = 11;
                    break;
                case "AS":
                    valeur = 12;
                    break;
                case "DEUX":
                    valeur = 13;
                    break;
                case "JOKER":
                    valeur = 14;
                    break;
                default:
                    break;
            }
            if (valeur > ValeurCarteJouer && (valeur == ValeurCarteMain || ValeurCarteMain == 0))
            {
                CarteClicked.Enabled = false;
                NombreCarteMain++;
                ValeurCarteMain = valeur;
                switch (valeur)
                {
                    case 14:
                        buttonProchainJoueur.Enabled = true;
                        break;
                    case 13:
                        if (NombreCarteMain == NombreCarteJouer - 1 || NombreCarteJouer == 0)
                        {
                            buttonProchainJoueur.Enabled = true;
                        }
                        break;
                    default:
                        if (NombreCarteMain == NombreCarteJouer || NombreCarteJouer == 0)
                        {
                            buttonProchainJoueur.Enabled = true;
                        }
                        break;
                }
            }
        }

        private void ButtonResetMain_Click(object sender, EventArgs e)
        {
            ValeurCarteMain = 0;
            NombreCarteMain = 0;
            foreach (var button in carteButtons)
            {
                if (button.Enabled == false)
                    button.Enabled = true;
            }
            buttonProchainJoueur.Enabled = true;
        }

        private void ButtonProchainJoueur_Click(object sender, EventArgs e)
        {
            ChangeJoueurEventArgs args = new ChangeJoueurEventArgs();
            args.NombreCarteJouer = NombreCarteMain;
            args.ValeurCarteJouer = ValeurCarteMain;
        }
    }

    public class CarteButton : Button
    {
        public string HiddenText { get; set; }
    }
}
