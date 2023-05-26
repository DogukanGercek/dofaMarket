using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace dofaMarketForm
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-29SJKEI\SQLEXPRESS;Initial Catalog=C:\USERS\NDOGU\DOCUMENTS\DOFAMARKETDB.MDF;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username, userPass;

            username = txt_username.Text;
            userPass = txt_pass.Text;
            try
            {
                String queery = "SELECT * FROM auth WHERE username = '"+txt_username.Text+ "' AND  password = '"+txt_pass.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(queery, baglanti);

                DataTable dbtable = new DataTable();
                sda.Fill(dbtable);

                if (dbtable.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    userPass = txt_pass.Text;
                    //sonraki acilcak sayfa
                    Calisan form2 = new Calisan();
                    form2.Show();
                    this.Hide();

                }
                else {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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