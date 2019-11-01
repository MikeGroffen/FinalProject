using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    class SaleLinesItem
    {
        public string aantal { get; set; }
        public string productnaam { get; set; }
        public string productdetails { get; set; }
        public float prijs { get; set; }
        public string producttype { get; set; }

        public SaleLinesItem(string aantal1, string productnaam1, string productdetails1, float prijs1, string producttype1)
        {
            aantal = aantal1;
            productnaam = productnaam1;
            productdetails = productdetails1;
            prijs = prijs1;
            producttype = producttype1;
        }

        public float quantitypricecalc ()
        {
            return int.Parse(aantal) * prijs;
        }
    }
}
