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
    public partial class Gebruiker : Form
    {
        List<SaleLinesItem> productendb;

        public Gebruiker(List<SaleLinesItem> productendb1)
        {
            InitializeComponent();
            productendb = productendb1;
        }

        //verder knop
        private void button1_Click(object sender, EventArgs e)
        {
            gebruiker();
            MessageBox.Show("Welkom " + voornaam + " " + achternaam);
            bool bevatfysiekproduct = false;

            foreach (SaleLinesItem product in productendb)
            {
                if (product.producttype == "Fysiek") { bevatfysiekproduct = true; }
            }

            if (bevatfysiekproduct)
            {
                Verzendingsinformatie v = new Verzendingsinformatie(productendb);
                v.Show();
            }
            else
            {
                Sales sale = new Sales(productendb);
                sale.Show();
            }
            this.Visible = false;
        }

        public string voornaam;
        public string achternaam;
        public string telefoonummer;
        public string email;

        public void gebruiker()
        {
            voornaam = textBox1.Text.ToString();
            achternaam = textBox2.Text.ToString();
            telefoonummer = textBox3.Text.ToString();
            email = textBox4.Text.ToString();
        }

        //terug knop
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
