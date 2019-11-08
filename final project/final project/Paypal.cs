﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    class Paypal : Betaling
    {
        public override void Betaalmethode(float prijs, List<SaleLinesItem> productendb)
        {
            string message = "Kies of de betaling geslaagd is of niet. ja voor geslaagd, nee voor gefaald.";
            string title = "Paypal";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Totaalprijs: " + prijs + " Euro" + "\n" + message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Sales.ActiveForm.Close();
                Verzendingsinterface verzend = base.verzending(0, productendb);
                verzend.StuurEmail();
            }
            else
            {
                Sales.ActiveForm.Close();
                Winkelmand w = new Winkelmand();
                w.wm.productdb = productendb;
                w.Visible = true;
                w.showwinkelwagen();
            }
            
        }
    }
}
