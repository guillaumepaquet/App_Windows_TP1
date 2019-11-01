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
    public partial class CurrentPlayerControl : UserControl, ICurrentPlayerControl
    {
        public int ValeurCarteJouer { get; set; }

        public int NombreCarteJouer { get; set; }

        public int ValeurCarteMain { get; set; }

        public string NomCarteMain { get; set; }

        public int NombreCarteMain { get; set; }

        public string Nom { get { return nomJoueur.Text; } }

        public List<string> CartesJouees { get; set; } = new List<string>();

        public int Etat { get; set; } = 4;

        private List<CarteButton> carteButtons = new List<CarteButton>();

        public event EventHandler NextPlayer
        {
            add { buttonProchainJoueur.Click += value; }
            remove { buttonProchainJoueur.Click -= value; }
        }

        public event EventHandler ResetHand
        {
            add { buttonResetMain.Click += value; }
            remove { buttonResetMain.Click -= value; }
        }

        public CurrentPlayerControl()
        {
            InitializeComponent();
        }

        public void PlaceCards(List<string> cards)
        {
            NombreCarteMain = 0;
            ValeurCarteMain = 0;
            int i = 16;
            foreach (string cardPath in cards)
            {
                i--;
                CarteButton carte = new CarteButton();
                string path = Path.GetDirectoryName(Application.ExecutablePath);
                Image image = Image.FromFile(path + "\\..\\..\\Resources\\" + cardPath + ".jpg");
                carte.CardName = cardPath;
                carte.BackgroundImage = image;
                carte.BackgroundImageLayout = ImageLayout.Center;
                carte.Width = 79;
                carte.Height = 110;
                carte.Left = 40 * i;
                carte.Top = 25;
                carte.Click += OnCardClick;
                carteButtons.Add(carte);
                this.panel1.Controls.Add(carte);
            }
        }

        private void OnCardClick(object sender, EventArgs e)
        {
            if (!(sender is CarteButton))
            {
                return;
            }
            buttonProchainJoueur.Enabled = false;
            CarteButton CarteClicked = (CarteButton)sender;
            string carte = CarteClicked.CardName;
            if (Etat == 0)
            {
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
                    CartesJouees.Add(carte);
                    switch (valeur)
                    {
                        case 14:
                            buttonProchainJoueur.Enabled = true;
                            break;
                        case 13:
                            if (NombreCarteMain == NombreCarteJouer || NombreCarteMain == NombreCarteJouer - 1 || NombreCarteJouer == 0)
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
            } else
            {
                Etat--;
                NomCarteMain = carte;
                foreach (var item in carteButtons)
                {
                    item.Enabled = true;
                }
                CarteClicked.Enabled = false;
                buttonProchainJoueur.Enabled = true;
            }
        }

        public void ResetMain()
        {
            ValeurCarteMain = 0;
            NombreCarteMain = 0;
            CartesJouees.Clear();
            foreach (var button in carteButtons)
            {
                button.Enabled = true;
            }
            buttonProchainJoueur.Enabled = true;
        }

        public void ProchainJoueur()
        {
            foreach (var item in carteButtons)
            {
                this.panel1.Controls.Remove(item);
            }
        }

        public void ChangeNomJoueur(string nom)
        {
            nomJoueur.Text = nom;
        }

        public void ChangePositionJoueur(string position)
        {
            positionJoueur.Text = position;
        }
    }

    public class CarteButton : Button
    {
        public string CardName { get; set; }
    }
}
