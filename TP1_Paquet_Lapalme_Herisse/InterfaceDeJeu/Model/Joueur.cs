﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteLibrairie.Model
{
    public class Joueur
    {
        public string Nom { get; set; }
        public Role Role { get; set; }
        public Main SaMain { get; set; }
    }
}