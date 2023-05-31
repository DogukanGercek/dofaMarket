using dofaMarketForm.DAL;
using dofaMarketForm.Models;
using Microsoft.Extensions.Primitives;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

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
            int id;
            if (int.TryParse(idTextbox.Text, out id))
            {
                decimal fiyat;
                if (decimal.TryParse(fiyatTextbox.Text, out fiyat))
                {
                    short stok;
                    if (short.TryParse(stokTextbox.Text, out stok))
                    {
                        int cid;
                        if (int.TryParse(kategoriTextbox.Text, out cid))
                        {
                            var yeniSatir = new Product
                            {
                                ProductId = id,
                                ProductName = isimTextbox.Text,
                                UnitPrice = fiyat,
                                UintsInStock = stok,
                                Supplier = ureticiTextbox.Text,
                                CategoryId = cid,

                            };
                            baglantı.Products.Add(yeniSatir); // Yeni satırı veritabanına ekle

                            baglantı.SaveChanges(); // Değişiklikleri kaydet
                            MessageBox.Show("Ürün eklendi.");
                            fill();
                        }


                    }
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=34.155.53.38;Initial Catalog=market-database;Persist Security Info=True;User ID=sqlserver;Password=Knmi^$O$tI0)MnG`");

            sqlCon.Open();
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
            cmd.CommandText = "Update Products set ProductName = '" + isimTextbox.Text + "', UnitPrice = '" + fiyatTextbox.Text + "' , UintsInStock = '" + stokTextbox.Text + "' , Supplier = '" + ureticiTextbox.Text + "' where  ProductId='" + idTextbox.Text + "' ";
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            fill();

            MessageBox.Show("bilgiler güncellendi");

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
                // Örneğin, DataGridView'de seçilen satırın ProductId'sini alalım
                int selectedProductId = (int)urunlerGrid.SelectedRows[0].Cells["ProductId"].Value;

                // Seçilen ürünün Category verisine erişmek için LINQ sorgusu kullanalım
                var product = baglantı.Products.FirstOrDefault(p => p.ProductId == selectedProductId);

                if (product != null)
                {
                    kategoriTextbox.Text = product.Category?.CategoryName;
                }
                idTextbox.Text = row.Cells[0].Value.ToString();
                isimTextbox.Text = row.Cells[1].Value.ToString();
                fiyatTextbox.Text = row.Cells[3].Value.ToString();
                ureticiTextbox.Text = row.Cells[5].Value.ToString();
                stokTextbox.Text = row.Cells[4].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (urunlerGrid.SelectedRows.Count > 0) // En az bir satır seçili mi kontrol edin
            {
                DataGridViewRow selectedRow = urunlerGrid.SelectedRows[0];
                int selectedRowIndex = selectedRow.Index;
                int selectedRowId = Convert.ToInt32(selectedRow.Cells["ProductId"].Value); // Silinecek satırın benzersiz bir kimliğe sahip olduğunu varsayalım


                var satir = baglantı.Products.Find(selectedRowId); // Silinecek satırı veritabanından bulun

                if (satir != null)
                {
                    baglantı.Products.Remove(satir); // Satırı veritabanından kaldır

                    baglantı.SaveChanges(); // Değişiklikleri kaydet
                }
                MessageBox.Show("Ürün Silindi.");

                fill();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fill();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            idTextbox.Clear();
            isimTextbox.Clear();
            kategoriTextbox.Clear();
            fiyatTextbox.Clear();
            ureticiTextbox.Clear();
            stokTextbox.Clear();

        }
    }
}
