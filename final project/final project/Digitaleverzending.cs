using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    class Digitaleverzending : Verzending
    {
        private string titel;
        private string downloadlink;
        
        public Digitaleverzending(Verzendingsinterface verz, SaleLinesItem product) : base(verz)
        {
            titel = product.productnaam;
            downloadlink = product.downloadlink;
        }

        public override void StuurEmail()
        {
            base.StuurEmail();
            MessageBox.Show(digitaleverzendingsinfo(),"Email voor gebruiker van digitale product");
        }

        public string digitaleverzendingsinfo()
        {
            return titel + "\n" + "Downloadlink: " + downloadlink +"\n" + "Key: " + base.stringgenerator();
        }
    }
}
