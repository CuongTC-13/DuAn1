
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1_Nhom6
{
    public partial class Quanlykho : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-64M86CN;Initial Catalog=Duan1_N6_Demo4;Integrated Security=True;TrustServerCertificate=true");
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AN16NPP\\MSSQLSERVER01;Initial Catalog=Duan1_N6_Demo3;Integrated Security=True;TrustServerCertificate=true");
        SqlDataAdapter sda;
        DataSet ds;
        public Quanlykho()
        {
            InitializeComponent();
        }

        void HienThi()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KhoHang", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

        }
        void LayDL()
        {
            string sql = "SELECT * FROM KhoHang";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
        }
        void Them()
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO KhoHang values (@MaKhoHang, @TenKhoHang, @TenSanPham, @SoLuongNhap, @SoLuongConLai, @DiaChi, @NgayNhap)", conn);
            cmd.Parameters.AddWithValue("@MaKhoHang", txtMaKhoHang.Text);
            cmd.Parameters.AddWithValue("@TenKhoHang", txtTenKH.Text);
            cmd.Parameters.AddWithValue("@TenSanPham", txtTenSanPham.Text);
            cmd.Parameters.AddWithValue("@SoLuongNhap", txtSLNhap.Text);
            cmd.Parameters.AddWithValue("@SoLuongConLai", txtSLCon.Text);
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("@NgayNhap", txtNgayNhap.Text);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        void Them2()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KhoHang", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Quanlykho_Load(object sender, EventArgs e)
        {
            conn.Open();
            HienThi();
            LayDL();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNgayNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Them();
            LayDL();
            Them2();
            MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // xoa 
        void Sua()
        {

            SqlCommand cmd = new SqlCommand("UPDATE KhoHang SET MaKhoHang = @MaKhoHang,TenKhoHang = @TenKhoHang,TenSanPham = @TenSanPham,SoLuongNhap = @SoLuongNhap,SoLuongConLai = @SoLuongConLai,DiaChi = @DiaChi,NgayNhap = @NgayNhap where MaKhoHang = @MaKhoHang", conn);
            cmd.Parameters.AddWithValue("@MaKhoHang", txtMaKhoHang.Text);
            cmd.Parameters.AddWithValue("@TenKhoHang", txtTenKH.Text);
            cmd.Parameters.AddWithValue("@TenSanPham", txtTenSanPham.Text);
            cmd.Parameters.AddWithValue("@SoLuongNhap", txtSLNhap.Text);
            cmd.Parameters.AddWithValue("@SoLuongConLai", txtSLCon.Text);
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("@NgayNhap", txtNgayNhap.Text);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        void Sua2()
        {
            SqlCommand cmd = new SqlCommand("select * from KhoHang", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Sua();
            LayDL();
            Sua2();
            MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtMaKhoHang.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKH.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenSanPham.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSLNhap.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSLCon.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtNgayNhap.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            LayDL();
        }
        // xoa
        void Xoa()
        {
            SqlCommand cmd = new SqlCommand("DELETE KhoHang where MaKhoHang = @MaKhoHang", conn);
            cmd.Parameters.AddWithValue("@MaKhoHang", txtMaKhoHang.Text);
            cmd.ExecuteNonQuery();
        }

        void Xoa2()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KhoHang", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Xoa3()
        {
            txtMaKhoHang.Text = string.Empty;
            txtTenKH.Text = string.Empty;
            txtTenSanPham.Text = string.Empty;
            txtSLNhap.Text = string.Empty;
            txtSLCon.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtNgayNhap.Text = string.Empty;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            LayDL();
            Xoa();
            Xoa2();
            Xoa3();
            MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
