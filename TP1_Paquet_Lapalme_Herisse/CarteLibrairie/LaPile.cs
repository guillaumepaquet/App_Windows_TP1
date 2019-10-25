using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteLibrairie
{
    class LaPile : List<Carte>, IComparable<Carte[]>
    {
        // Mettre en memoire les dernieres cartes deposer pour comparer avec les nouvelles cartes deposer sur la pile
        public Carte[] DerniereCartesDepose { get; set; }

        // comparer les nouvelles cartes avec les derniers cartes deposer pour les accepter ou non (pas terminer) 
        public int CompareTo(Carte[] other)
        {
            int k = DerniereCartesDepose.Length.CompareTo(other.Length);

            if(k == 0)
            {
                Carte carte = DerniereCartesDepose.First();
                
            }

            /* if (DerniereCartesDepose.Length == other.Length || (int)other.First().Valeur <= 13)
             {


               int n =  DerniereCartesDepose.First().CompareTo(other.First());
                 if(n == 0 && (int)other.First().Valeur <= 13)
                 {
                     return -1;
                 }
                 return n;

             }
             else
                 return 1;*/
            return 0;
        }

        private void AddCarte(params Carte[] carte)
        {
                foreach (Carte c in carte)
                {
                    this.Add(c);
                }   
        }

        // Ajouter les Nouvelles cartes sur la pile si le compare To ajoute la bonne valeur 
        public static LaPile operator +(LaPile lp, Carte[] c)
        {
            lp.DerniereCartesDepose = c;
            lp.AddCarte(c);
            return lp;
        }

        


    }
}
