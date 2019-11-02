using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    class Fysiekeverzending : Verzending
    {
        private string productnaam;
        private string productinformatie;
        private string aantal;

        public Fysiekeverzending(Verzendingsinterface verz, SaleLinesItem product) : base(verz)
        {
            productnaam = product.productnaam;
            productinformatie = product.productdetails;
            aantal = product.aantal;
        }

        public override void StuurEmail()
        {
            base.StuurEmail();
            MessageBox.Show(fysiekeverzendinginfo(), "Email voor bedrijven voor het verzenden van fysiek product");
        }

        public string fysiekeverzendinginfo()
        {
            return aantal + " x " + productnaam + "\n" + productinformatie + "\n";
        }
    }
}
