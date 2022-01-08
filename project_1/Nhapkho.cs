using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace project_1
{
    public partial class Nhapkho : Form
    {
        public Nhapkho()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        private void Nhapkho_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["project_1"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            conn.Open();
            
        }

        private void add_Click(object sender, EventArgs e)
        {
            
            

        }
        public void clear()
        {
            mah1.Text = "";
            mah2.Text = "";


            ten1.Text = "";
            ten2.Text = "";


            gia1.Text = "";
            gia2.Text = "";


            sl1.Text = "";
            sl2.Text = "";


        }
        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F = new Form1();
            F.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
