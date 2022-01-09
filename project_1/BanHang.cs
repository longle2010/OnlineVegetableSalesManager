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
            string sqlSelect = "select MaHang as 'Mã Sản phẩm',TenHang as 'Tên sản phẩm',GiaTien as 'Giá',SoLuong as 'Số lượng' from kho";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtkho.DataSource = dt;
        }
        private void kho()
        {
            string kho = "select * from kho where Soluong > 0";
            SqlCommand cmd = new SqlCommand(kho, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            comboBox2.DisplayMember = "TenHang";
            comboBox2.ValueMember = "MaHang";
            comboBox2.DataSource = dt;
        }
        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void order_Click(object sender, EventArgs e)
        {
            if (sl1.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                return;
            }
            else
            {
                string sqlinsert = "Insert into banhang values (@MaHang,@SoLuong,GETDATE(),@KieuThanhToan)";
                string sqlupdate = "Update kho set " +
                    "Soluong = SoLuong - @SoLuong where MaHang = @MaHang";

                SqlCommand cmd = new SqlCommand(sqlinsert, conn);
                cmd.Parameters.AddWithValue("MaHang", comboBox2.SelectedValue);
                cmd.Parameters.AddWithValue("SoLuong", sl1.Text);
                cmd.Parameters.AddWithValue("KieuThanhToan", comboBox1.Text);

                SqlCommand cmd1 = new SqlCommand(sqlupdate, conn);
                cmd1.Parameters.AddWithValue("MaHang", comboBox2.SelectedValue);
                cmd1.Parameters.AddWithValue("SoLuong", sl1.Text);

                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();

                hienthi();
                MessageBox.Show("Bán thành công", "Bán không thành công", MessageBoxButtons.OK);
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
