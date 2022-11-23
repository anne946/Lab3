﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Projet
    {

        string numero;
        DateOnly debut;
        int budget;
        string description;
        string employe;

        public string Numero { get => numero; set => numero = value; }
        public DateOnly Debut { get => debut; set => debut = value; }
        public int Budget { get => budget; set => budget = value; }
        public string Description { get => description; set => description = value; }
        public string Employe { get => employe; set => employe = value; }

        public override string ToString()
        {
            return  numero + " " + debut + " " + budget + " " + description + " " + employe;
        }
    }
}
