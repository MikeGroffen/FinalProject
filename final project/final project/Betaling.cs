﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    public abstract class Betaling
    {
        public abstract void Betaalmethode(float prijs);

        //kijkt of we digitale of fysieke producten hebben creert nieuwe decoratorconstrucor dysiek of digitaal. begint met constructor verificatieEmail.
        public Verzendingsinterface verzending(int i)
        {
            if (i < Winkelmand.productdb.Count)
            {
                if (Winkelmand.productdb[i].producttype == "Fysiek")
                {
                    return new Fysiekeverzending(verzending(i + 1),Winkelmand.productdb[i]);
                }
                if (Winkelmand.productdb[i].producttype == "Digitaal")
                {
                    return new Digitaleverzending(verzending(i + 1), Winkelmand.productdb[i]);
                }
            }
            return new VerificatieEmail();
        }
    }
}
