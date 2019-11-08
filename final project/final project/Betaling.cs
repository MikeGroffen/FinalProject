using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    public abstract class Betaling
    {
        public abstract bool Betaalmethode(float prijs, List<SaleLinesItem> productend, bool isgeslaagd);
        
    }
}
