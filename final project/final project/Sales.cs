using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class Sales : Form
    {
        private Betaling _betaling;
        List<SaleLinesItem> productendb;

        public Sales(List<SaleLinesItem> productendb1)
        {
            InitializeComponent();
            productendb = productendb1;
        }

        private float TotalPricecalc(List<SaleLinesItem> productendb1)
        {
            float totaalbedrag = 0;
            bool verzendingskosten = false;
            foreach(SaleLinesItem product in productendb1)
            {
                if (product.producttype == "Fysiek") { verzendingskosten = true; }
               totaalbedrag += product.quantitypricecalc();
            }
        
            // als het een fysiekproduct bevat voegen we verzendingskosten van 2,50 bij.
            if (verzendingskosten)
                return totaalbedrag + 2.50f;
            else return totaalbedrag;
        }

        //de paypal knop
        private void button1_Click(object sender, EventArgs e)
        {
            _betaling = new Paypal();
            _betaling.Betaalmethode(TotalPricecalc(productendb),productendb);
        }

        //de pinpas knop
        private void button2_Click(object sender, EventArgs e)
        {
            _betaling = new Pinpas();
            _betaling.Betaalmethode(TotalPricecalc(productendb),productendb);
        }

        //de creditcard knop
        private void button3_Click(object sender, EventArgs e)
        {
            _betaling = new CreditCard();
            _betaling.Betaalmethode(TotalPricecalc(productendb),productendb);
        }

        //terug knop
        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        //wijzig gegevens knop
        private void button5_Click(object sender, EventArgs e)
        {
            Gebruiker g = new Gebruiker(productendb);
            g.Show();
            this.Visible = false;
        }
    }
}
