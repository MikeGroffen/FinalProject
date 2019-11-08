using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace final_project
{
    public class sales
    {
        public float TotalPricecalc(List<SaleLinesItem> productendb1)
        {
            float totaalbedrag = 0;
            bool verzendingskosten = false;
            foreach (SaleLinesItem product in productendb1)
            {
                if (product.producttype == "Fysiek") { verzendingskosten = true; }
                totaalbedrag += product.quantitypricecalc();
            }

            // als het een fysiekproduct bevat voegen we verzendingskosten van 2,50 bij.
            if (verzendingskosten)
                return totaalbedrag + 2.50f;
            else return totaalbedrag;
        }
    }

    public partial class Sales : Form
    {
        private Betaling _betaling;
        List<SaleLinesItem> productendb;
        sales s = new sales();
        Verzend v = new Verzend();
        private bool isgeslaagd;

        public Sales(List<SaleLinesItem> productendb1)
        {
            InitializeComponent();
            productendb = productendb1;
        }

        //normaal doen we natuurlijk niet dit maar kijken we of de betaling wel echt geslaagd is
        // in de betaalmethode zal je dan ook geen isbetalingsgeslaagd mee willen geven aangezien deze 
        //methode nu terugstuurt of de betaling geslaagd is
        private bool Isbetalinggeslaagd()
        {
            string message = "Kies of de betaling geslaagd is of niet. ja voor geslaagd, nee voor gefaald.";
            string title = "Creditcard";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Totaalprijs: " + s.TotalPricecalc(productendb) + " Euro" + "\n" + message, title, buttons);
            if (result == DialogResult.Yes)
            { return true; }
            else return false;
        }

        //de paypal knop
        private void button1_Click(object sender, EventArgs e)
        {
            _betaling = new Paypal();
            isgeslaagd = _betaling.Betaalmethode(s.TotalPricecalc(productendb),productendb,Isbetalinggeslaagd());
            v.verzend(isgeslaagd,productendb);
        }

        //de pinpas knop
        private void button2_Click(object sender, EventArgs e)
        {
            _betaling = new Pinpas();
            isgeslaagd =_betaling.Betaalmethode(s.TotalPricecalc(productendb), productendb, Isbetalinggeslaagd());
            v.verzend(isgeslaagd,productendb);
        }

        //de creditcard knop
        private void button3_Click(object sender, EventArgs e)
        {
            _betaling = new CreditCard();
            isgeslaagd = _betaling.Betaalmethode(s.TotalPricecalc(productendb),productendb, Isbetalinggeslaagd());
            v.verzend(isgeslaagd,productendb);
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
