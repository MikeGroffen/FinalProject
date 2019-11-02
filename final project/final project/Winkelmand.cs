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
    partial class Winkelmand : Form
    {
        public Winkelmand()
        {
            InitializeComponent();
        }

        public static List<SaleLinesItem> productdb = new List<SaleLinesItem>();

        public void addtochart(string aantal, string product, string productdetails, float prijs, string producttype, string downloadlink)
        {
            productdb.Add(new SaleLinesItem(aantal, product, productdetails, prijs, producttype, downloadlink));
        }

        public void showwinkelwagen()
        {
            datagrid();
        }

        private void datagrid()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Productnaam";
            dataGridView1.Columns[1].Name = "ProductBeschrijving";
            dataGridView1.Columns[2].Name = "Prijs";
            dataGridView1.Columns[3].Name = "Type";

            foreach (SaleLinesItem productinfo in productdb)
            {
                dataGridView1.Rows.Add(productinfo.productnaam, productinfo.productdetails, productinfo.prijs, productinfo.producttype);
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex != productdb.Count + 1 && e.RowIndex != -1)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[4].Value == null) { }
                else
                {
                    productdb.RemoveAt(e.RowIndex);
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dataGridView1.Rows.Clear();
        }
    }
}
