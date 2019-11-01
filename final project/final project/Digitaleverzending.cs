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
        public Digitaleverzending(Verzendingsinterface verz) : base(verz)
        {

        }

        public override void StuurEmail()
        {
            base.StuurEmail();
            MessageBox.Show(digitaleverzendingsinfo());//"Digitale verzendings informatie voor gebruiker");
        }

        public string digitaleverzendingsinfo()
        {
            return "Downloadlink: "+ "" + "Key: " + base.stringgenerator();
        }
    }
}
