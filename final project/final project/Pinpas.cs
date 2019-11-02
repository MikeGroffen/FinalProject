﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    class Pinpas : Betaling
    {
        public override void Betaalmethode(float prijs)
        {
            string message = "Kies of de betaling Geslaagd is of niet. ja voor geslaagd, nee voor gefaald.";
            string title = "Pinpas";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Totaalprijs: " + prijs + "\n" + message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Verzendingsinterface verzend = base.verzending(0);
                verzend.StuurEmail();
            }
            else
            {
                Winkelmand w = new Winkelmand();
                w.showwinkelwagen();
            }
            Sales.ActiveForm.Close();
        }
    }
}
