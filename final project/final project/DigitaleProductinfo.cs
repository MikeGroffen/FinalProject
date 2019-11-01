using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    class DigitaleProductinfo
    {
        public string titel;
        public string beschrijving;
        public float prijs;
        public string downloadlink;

        public DigitaleProductinfo(string titel1, string beschrijving1, float prijs1, string downloadlink1)
        {
            titel = titel1;
            beschrijving = beschrijving1;
            prijs = prijs1;
            downloadlink = downloadlink1;
        }
    }
}
