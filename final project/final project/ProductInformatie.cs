﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    class ProductInformatie
    {
        public string titel;
        public string beschrijving;
        public float prijs;
        public string type;

        public ProductInformatie(string titel1, string beschrijving1, float prijs1, string type1)
        {
            titel = titel1;
            beschrijving = beschrijving1;
            prijs = prijs1;
            type = type1;
        }
    }
}