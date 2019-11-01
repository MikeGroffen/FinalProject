using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    class VerificatieEmail : Verzendingsinterface
    {
        public override void StuurEmail()
        {
            MessageBox.Show("De betaling is geslaagd!");
        }
    }
}
