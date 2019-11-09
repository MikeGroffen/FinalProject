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
        private string keys;
        
        public Digitaleverzending(Verzendingsinterface verz, SaleLinesItem product) : base(verz)
        {
            titel = product.productnaam;
            downloadlink = product.downloadlink;
            keys = DownloadKeys(product);
        }

        public override void StuurEmail()
        {
            base.StuurEmail();
            MessageBox.Show(digitaleverzendingsinfo(),"Email voor gebruiker van digitale product");
        }

        public string DownloadKeys(SaleLinesItem product)
        {
            Random random = new Random();
            string keys = "Keys for download: " + "\n";
            string aantal = product.aantal;
            int a = int.Parse(aantal);
            for (int i = 0; i < a; i++)
            {
                keys = keys + "Key: " + base.stringgenerator(random.Next()) + "\n";
            }
            return keys;
        }
        public string digitaleverzendingsinfo()
        {
            return titel + "\n" + "Downloadlink: " + downloadlink +"\n" + keys /*"Key: " + base.stringgenerator()*/;
        }
    }
}
