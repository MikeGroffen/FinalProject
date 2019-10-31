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
        //pruduct en aantal, 1 sale bestaat uit 1 of meerdere salelines item.

        public List<productdatabase> productdb = new List<productdatabase>();

        public void productline(string aantal, string product, string productdetails)
        {
            productdb.Add(new productdatabase(aantal, product, productdetails));  
        }
    }
}
