using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //toevoegen aan mandje product 1
        private void button1_Click(object sender, EventArgs e)
        {
            int parsedValue;

            // kijken of het textbox aantal wel een nummer bevat
            if (int.TryParse(textBox1.Text, out parsedValue))
            {
                MessageBox.Show(textBox1.Text.ToString() + " item(s) toegevoegd aan winkelmandje!");
            }
            else
            {
                MessageBox.Show("ongeldig aantal!");
            }

            //hier programma aanroepen dat winkelmandje enz gooit..
        }

        
        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        //link voor productinfo 1
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //stuur ze door naar de productinformatie.
            MessageBox.Show("productinformatie, moeten we uit een text file halen ofzo, maar ja dat kan dus hier ;p");
        }
    }
}
