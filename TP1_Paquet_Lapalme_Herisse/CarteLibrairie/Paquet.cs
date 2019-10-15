using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteLib
{
    public class Paquet
    {
        private List<Carte> paquet = new List<Carte>();
        private static Random r = new Random();

        public Paquet()
        {
            foreach (Couleur couleur in Enum.GetValues(typeof(Couleur)))
            {
                for (int i = 1; i <= 13; i++)
                    paquet.Add(new Carte(couleur, i));
            }
        }

        public void Ajouter(Carte carte)
        {
            paquet.Add(carte);
        }

        public Carte? Tirer()
        {
            if(paquet.Count > 0) {
                int i = r.Next(paquet.Count);
                Carte carte = paquet[i];
                paquet.Remove(carte);
                return carte;
            }
            return null;
        }

        public string Afficher()
        {
            int i = 0;
            string message = "";
            foreach (var item in paquet)
            {
                message += item + "\n";
                i++;
            }
            return message;
        }

        public void Echanger(int carte1, int carte2)
        {
            Carte tmp = paquet[carte1];
            paquet[carte1] = paquet[carte2];
            paquet[carte2] = tmp;
        }

        public void Brasser()
        {
            int n = paquet.Count;
            while (n > 1)
            {
                n--;
                int k = r.Next(n + 1);
                Echanger(k, n);
            }
        }
    }
}
