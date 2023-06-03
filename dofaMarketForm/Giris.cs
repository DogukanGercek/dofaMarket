using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace dofaMarketForm
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=34.155.53.38;Initial Catalog=market-database;Persist Security Info=True;User ID=sqlserver;Password=Knmi^$O$tI0)MnG`;Connect Timeout=30;Encrypt=False;");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM auth WHERE username = @username AND password = @password"; // girilen parola ve kullanıcı adının kontrolü
                SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
                sda.SelectCommand.Parameters.AddWithValue("@username", txt_username.Text);
                sda.SelectCommand.Parameters.AddWithValue("@password", txt_pass.Text);
                DataTable dbtable = new DataTable();
                sda.Fill(dbtable);

                if (dbtable.Rows.Count > 0) // row kontrolü
                {
                    string userType = dbtable.Rows[0]["userType"].ToString(); // usertype cashier mi admin mi ona göre ekran değişicek

                    if (userType == "admin")
                    {
                        // Admin sayfasına yönlendirme
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                    }

                    else if (userType == "cashier")
                    {
                        // Kullanıcı sayfasına yönlendirme
                        Calisan form2 = new Calisan();
                        form2.Show();
                    }

                    //this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // olası bir hata durumunda yapılacak bilgilendirilme
                    txt_username.Clear();
                    txt_pass.Clear();

                    txt_username.Focus();
                }



            }
            catch (Exception)
            {

                throw;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}