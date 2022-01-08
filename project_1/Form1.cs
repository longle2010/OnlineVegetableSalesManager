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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ban_Click(object sender, EventArgs e)
        {
            this.Hide();
            BanHang BH = new BanHang();
            BH.ShowDialog();
            this.Close();
        }

        private void Nhapkho_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nhapkho NK = new Nhapkho();
            NK.ShowDialog();
            this.Close();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        SqlConnection conn;
        private void Form1_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["project_1"].ConnectionString.ToString();
            conn = new SqlConnection(conString);
            conn.Open();
            hienthi();
            hienthi1();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        public void hienthi()
        {
            string sqlSelect = "select MaHang as 'Mã Sản phẩm',TenHang as 'Tên sản phẩm',NgayNhap as'Ngày nhập',GiaTien as 'Giá',SoLuong as 'Số lượng' from kho";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtkho.DataSource = dt;
        }

        public void hienthi1()
        {
            string sqlSelect = "select  banhang.MaHang as 'Mã Hàng',banhang.Soluong as 'Số lượng',GiaTien as 'Giá tiền', 'Tổng tiền' = banhang.Soluong * GiaTien ,NgayBan as 'Ngày Bán'  from banhang  inner join kho on banhang.MaHang = kho.MaHang";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            daBan.DataSource = dt;
        }

        private void ThongKe_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKe Tk = new ThongKe();
            Tk.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            In IN = new In();
            IN.ShowDialog();
            this.Close();
        }
    }
}
