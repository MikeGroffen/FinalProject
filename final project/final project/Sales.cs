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
    public partial class Sales : Form
    {
        private Betaling _betaling;

        public Sales()
        {
            InitializeComponent();
        }

        //de paypal knop
        private void button1_Click(object sender, EventArgs e)
        {
            _betaling = new Paypal();
            _betaling.Betaalmethode();
        }

        //de pinpas knop
        private void button2_Click(object sender, EventArgs e)
        {
            _betaling = new Pinpas();
            _betaling.Betaalmethode();
        }

        //de creditcard knop
        private void button3_Click(object sender, EventArgs e)
        {
            _betaling = new CreditCard();
            _betaling.Betaalmethode();
        }

        //sluit de window en brengt je terug naar store
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Gebruiker g = new Gebruiker();
            g.Show();
            this.Visible = false;
        }
    }
}
