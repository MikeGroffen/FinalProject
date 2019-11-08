using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    public class Verzend
    {
        public int fysiekeproducten;
        public int digitaleproducten;
        //kijkt of we digitale of fysieke producten hebben creert nieuwe decoratorconstrucor dysiek of digitaal. begint met constructor verificatieEmail.
        public Verzendingsinterface verzending(int i, List<SaleLinesItem> productendb)
        {
            if (i < productendb.Count)
            {
                if (productendb[i].producttype == "Fysiek")
                {
                    FysiekProduct();
                    return new Fysiekeverzending(verzending(i + 1, productendb), productendb[i]);
                }
                if (productendb[i].producttype == "Digitaal")
                {
                    DigitaalProduct();
                    return new Digitaleverzending(verzending(i + 1, productendb), productendb[i]);
                }
            }
            return new VerificatieEmail();
        }

        public void FysiekProduct()
        {
            fysiekeproducten++;
        }

        public void DigitaalProduct()
        {
            digitaleproducten++;
        }
        public void verzend(bool isgeslaagd,List<SaleLinesItem> productendb)
        {
            if (isgeslaagd)
            {
                Sales.ActiveForm.Close();
                Verzendingsinterface verzend = verzending(0, productendb);
                verzend.StuurEmail();
            }
            else
            {
                Sales.ActiveForm.Close();
                Winkelmand w = new Winkelmand();
                w.wm.productdb = productendb;
                w.Visible = true;
                w.showwinkelwagen();
            }
        }
    }
}
