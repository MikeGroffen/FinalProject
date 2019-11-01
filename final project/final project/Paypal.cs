using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    class Paypal : Betaling
    {
        public override void Betaalmethode(float prijs)
        {
            string message = "Kies of de betaling succesvol is of niet. ja voor succesvol, nee voor gefaald.";
            string title = "Paypal";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Totaalprijs: " + prijs + "\n" + message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Verzendingsinterface verzend = base.verzending(0);
                verzend.StuurEmail();
            }
            else
            {
                Winkelmandje w = new Winkelmandje();
                w.showwinkelwagen();
            }
            Sales.ActiveForm.Close();
        }
    }
}
