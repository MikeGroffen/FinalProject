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
    public class winkelmand
    {
        public List<SaleLinesItem> productdb = new List<SaleLinesItem>();
        public void addtocart(string aantal, ProductInformatie product)// string product, string productdetails, float prijs, string producttype, string downloadlink)
        {
            if (int.Parse(aantal) == 0)
                return;
            //kijkt of we het product al in het winkelmandje hebben, zoja verhoog aantal met nieuwe aantal
            if (productdb.Exists(x => x.productnaam.Contains(product.titel)))
            {
                productdb.Find(x => x.productnaam.Contains(product.titel)).aantal = (int.Parse(productdb.Find(x => x.productnaam.Contains(product.titel)).aantal) + int.Parse(aantal)).ToString();
            }
            else
            {
                productdb.Add(new SaleLinesItem(aantal, product));
            }
        }
    }
    public partial class Winkelmand : Form
    {
        public winkelmand wm = new winkelmand();
        public Winkelmand()
        {
            InitializeComponent();
        }

        //public List<SaleLinesItem> productdb = new List<SaleLinesItem>();

        /*public void addtocart(string aantal, ProductInformatie product)// string product, string productdetails, float prijs, string producttype, string downloadlink)
        {
            if (int.Parse(aantal) == 0)
                return;
            //kijkt of we het product al in het winkelmandje hebben, zoja verhoog aantal met nieuwe aantal
            if (productdb.Exists(x => x.productnaam.Contains(product.titel)))
            {
                productdb.Find(x => x.productnaam.Contains(product.titel)).aantal = (int.Parse(productdb.Find(x => x.productnaam.Contains(product.titel)).aantal) + int.Parse(aantal)).ToString();
            }
            else
            {
                productdb.Add(new SaleLinesItem(aantal, product ));
            }
        }*/

        //laad de tabel met de producten in de winkelwagen
        public void showwinkelwagen()
        {
            datagrid();
        }

        private void datagrid()
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Productnaam";
            dataGridView1.Columns[1].Name = "ProductBeschrijving";
            dataGridView1.Columns[2].Name = "Prijs";
            dataGridView1.Columns[3].Name = "Type";
            dataGridView1.Columns[4].Name = "Aantal";

            foreach (SaleLinesItem productinfo in wm.productdb)
            {
                dataGridView1.Rows.Add(productinfo.productnaam, productinfo.productdetails, productinfo.prijs, productinfo.producttype,productinfo.aantal);
            }
            
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Verwijderen uit winkelmandje";
            btn.Text = "Verwijder uit winkelmandje";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //methode voor wat er gebeurt als de gebruiker op de verwijder uit winkelmand knop klikt
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex != wm.productdb.Count + 1 && e.RowIndex != -1)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[5].Value == null) { }
                else
                {
                    wm.productdb.RemoveAt(e.RowIndex);
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        //winkelmand sluiten knop
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dataGridView1.Rows.Clear();
        }
    }
}
