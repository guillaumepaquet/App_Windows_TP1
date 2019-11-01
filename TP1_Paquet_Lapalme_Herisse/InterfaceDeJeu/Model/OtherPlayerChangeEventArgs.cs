using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDeJeu.Model
{
    public class OtherPlayerChangeEventArgs
    {
        public string Nom { get; set; }

        public string Position { get; set; }

        public int NombreCarte { get; set; }
    }
}
