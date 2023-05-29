using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace dofaMarketForm
{
    public partial class adminCalisan : Form
    {

        string connectionString = @"Data Source=34.155.53.38;Initial Catalog=market-database;Persist Security Info=True;User ID=sqlserver;Password=Knmi^$O$tI0)MnG`";
        public adminCalisan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void filldgv()
        {

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {

                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Employees", sqlCon);
                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);
                dataGridView1.DataSource = dtb1;
                


            }

        }
        private void filldgv2()
        {

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {

                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Employees", sqlCon);
                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = dtb1;
                
                
                

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            filldgv();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            filldgv2();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
