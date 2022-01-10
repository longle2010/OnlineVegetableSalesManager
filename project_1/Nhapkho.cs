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
            if (mah1.Text.Length != 0 && mah2.Text.Length != 0)
            {
                if (ten1.Text.Length == 0 || ten2.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm");
                    return;
                }
                if (sl1.Text.Length == 0 || sl2.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng sản phẩm");
                    return;
                }
                if (gia1.Text.Length == 0 || gia2.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập giá sản phẩm");
                    return;
                }

                else
                {
                    string sqlinsert = "Insert into kho values (@MaHang,@TenHang,GETDATE(),@GiaTien,@SoLuong)";
                    SqlCommand cmd = new SqlCommand(sqlinsert, conn);
                    cmd.Parameters.AddWithValue("MaHang", mah1.Text);
                    cmd.Parameters.AddWithValue("TenHang", ten1.Text);
                    cmd.Parameters.AddWithValue("GiaTien", gia1.Text);
                    cmd.Parameters.AddWithValue("SoLuong", sl1.Text);

                    string sqlinsert1 = "Insert into kho values (@MaHang,@TenHang,GETDATE(),@GiaTien,@SoLuong)";
                    SqlCommand cmd1 = new SqlCommand(sqlinsert1, conn);
                    cmd1.Parameters.AddWithValue("MaHang", mah2.Text);
                    cmd1.Parameters.AddWithValue("TenHang", ten2.Text);
                    cmd1.Parameters.AddWithValue("GiaTien", gia2.Text);
                    cmd1.Parameters.AddWithValue("SoLuong", sl2.Text);
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công", "Thêm không thành công", MessageBoxButtons.OK);
                    clear();
                    return;
                }
            }
            if (mah1.Text.Length != 0 && mah2.Text.Length == 0)
            {
                if (ten1.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm");
                    return;
                }
                if (sl1.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng sản phẩm");
                    return;
                }
                if (gia1.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập giá sản phẩm");
                    return;
                }
                string sqlinsert = "Insert into kho values (@MaHang,@TenHang,GETDATE(),@GiaTien,@SoLuong)";
                SqlCommand cmd = new SqlCommand(sqlinsert, conn);
                cmd.Parameters.AddWithValue("MaHang", mah1.Text);
                cmd.Parameters.AddWithValue("TenHang", ten1.Text);
                cmd.Parameters.AddWithValue("GiaTien", gia1.Text);
                cmd.Parameters.AddWithValue("SoLuong", sl1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "Thêm không thành công", MessageBoxButtons.OK);
                clear();
                return;
            }
            if (mah2.Text.Length != 0 && mah1.Text.Length == 0)
            {
                if (ten2.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm");
                    return;
                }
                if (sl2.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng sản phẩm");
                    return;
                }
                if (gia2.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập giá sản phẩm");
                    return;
                }
                string sqlinsert = "Insert into kho values (@MaHang,@TenHang,GETDATE(),@GiaTien,@SoLuong)";
                SqlCommand cmd = new SqlCommand(sqlinsert, conn);
                cmd.Parameters.AddWithValue("MaHang", mah2.Text);
                cmd.Parameters.AddWithValue("TenHang", ten2.Text);
                cmd.Parameters.AddWithValue("GiaTien", gia2.Text);
                cmd.Parameters.AddWithValue("SoLuong", sl2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "Thêm không thành công", MessageBoxButtons.OK);
                clear();
                return;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin sản phẩm");
                return;
            }


        }
        public void clear()
        {
            mah1.Text = " ";
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
            string sqlupdate = "Update kho set Soluong = SoLuong + @SoLuong where MaHang = @MaHang";
            SqlCommand cmd0 = new SqlCommand(sqlupdate, conn);
            cmd0.Parameters.AddWithValue("MaHang", mh.Text);
            cmd0.Parameters.AddWithValue("SoLuong", sl.Text);
            cmd0.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công", "Thêm không thành công", MessageBoxButtons.OK);
            clear();
            return;
        }
    }
}
