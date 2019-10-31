using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    class productdatabase
    {
        public string aantal { get; set; }
        public string productnaam { get; set; }
        public string productdetails { get; set; }

        public productdatabase(string aantal1, string productnaam1, string productdetails1)
        {
            aantal = aantal1;
            productnaam = productnaam1;
            productdetails = productdetails1;
        }
    }
}

