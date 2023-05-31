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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminCalisan adminCalisan = new adminCalisan();
            adminCalisan.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminCalisan adminUrun = new adminCalisan();
            adminUrun.Show();

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
