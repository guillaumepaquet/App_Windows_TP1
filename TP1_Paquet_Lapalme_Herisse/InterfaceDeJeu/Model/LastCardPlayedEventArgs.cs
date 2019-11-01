using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDeJeu.Model
{
    public class LastCardPlayedEventArgs
    {
        public List<string> LastCardPlayed { get; set; }

        public string Nom { get; set; }

        public string Position { get; set; }
    }
}
