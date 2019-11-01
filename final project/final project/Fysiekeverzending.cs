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
        public Fysiekeverzending(Verzendingsinterface verz) : base(verz)
        {

        }

        public override void StuurEmail()
        {
            base.StuurEmail();
            MessageBox.Show("Fysieke verzendings informatie voor Bedrijven");
        }
    }
}
