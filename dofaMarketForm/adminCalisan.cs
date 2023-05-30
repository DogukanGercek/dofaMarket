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

        SqlConnection sqlCon = new SqlConnection(@"Data Source=34.155.53.38;Initial Catalog=market-database;Persist Security Info=True;User ID=sqlserver;Password=Knmi^$O$tI0)MnG`");
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

        private void filldgv2()
        {


            sqlCon.Open();
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employees";
            cmd.ExecuteNonQuery();
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = dtb1;
            sqlCon.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            filldgv2();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int indexRow;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[indexRow];
            textBox1.Text = row.Cells[2].Value.ToString();
            textBox2.Text = row.Cells[6].Value.ToString();
            textBox3.Text = row.Cells[4].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[1].Value.ToString();
            textBox6.Text = row.Cells[0].Value.ToString();
            textBox7.Text = row.Cells[5].Value.ToString();
            textBox8.Text = row.Cells[7].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sqlCon.Open();

            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Employees values ('" + textBox1.Text + "','" + textBox6.Text + "','" + textBox5.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox8.Text + "','" + textBox7.Text + "')";
            cmd.ExecuteNonQuery();

            sqlCon.Close();
            filldgv2();

            MessageBox.Show("Çalışan eklendi");
        }

        private void adminCalisan_Load(object sender, EventArgs e)
        {
            filldgv2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Employees where EmployeeID='"+textBox1.Text+"' ";

            cmd.ExecuteNonQuery();
            sqlCon.Close();
            filldgv2();

            MessageBox.Show("işten çıkarıldı");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            sqlCon.Open();
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Employees set FirstName = '" + textBox6.Text + "', LastName = '" + textBox5.Text + "' , Title = '" + textBox4.Text + "' , BirthDate = '" + textBox3.Text + "' , HireDate = '" + textBox2.Text + "' ,  Salary = '" + textBox7.Text + "', Tel = '" + textBox8.Text + "' , EmployeeID ='"+textBox1.Text+"' ";
            
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            filldgv2();

            MessageBox.Show("bilgiler güncellendi");
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
