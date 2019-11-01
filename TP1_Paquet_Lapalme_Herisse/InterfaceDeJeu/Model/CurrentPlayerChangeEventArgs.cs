using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDeJeu.Model
{
    public class CurrentPlayerChangeEventArgs
    {
        public string Nom { get; set; }

        public string Position { get; set; }

        public List<string> Main { get; set; }

        public int ValeurCarteJouer { get; set; }

        public int NombreCarteJouer { get; set; }
    }
}
