using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    class Winkelmandje
    {
        public static List<SaleLinesItem> productdb = new List<SaleLinesItem>();

        public void addtochart(string aantal, string product, string productdetails, float prijs, string producttype)
        {
            productdb.Add(new SaleLinesItem(aantal, product, productdetails, prijs, producttype));
        }

        public void showwinkelwagen()
        {
            string items = ""; 
            foreach (SaleLinesItem product in productdb)
            { items = items + "ProductNaam: " + product.productnaam + "\n" + "Aantal: " + product.aantal + "\n" + "ProductDetails: " + product.productdetails + "\n" + "\n";} 
            MessageBox.Show(items );
        }
    }
}
