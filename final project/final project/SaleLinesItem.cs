using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public class SaleLinesItem
    {
        public string aantal         { get; set; }
        public string productnaam    { get; set; }
        public string productdetails { get; set; }
        public float  prijs          { get; set; }
        public string producttype    { get; set; }
        public string downloadlink   { get; set; }

        public SaleLinesItem(string aantal1, ProductInformatie product)
        {
            aantal = aantal1;
            productnaam = product.titel;
            productdetails = product.beschrijving;
            prijs = product.prijs;
            producttype = product.type;
            downloadlink = product.downloadlink;
        }

        public float quantitypricecalc()
        {
            return int.Parse(aantal) * prijs;
        }
    }
}
