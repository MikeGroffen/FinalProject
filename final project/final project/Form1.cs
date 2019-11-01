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
        Winkelmandje w = new Winkelmandje();
        Gebruiker g = new Gebruiker();
        Product p = new Product();

        public Form1()
        {
            InitializeComponent();
            p.product();
            datagrid();
        }

        private void datagrid()
        {
            dataGridView3.ColumnCount = 3;
            dataGridView3.Columns[0].Name = "Productnaam";
            dataGridView3.Columns[1].Name = "ProductBeschrijving";
            dataGridView3.Columns[2].Name = "Prijs";

            foreach (ProductInformatie productinfo in p.producten)
            {
                dataGridView3.Rows.Add(productinfo.titel, productinfo.beschrijving, productinfo.prijs);
            }

            DataGridViewTextBoxColumn txtbox = new DataGridViewTextBoxColumn();
            dataGridView3.Columns.Add(txtbox);
            txtbox.HeaderText = "Aantal";
            txtbox.Name = "txtbox";

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView3.Columns.Add(btn);
            btn.HeaderText = "Toevoegen aan winkelmandje";
            btn.Text = "toevoegen aan winkelmandje";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            
            dataGridView3.Columns[0].ReadOnly = true;
            dataGridView3.Columns[1].ReadOnly = true;
            dataGridView3.Columns[2].ReadOnly = true;

            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int parsedValue;
            if(e.ColumnIndex == 4 && e.RowIndex != p.producten.Count + 1)
            {
                if (dataGridView3.Rows[e.RowIndex].Cells[3].Value == null) { }
                else
                {
                    string value = dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString();

                    // kijken of het textbox aantal wel een nummer bevat
                    if (int.TryParse(value, out parsedValue))
                    {
                        MessageBox.Show(value + " item(s) toegevoegd aan winkelmandje!");
                        w.addtochart(value, p.producten[e.RowIndex].titel, p.producten[e.RowIndex].beschrijving);
                    }
                    else
                    {
                        MessageBox.Show("ongeldig aantal!");
                    }
                }
            }
        }
        
        //winkelmandje knop
        private void button2_Click(object sender, EventArgs e)
        {
            w.showwinkelwagen();
        }

        //betalen knop, bij klikken op deze knop moet de gebruiker eerst gegevens invullen alvorens de betaling word gestart.
        private void button3_Click(object sender, EventArgs e)
        {
            g.Show();
            this.Visible = false;
        }

       
    }
}
