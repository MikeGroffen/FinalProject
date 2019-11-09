using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    class Verzending : Verzendingsinterface
    {
        private Verzendingsinterface verzend;

        public Verzending(Verzendingsinterface verz)
        {
            verzend = verz;
        }

        public override void StuurEmail()
        {
            verzend.StuurEmail();
        }

        public string stringgenerator(int Seed)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random(Seed);
            char ch;
            for (int i = 0; i < 24; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString();
        }
    }
}
