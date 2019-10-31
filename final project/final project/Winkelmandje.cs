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
        public void showwinkelwagen()
        {
            SaleLinesItem s = new SaleLinesItem();
            string items = "";
            foreach (productdatabase product in s.productdb)
            { items = items + "Aantal: " + product.aantal + "ProductNaam: " + product.productnaam + "ProductDetails: " + product.productdetails + "\n";  Debug.WriteLine(product.aantal); } 
            MessageBox.Show(items);
        }
    }
}
