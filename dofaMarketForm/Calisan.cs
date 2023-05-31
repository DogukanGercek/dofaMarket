using dofaMarketForm.DAL;
using dofaMarketForm.Models;
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
        public decimal toplam = 0;
        private List<Product> faturaUrunleri = new List<Product>();

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


        }
        private decimal GetProductPrice(int ProductId) // ürünün SADECE fiyatını getir 
        {
            Console.WriteLine(ProductId);
            var product = _context.Products.FirstOrDefault(x => x.ProductId == ProductId);

            if (product != null)
            {
                return product.UnitPrice;
            }
            else
            {
                MessageBox.Show("Ürün bulunamadı. Lütfen barkodu kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                barkodTextBox.Clear();
                return 0;
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {   
                urunData.DataSource = null;
                int barcode = int.Parse(barkodTextBox.Text);
                urunData.DataSource = _context.Products.Where(x => x.ProductId == barcode)
                .Select(x => new { x.ProductName, x.UnitPrice })
                .ToList();
                var product = _context.Products.FirstOrDefault(y => y.ProductId == barcode);
                faturaUrunleri.Add(product);
                faturadGV.DataSource = faturaUrunleri.Select(x => new { x.ProductName, x.UnitPrice }).ToList();


                decimal fiyat = GetProductPrice(barcode);
                toplam += fiyat;
                toplamtextBox.Text = toplam.ToString(); // toplam değerini toplamtextBox'a yazdır

                barkodTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                barkodTextBox.Clear();
            }
        }


        private decimal Topla(decimal price)//her çağırdğında price üstüne ekliycek
        {

            return 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            toplam = 0;
            toplamtextBox.Clear();
            pUstutextBox.Clear();
            vParaTextBox.Clear();
            urunData.DataSource = null;
            faturadGV.DataSource=null;
            faturaUrunleri.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e) //odeye tıkladığında hesaplanacak para ustu
        {
            decimal verilenPara = decimal.Parse(vParaTextBox.Text);
            decimal paraUstu = verilenPara - toplam;
            pUstutextBox.Text = paraUstu.ToString();

        }
    }
}
