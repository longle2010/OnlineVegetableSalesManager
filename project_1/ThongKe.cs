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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void Tke_Click(object sender, EventArgs e)
        {
            string ThongKe = "Select * from banhang where  CONVERT(varchar,NgayBan) = @NgayBan";
            SqlCommand cmd = new SqlCommand(ThongKe, conn);

            cmd.Parameters.AddWithValue("NgayBan", dateTimePicker1.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
        SqlConnection conn;
        private void ThongKe_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["project_1"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            conn.Open();
        }

        private void tknn_Click(object sender, EventArgs e)
        {
            string ThongKe = "Select * from kho where  CONVERT(varchar,NgayNhap) = @NgayNhap";
            SqlCommand cmd = new SqlCommand(ThongKe, conn);

            cmd.Parameters.AddWithValue("NgayNhap", dateTimePicker1.Text);
            cmd.ExecuteNonQuery();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F = new Form1();
            F.ShowDialog();
            this.Close();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
