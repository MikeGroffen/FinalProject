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

        private void button1_Click(object sender, EventArgs e)
        {
            gebruiker();
            MessageBox.Show("Welkom " + voornaam + " " + achternaam);
            if(true)
            {
                Sales sale = new Sales();
                sale.Show();
            }
            else { }// hier gaan we gelijk door naar de betaling omdat het alleen digitale producten bevat
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Visible = false;
        }
    }
}
