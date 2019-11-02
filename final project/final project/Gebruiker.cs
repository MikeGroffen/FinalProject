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
        public Gebruiker()
        {
            InitializeComponent();
        }

        //verder knop
        private void button1_Click(object sender, EventArgs e)
        {
            gebruiker();
            MessageBox.Show("Welkom " + voornaam + " " + achternaam);
            bool bevatfysiekproduct = false;

            foreach (SaleLinesItem product in Winkelmand.productdb)
            {
                if (product.producttype == "Fysiek") { bevatfysiekproduct = true; }
            }

            if (bevatfysiekproduct)
            {
                this.Visible = false;
                Verzendingsinformatie v = new Verzendingsinformatie();
                v.Show();
            }
            else
            {
                Sales sale = new Sales();
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
