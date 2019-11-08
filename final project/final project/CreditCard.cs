using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public class CreditCard : Betaling
    {
        public bool resultaat = false;
        public bool geslaagd = false;
        public override void Betaalmethode(float prijs,List<SaleLinesItem> productendb)
        {
            List<SaleLinesItem> meegegevenproductendb = productendb;
            string message = "Kies of de betaling geslaagd is of niet. ja voor geslaagd, nee voor gefaald.";
            string title = "Creditcard";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Totaalprijs: " + prijs + " Euro" + "\n" + message, title, buttons);
            if (result == DialogResult.Yes)
            {
                resultaat = true;
                /*Sales.ActiveForm.Close();
                Verzendingsinterface verzend = base.verzending(0,productendb);
                verzend.StuurEmail();*/
            }
            else
            {
                resultaat = false;
                /*Sales.ActiveForm.Close();
                Winkelmand w = new Winkelmand();
                w.wm.productdb = productendb;
                w.Visible = true;
                w.showwinkelwagen();*/
            }
            Resultaat(resultaat, meegegevenproductendb);
        }

        public void Resultaat(bool resultaat, List<SaleLinesItem> productendb)
        {
            if (resultaat)
            {
                geslaagd = true;
                Sales.ActiveForm.Close();
                Verzendingsinterface verzend = base.verzending(0, productendb);
                verzend.StuurEmail();
            }
            else
            {
                geslaagd = false;
                Sales.ActiveForm.Close();
                Winkelmand w = new Winkelmand();
                w.wm.productdb = productendb;
                w.Visible = true;
                w.showwinkelwagen();
            }
        }
    }
}
