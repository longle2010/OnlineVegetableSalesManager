using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        private void BanHang_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["project_1"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            conn.Open();
            hienthi();
            kho();
        }
        public void hienthi()
        {
            
        }
        private void kho()
        {

        }
        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void order_Click(object sender, EventArgs e)
        {
           
        }
        private void BanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F = new Form1();
            F.ShowDialog();
            this.Close();
        }

    }
}
