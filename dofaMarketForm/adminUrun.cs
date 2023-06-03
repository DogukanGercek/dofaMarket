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
using System.Data.Entity.SqlServer;



namespace dofaMarketForm
{
    public partial class adminUrun : Form
    {
        //sql bağlantısı
        SqlConnection sqlCon = new SqlConnection(@"Data Source=34.155.53.38;Initial Catalog=market-database;Persist Security Info=True;User ID=sqlserver;Password=Knmi^$O$tI0)MnG`");
        //entity bağlantısı
        MarketDatabaseContext baglantı = new MarketDatabaseContext();

        public adminUrun()
        {
            InitializeComponent();
        }


        private void Urun_Load(object sender, EventArgs e)
        {

        }
        //sayfa açıldığında datagrid ve combobox display edilmesi
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
                        if (int.TryParse(kategoriTextbox.Text, out cid))//sqldeki değerlerin türleri ve textboxtan alınan değerlerin hata çıkarmaması için dönüşümler
                        {
                            var yeniSatir = new Product//eklenecek rowun bilgileri 
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
                            fill();//ürün eklendikten sonra datagrid güncellemesi
                        }


                    }
                }

            }

        }
        //ürün güncelleme butonu
        private void button2_Click(object sender, EventArgs e)
        {
            decimal fiyat = decimal.Parse(fiyatTextbox.Text);
            short stok = short.Parse(stokTextbox.Text);
            int id = int.Parse(idTextbox.Text);//ürün bilgileri sqle göndermeden önce gerekli dönüşümler
            sqlCon.Open();//sql bağlantısı

            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //productId'ye göre yapılacak güncellemeler textboxtan alınır
            cmd.CommandText = "Update Products set ProductName = '" + isimTextbox.Text + "', UnitPrice = '" + fiyat + "' , UintsInStock = '" + stok + "' , Supplier = '" + ureticiTextbox.Text + "' where  ProductId='" + id + "' ";
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            fill();//bilgiler güncellendikten sonra datagrid güncellemesi

            MessageBox.Show("Bilgiler Güncellendi");

        }

        //datagride sqlden gelen bilgileri display etme
        private void fill()
        {

            sqlCon.Open();//sql bağlantısı
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Products";//products tableındaki rowlar alınır
            cmd.ExecuteNonQuery();
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);
            urunlerGrid.DataSource = dtb1;
            urunlerGrid.Columns[1].HeaderText = "İsim";//Column isimleri düzenlemesi
            urunlerGrid.Columns[3].HeaderText = "Fiyat";

            urunlerGrid.Columns[0].Visible = false;//Display ederken basit gösterme için diğer columnların gizlenmesi
            urunlerGrid.Columns[2].Visible = false;
            urunlerGrid.Columns[4].Visible = false;
            urunlerGrid.Columns[5].Visible = false;
            originalDataTable = (DataTable)urunlerGrid.DataSource;//başka fonksiyonlarda kullanmak üzere tableın kopyalanması
            sqlCon.Close();



        }
        //comboboxta seçilen kategoriye göre arama yapma
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenBirim = comboBox1.SelectedItem.ToString();
            string aramaMetni = textBox7.Text.Trim();

            FiltreleDataGridView(secilenBirim, aramaMetni);//filtrelenecek kategori ve textin fonksiyona gönderilmesi
        }
        private DataTable originalDataTable;

        //datagridde filtreleme işlemi
        private void FiltreleDataGridView(string secilenBirim, string aramaMetni)
        {
            Dictionary<string, int> kategoriIDMapping = new Dictionary<string, int>()//kategoriye göre ayrıma işlemi
    {
        { "Food&Bev", 1 },
        { "Electronics", 2 },
        { "Outfit", 3 },
        { "Tüm Kategoriler", 0 }
    };

            int secilenKategoriID = kategoriIDMapping[secilenBirim];

            DataView dv = new DataView(originalDataTable);

            if (secilenKategoriID == 0)
            {
                dv.RowFilter = string.Empty;
            }
            else
            {
                dv.RowFilter = "CategoryID = " + secilenKategoriID;
            }
            if (!string.IsNullOrWhiteSpace(aramaMetni))//text olarak arama işlemi
            {
                string filterExpression = $"ProductName LIKE '%{aramaMetni}%'";
                dv.RowFilter += (string.IsNullOrEmpty(dv.RowFilter) ? "" : " AND ") + filterExpression;
            }

            DataTable filteredTable = dv.ToTable();

            urunlerGrid.DataSource = filteredTable;//filtrelenmiş halinin gösterilmesi
        }



        //comboboxın içinin categories tableından gelen bilgilerle doldurulması
        private void FillComboBox()
        {
            var kategoriler = baglantı.Categories.ToList();


            foreach (var kategori in kategoriler)
            {
                comboBox1.Items.Add(kategori.CategoryName);

            }
            comboBox1.Items.Add("Tüm Kategoriler");//tüm kategorilerde arayabilmek için ekstra item eklenmesi
        }
        //datagridde cell tıklaması yapıldığında sqlden alınan bilgilerin textboxlara yazdırılması
        private void urunlerGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = urunlerGrid.Rows[e.RowIndex];

                string id = row.Cells[2].Value.ToString();
                int id2 = int.Parse(id);//burada categoryidye göre kategori yazdırılması işlemi yapılıyor
                if (id2 == 1)
                {
                    kategoriTextbox.Text = "Food&Bev";
                }
                else if (id2 == 2)
                {
                    kategoriTextbox.Text = "Electronics";
                }
                else if (id2 == 3)
                {
                    kategoriTextbox.Text = "Outfit";
                }
                idTextbox.Text = row.Cells[0].Value.ToString();
                isimTextbox.Text = row.Cells[1].Value.ToString();
                decimal fiyat = (decimal)row.Cells[3].Value;
                int price = (int)fiyat;
                string price2 = price.ToString();//fiyatın orijinal türü olan money türünden daha düzenli gözükmesi için dönüşümler
                fiyatTextbox.Text = price2;
                ureticiTextbox.Text = row.Cells[5].Value.ToString();
                stokTextbox.Text = row.Cells[4].Value.ToString();

            }
        }
        //ürün silme butonu
        private void button1_Click(object sender, EventArgs e)
        {
            if (urunlerGrid.SelectedRows.Count > 0) // En az bir satır seçili mi kontrol etme
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

                fill();//ürün silindikten sonra datagrid güncellemesi
            }
        }
        //ürünleri göster butonu
        private void button5_Click(object sender, EventArgs e)
        {
            fill();
        }
        //temizle butonu
        private void button6_Click(object sender, EventArgs e)
        {
            idTextbox.Clear();
            isimTextbox.Clear();
            kategoriTextbox.Clear();
            fiyatTextbox.Clear();
            ureticiTextbox.Clear();
            stokTextbox.Clear();

        }
            //arama butonu
        private void button3_Click(object sender, EventArgs e)
        {
            string aramaMetni = textBox7.Text.Trim();

            FiltreleDataGridView(comboBox1.SelectedItem.ToString(), aramaMetni);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        //herhangi bir celle tıklandığında hata çıkmaması için tekrardan cell tıklaması fonksiyonunun yazılması
        private void urunlerGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = urunlerGrid.Rows[e.RowIndex];

                string id = row.Cells[2].Value.ToString();
                int id2 = int.Parse(id);
                if (id2 == 1)
                {
                    kategoriTextbox.Text = "Food&Bev";
                }
                else if (id2 == 2)
                {
                    kategoriTextbox.Text = "Electronics";
                }
                else if (id2 == 3)
                {
                    kategoriTextbox.Text = "Outfit";
                }
                idTextbox.Text = row.Cells[0].Value.ToString();
                isimTextbox.Text = row.Cells[1].Value.ToString();
                decimal fiyat = (decimal)row.Cells[3].Value;
                int price = (int)fiyat;
                string price2 = price.ToString();
                fiyatTextbox.Text = price2;
                ureticiTextbox.Text = row.Cells[5].Value.ToString();
                stokTextbox.Text = row.Cells[4].Value.ToString();

            }
        }
    }
}
