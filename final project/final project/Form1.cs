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
        Winkelmand w;
        Gebruiker g;
        Product p;

        public Form1()
        {
            InitializeComponent();
            w = new Winkelmand();
            //g = new Gebruiker(w.productdb);
            p = new Product();
            p.product();
            datagrid();
        }

        private void datagrid()
        {
            dataGridView3.ColumnCount = 4;
            dataGridView3.Columns[0].Name = "Productnaam";
            dataGridView3.Columns[1].Name = "ProductBeschrijving";
            dataGridView3.Columns[2].Name = "Prijs";
            dataGridView3.Columns[3].Name = "Type";

            foreach (ProductInformatie productinfo in p.producten)
            {
                dataGridView3.Rows.Add(productinfo.titel, productinfo.beschrijving, productinfo.prijs, productinfo.type);
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
            dataGridView3.Columns[3].ReadOnly = true;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int parsedValue;

            //checkt of colum nummer 5 is, check of de rowindex waar we op klikken binnen de grenzen vaan de producten list is
            if(e.ColumnIndex == 5 && e.RowIndex != p.producten.Count + 1 && e.RowIndex != -1)
            {
                if (dataGridView3.Rows[e.RowIndex].Cells[4].Value == null) { MessageBox.Show("Vul een aantal in!"); }
                else
                {
                    string value = dataGridView3.Rows[e.RowIndex].Cells[4].Value.ToString();

                    // kijken of het textbox aantal wel een nummer bevat
                    if (int.TryParse(value, out parsedValue))
                    {
                        if (int.Parse(value) > 0)
                        {
                            MessageBox.Show(value + " item(s) toegevoegd aan winkelmandje!");
                            w.addtochart(value,p.producten[e.RowIndex]);// p.producten[e.RowIndex].titel, p.producten[e.RowIndex].beschrijving, p.producten[e.RowIndex].prijs, p.producten[e.RowIndex].type, p.producten[e.RowIndex].downloadlink);
                        }
                        else MessageBox.Show("Ongeldig aantal. \n Aantal mag niet 0 of kleiner zijn!");
                    }
                    else
                    {
                        MessageBox.Show("Ongeldig aantal!");
                    }
                }
            }
        }
        
        //winkelmandje knop
        private void button2_Click(object sender, EventArgs e)
        {
            w.Visible = true;
            w.showwinkelwagen();
        }

        //betalen knop, bij klikken op deze knop moet de gebruiker eerst gegevens invullen alvorens de betaling word gestart.
        private void button3_Click(object sender, EventArgs e)
        {
            if (w.productdb.Count == 0)
            { MessageBox.Show("Geen producten in winkelmandje! \n Voeg eerst producten toe aan u winkelmandje alvorens u verder gaat."); }
            else { g = new Gebruiker(w.productdb); g.Show(); }
        }

       
    }
}
