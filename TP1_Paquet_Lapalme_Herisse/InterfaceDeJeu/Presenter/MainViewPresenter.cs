using InterfaceDeJeu.Model;
using InterfaceDeJeu.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDeJeu.Presenter
{
    public class MainViewPresenter
    {
        private readonly IMainView mainView;

        private List<Joueur> joueurs = new List<Joueur>();

        private int nombreCarteJouer = 0;
        private int valeurCarteJouer = 0;
        private List<string> carteJouer = new List<string>();
        private Joueur dernierJoueur = null;

        public MainViewPresenter(IMainView aMainView)
        {
            mainView = aMainView;

            mainView.Load += StartFirstGame;
            mainView.NextPlayer += NextPlayer;
            mainView.ResetHand += ResetHand;
        }

        private void NextPlayer(object sender, EventArgs e)
        {
            if (mainView.GetEtat() == 3 || mainView.GetEtat() == 2)
            {
                foreach (var carte in joueurs[0].SaMain)
                {
                    if (carte.NomCarte().Equals(mainView.GetNomCarteMain()))
                    {
                        Carte tmp = carte;
                        joueurs[0].SaMain.Remove(tmp);
                        joueurs[3].SaMain.Add(tmp);
                        joueurs[3].SaMain.Sort();
                        break;
                    }
                }
                RotatePlayersCounterClockwise();
                if (mainView.GetEtat() == 3)
                {
                    RotatePlayerClockwise();
                }
            }
            else if (mainView.GetEtat() == 1)
            {
                mainView.SetEtat(0);
                foreach (Carte carte in joueurs[0].SaMain)
                {
                    if (carte.NomCarte().Equals(mainView.GetNomCarteMain()))
                    {
                        Carte tmp = carte;
                        joueurs[0].SaMain.Remove(tmp);
                        joueurs[1].SaMain.Add(tmp);
                        joueurs[1].SaMain.Sort();
                        break;
                    }
                }
                RotatePlayerClockwise();
            }
            else
            {
                if (mainView.GetNomJoueur().Equals(mainView.GetNomDernierJoueur()))
                {
                    nombreCarteJouer = 0;
                    valeurCarteJouer = 0;
                    carteJouer.Clear();
                    dernierJoueur = null;
                    mainView.ProchainJoueur();
                    changeJoueur();
                } else
                {
                    if (mainView.GetNombreCarteMain() != 0)
                    {
                        nombreCarteJouer = mainView.GetNombreCarteMain();
                        valeurCarteJouer = mainView.GetValeurCarteMain();
                        dernierJoueur = joueurs[0];
                        carteJouer = mainView.GetCartesJouees();
                        foreach (string carteJouer in carteJouer)
                        {
                            foreach (Carte carteJoueur in joueurs[0].SaMain)
                            {
                                if (carteJouer.Equals(carteJoueur.NomCarte()))
                                {
                                    joueurs[0].SaMain.Remove(carteJoueur);
                                    break;
                                }
                            }
                        }
                    }
                    RotatePlayersCounterClockwise();
                }
            }
        }

        private void RotatePlayersCounterClockwise()
        {
            Joueur temp = joueurs[0];
            joueurs.Remove(temp);
            joueurs.Add(temp);
            mainView.ProchainJoueur();
            changeJoueur();
        }

        private void RotatePlayerClockwise()
        {
            Joueur temp = joueurs[3];
            joueurs.Remove(temp);
            joueurs.Insert(0, temp);
            mainView.ProchainJoueur();
            changeJoueur();
        }

        

        private void ResetHand(object sender, EventArgs e)
        {
            mainView.ResetMain();
        }

        private void StartFirstGame(object sender, EventArgs e)
        {
            Joueur A = new Joueur();
            Joueur B = new Joueur();
            Joueur C = new Joueur();
            Joueur D = new Joueur();

            A.Nom = "Albert";
            B.Nom = "Bertrand";
            C.Nom = "Christian";
            D.Nom = "Didier";

            A.Role = Role.President;
            B.Role = Role.Vice_President;
            C.Role = Role.Concierge;
            D.Role = Role.Trou_de_cul;

            joueurs.Add(A);
            joueurs.Add(B);
            joueurs.Add(C);
            joueurs.Add(D);

            distributeCards();
            changeJoueur();
            mainView.SetEtat(4);
        }

        private void distributeCards()
        {
            Main mainA = new Main();
            Main mainB = new Main();
            Main mainC = new Main();
            Main mainD = new Main();

            Paquet paquet = new Paquet();
            paquet.Brasser();

            for (int i = 0; i < 13; i++)
            {
                mainA.AddCarte(paquet.Tirer());
                mainB.AddCarte(paquet.Tirer());
                mainC.AddCarte(paquet.Tirer());
                mainD.AddCarte(paquet.Tirer());
            }
            mainA.AddCarte(paquet.Tirer());
            mainB.AddCarte(paquet.Tirer());

            joueurs[0].SaMain = mainA;
            joueurs[1].SaMain = mainB;
            joueurs[2].SaMain = mainC;
            joueurs[3].SaMain = mainD;

            joueurs[0].SaMain.Sort();
            joueurs[1].SaMain.Sort();
            joueurs[2].SaMain.Sort();
            joueurs[3].SaMain.Sort();

            Carte carteDonne1 = joueurs[3].SaMain[11];
            Carte carteDonne2 = joueurs[3].SaMain[12];
            Carte carteDonne3 = joueurs[2].SaMain[12];

            joueurs[3].SaMain.Remove(carteDonne1);
            joueurs[3].SaMain.Remove(carteDonne2);
            joueurs[2].SaMain.Remove(carteDonne3);

            joueurs[0].SaMain.Add(carteDonne1);
            joueurs[0].SaMain.Add(carteDonne2);
            joueurs[1].SaMain.Add(carteDonne3);

            joueurs[0].SaMain.Sort();
            joueurs[1].SaMain.Sort();
        }

        private void changeJoueur()
        {
            //LastCardPlayedEventArgs lastCardPlayedArgs = CreateLastCardPlayedArgs(carteJouer, dernierJoueur);
            
            List<string> main = new List<string>();
            foreach (Carte carte in joueurs[0].SaMain)
            {
                main.Add(carte.NomCarte());
            }
            mainView.ChangeCurrentJoueur(joueurs[0].Nom, joueurs[0].Role.ToString(), main, valeurCarteJouer, nombreCarteJouer);
            mainView.ChangeOtherJoueur1(joueurs[1].Nom, joueurs[1].Role.ToString(), joueurs[1].SaMain.Count);
            mainView.ChangeOtherJoueur2(joueurs[2].Nom, joueurs[2].Role.ToString(), joueurs[2].SaMain.Count);
            mainView.ChangeOtherJoueur3(joueurs[3].Nom, joueurs[3].Role.ToString(), joueurs[3].SaMain.Count);
            string nom = dernierJoueur is null ? "" : dernierJoueur.Nom;
            string position = dernierJoueur is null ? "" : dernierJoueur.Role.ToString();
            mainView.ChangeLastCardPlayed(nom, position, carteJouer);
        }
    }
}
