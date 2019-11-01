using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteLibrairie
{
    public class Main : List<Carte>
    {
        // Ajouter des carte a la main
        private void AddCarte(Carte c)
        {
            if (Contains(c))
            {
                string message = $"erreur la Carte est deja dans la main  dans la position {this[IndexOf(c)]}";
                System.Console.WriteLine(message);
                //throw new ArgumentException(message);
            }
            else
            {
                Add(c);
                // stats[(int)e.EmployeeType]++;
            }
        }

        // deposer des cartes sur la pile 
        public Carte[] Deposer(params Carte[] carte)
        {
            List<Carte> tmp = new List<Carte>();
            foreach (Carte c in carte)
            {
                if (Contains(c))
                {
                    /*if (carte == null)
                        carte[0] = c;
                    else
                        carte.ToList().Add(c);*/
                    tmp.Add(c);                      
                    Remove(c);
                }
            }
            if (tmp.Count == 0)
            {
                throw new System.ArgumentException("Cartes ne sont pas presents dans la main");
            }
            return tmp.ToArray();
        }
        public static Main operator +(Main m, Carte c)
        {
            m.AddCarte(c);
            return m;
        }


        //sorte avec de la plus forte a la plus faible avec le compare to du strut carte (pas teste )
        public void SortMain()
        {
            Sort((carte1, carte2) => carte1.CompareTo(carte2));
        }

        public override string ToString()
        {
            String message = "Voici ta main \n ";

            foreach (Carte c in this)
                message += $"{c.ToString()} \n";
            return message;
        }
    }   

        

    
}
