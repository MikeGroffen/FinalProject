using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    public abstract class Betaling
    {
        public abstract void Betaalmethode(float prijs, List<SaleLinesItem> productend);

        //kijkt of we digitale of fysieke producten hebben creert nieuwe decoratorconstrucor dysiek of digitaal. begint met constructor verificatieEmail.
        public Verzendingsinterface verzending(int i, List<SaleLinesItem> productendb)
        {
            if (i < productendb.Count)
            {
                if (productendb[i].producttype == "Fysiek")
                {
                    return new Fysiekeverzending(verzending(i + 1,productendb),productendb[i]);
                }
                if (productendb[i].producttype == "Digitaal")
                {
                    return new Digitaleverzending(verzending(i + 1, productendb), productendb[i]);
                }
            }
            return new VerificatieEmail();
        }
    }
}
