using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteLibrairie
{
    public class Paquet
    {
        private List<Carte> paquet = new List<Carte>();
        private static Random r = new Random();

        public Paquet()
        {
            foreach (Couleur couleur in Enum.GetValues(typeof(Couleur)))
            {
                if(couleur != Couleur.ROUGE && couleur != Couleur.NOIR)
                    for (int i = 1; i <= 13; i++)
                        paquet.Add(new Carte(couleur, (Valeur)i));
            }
            paquet.Add(new Carte(Couleur.NOIR, (Valeur)14));
            paquet.Add(new Carte(Couleur.ROUGE, (Valeur)14));

        }

        //Rajouter les carte fini de la pile au Paquet
        public void Ajouter(params Carte[] carte)
        {
            foreach (Carte c in carte)
            {
                paquet.Add(c);
            }
        }
        
        public Carte Tirer()
        {
            if(paquet.Count > 0) {
                int i = r.Next(paquet.Count);
                Carte carte = paquet[i];
                paquet.Remove(carte);
                return carte;
            }
            throw new System.ArgumentException("Paquet vide"); ;
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
