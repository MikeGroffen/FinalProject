using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    public class CreditCard : Betaling
    {
        public override bool Betaalmethode(float prijs,List<SaleLinesItem> productendb, bool isgeslaagd)
        {
            if (isgeslaagd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
