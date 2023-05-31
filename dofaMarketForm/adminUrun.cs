using dofaMarketForm.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dofaMarketForm
{
    public partial class adminUrun : Form
    {


        MarketDatabaseContext baglantı = new MarketDatabaseContext();
        public adminUrun()
        {
            InitializeComponent();
        }

        private void Urun_Load(object sender, EventArgs e)
        {

        }

        private void adminUrun_Load(object sender, EventArgs e)
        {
            fill();
            FillComboBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void urunlerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fill()
        {
            var products = baglantı.Products.ToList();
            urunlerGrid.DataSource = products;
            urunlerGrid.Columns[0].Visible = false;
            urunlerGrid.Columns[2].Visible = false;
            urunlerGrid.Columns[4].Visible = false;
            urunlerGrid.Columns[5].Visible = false;
            urunlerGrid.Columns[6].Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FillComboBox()
        {
            var kategoriler = baglantı.Categories.ToList();


            foreach (var kategori in kategoriler)
            {
                comboBox1.Items.Add(kategori.CategoryName);

            }
            comboBox1.Items.Add("Tüm Kategoriler");
        }

        private void urunlerGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = urunlerGrid.Rows[e.RowIndex];


                idTextbox.Text = row.Cells[0].Value.ToString();
                isimTextbox.Text = row.Cells[1].Value.ToString();
                fiyatTextbox.Text = row.Cells[3].Value.ToString();
                ureticiTextbox.Text = row.Cells[5].Value.ToString();
                stokTextbox.Text = row.Cells[4].Value.ToString();
                kategoriTextbox.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
