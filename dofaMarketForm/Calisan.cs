using dofaMarketForm.DAL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dofaMarketForm
{
    public partial class Calisan : Form
    {
        MarketDatabaseContext _context = new MarketDatabaseContext();

        public Calisan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Calisan_Load(object sender, EventArgs e)
        {
            var products = _context.Products.ToList();
            foreach (var product in products)
            {
                
            }

        }
    }
}
