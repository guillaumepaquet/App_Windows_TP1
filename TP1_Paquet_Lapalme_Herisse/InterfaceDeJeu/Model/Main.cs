using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDeJeu.Model
{
    public class Main : List<Carte>
    {
        // Ajouter des carte a la main
        public void AddCarte(Carte c)
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
