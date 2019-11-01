using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class Verzendingsinformatie : Form
    {
        public Verzendingsinformatie()
        {
            InitializeComponent();
        }

        //verder knop
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Sales s = new Sales();
            s.Show();
        }

        //terug naar store knop
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
