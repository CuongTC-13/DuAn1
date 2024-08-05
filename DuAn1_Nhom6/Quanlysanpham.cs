using DuAn1_Nhom6.DomainClass;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1_Nhom6
{
    public partial class Quanlysanpham : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-64M86CN;Initial Catalog=Duan1_N6_Demo4;Integrated Security=True;TrustServerCertificate=true");
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AN16NPP\\MSSQLSERVER01;Initial Catalog=Duan1_N6_Demo3;Integrated Security=True;TrustServerCertificate=true");
        SqlDataAdapter sda;
        DataSet ds;
        public Quanlysanpham()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void dgvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSP.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvSP.CurrentRow.Selected = true;
                txtMaSP.Text = dgvSP.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMaNSX.Text = dgvSP.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenSanPham.Text = dgvSP.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            LayDL();
        }
        void LayDL()
        {
            string sql = "SELECT * FROM SanPham";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
        }

        private void Quanlysanpham_Load(object sender, EventArgs e)
        {
            conn.Open();
            HienThi();
            LayDL();
        }
        void HienThi()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SanPham", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvSP.DataSource = dt;

        }
        void Them()
        {
            SqlCommand cmd1 = new SqlCommand("INSERT INTO SanPham values(@MaSanPham,@IDVoucher, @MaNhaSanXuat, @TenSanPham)", conn);
            SqlCommand cmd2 = new SqlCommand("INSERT INTO ChiTietSanPham Values(@MaCTSanPham, @MaSanPham, @MaSize, @MaChatLieu, @SoLuong, @Gia)", conn);
            cmd1.Parameters.AddWithValue("@MaSanPham", txtMaSP.Text);
            cmd1.Parameters.AddWithValue("@IDVoucher", txtVC.Text);
            cmd1.Parameters.AddWithValue("@MaNhaSanXuat", txtMaNSX.Text);
            cmd1.Parameters.AddWithValue("@TenSanPham", txtTenSanPham.Text);
            cmd1.ExecuteNonQuery();
            cmd1.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@MaCTSanPham", txtSPCT.Text);
            cmd2.Parameters.AddWithValue("@MaSanPham", txtMaSP.Text);
            cmd2.Parameters.AddWithValue("@MaSize", txtSize.Text);
            cmd2.Parameters.AddWithValue("@MaChatLieu", txtChatLieu.Text);
            cmd2.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
            cmd2.Parameters.AddWithValue("@Gia", txtTien.Text);
            cmd2.ExecuteNonQuery();
            cmd2.Parameters.Clear();
        }
        void Them2()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SanPham", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvSP.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them();
            LayDL();
            Them2();
            MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgvSP.SelectedRows.Count > 0)
            {
                // Lấy giá trị của cột MaSanPham từ dòng được chọn
                string maSanPham = dgvSP.SelectedRows[0].Cells["MaSanPham"].Value.ToString();

                // Mở Form CTSP và truyền giá trị MaSanPham
                using (CTSP formCTSP = new CTSP(maSanPham))
                {
                    formCTSP.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm từ bảng QuanLySanPham.", "Thông báo");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiemSP_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM SanPham WHERE MaSanPham LIKE '%" + txtTimKiemSP.Text + "%'";
            sda = new SqlDataAdapter(sql, conn);
            ds.Clear();
            sda.Fill(ds);
            dgvSP.DataSource = ds.Tables[0];
        }
    }
}
