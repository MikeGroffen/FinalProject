﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //toevoegen aan mandje product 1
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item(s) toegevoegd aan winkelmandje!");
            //hier programma aanroepen dat winkelmandje enz gooit..
        }

        //aantal product 1 invul box
        private void Form1_Load(object sender, EventArgs e)
        {
            //hier verkrijg je de hoeveelheid dat ze willen
        }

        //link voor productinfo 1
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //stuur ze door naar de productinformatie.
        }
    }
}
