using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteLibrairie
{
    public class Main : List<Carte>
    {
      /*  public Main()
        {

        }*/
        // Ajouter des carte a la main
        private void AddCarte(Carte c)
        {
            if (base.Contains(c))
            {
                string message = $"erreur la Carte est deja dans la main  dans la position {this[IndexOf(c)]}";
                System.Console.WriteLine(message);
                //throw new ArgumentException(message);
            }
            else
            {
                this.Add(c);
                // stats[(int)e.EmployeeType]++;
            }
        }

        // deposer des cartes sur la pile 
        public Carte[] deposer(params Carte[] carte)
        {

            List<Carte> tmp = new List<Carte>();
            foreach (Carte c in carte)
            {
                if (this.Contains(c))
                {
                    /*if (carte == null)
                        carte[0] = c;
                    else
                        carte.ToList().Add(c);*/
                    tmp.Add(c);
                        

                    this.Remove(c);


                }

            }
            if (tmp.Count == 0)
            {
                throw new System.ArgumentException("Cartes ne sont pas presents dans la main");
            }
            return tmp.ToArray();
        }
        //ajouter des cartes dans la main avec un operator
        public static Main operator +(Main m, Carte c)
        {
            m.AddCarte(c);
            return m;
        }

        public Carte this[Valeur valeur, Couleur couleur]
        {
            get
            {
                foreach (var item in this)
                {
                    if (item.Valeur == valeur && item.Couleur == couleur)
                        return item;

                }
                string message = $"Message de l'indexer get  pour Carte  avec la valeur {valeur} et la couleur {couleur} n'existe pas dans la liste";
                System.Console.WriteLine(message);
                Carte c;



                throw new System.ArgumentException(message);
            }
            /* set
             {
                 //                throw new NotImplementedException();
                 IEmployee searchEmployee = this[identifier];
                 int index = this.IndexOf(searchEmployee);
                 if (index != -1)
                     this[index] = (IEmployee)value;
                 else
                 {
                     string message = $"Message de l'indexer set {identifier} n'existe pas dans la liste";
                     System.Console.WriteLine(message);
                     //throw new ArgumentException(message);
                 }
 */
        }
        //sorte avec de la plus forte a la plus faible avec le compare to du strut carte (pas teste )
        public void SortMain()
        {
            this.Sort((carte1, carte2) => carte1.CompareTo(carte2));
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
