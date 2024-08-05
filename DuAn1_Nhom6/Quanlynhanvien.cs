
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
    public partial class Quanlynhanvien : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-64M86CN;Initial Catalog=Duan1_N6_Demo4;Integrated Security=True;TrustServerCertificate=true");
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AN16NPP\\MSSQLSERVER01;Initial Catalog=Duan1_N6_Demo3;Integrated Security=True;TrustServerCertificate=true");
        SqlDataAdapter sda;
        DataSet ds;
        public Quanlynhanvien()
        {
            InitializeComponent();
        }
        void HienThi()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvnhanvien.DataSource = dt;

        }
        void LayDL()
        {
            string sql = "SELECT * FROM NhanVien";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        void Them()
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO NhanVien values (@IDNhanVien, @TenNhanVien, @NgaySinh, @SDT, @Email, @GioiTinh, @LuongNhanVien , @mk)", conn);
            cmd.Parameters.AddWithValue("@IDNhanVien", txtid.Text);
            cmd.Parameters.AddWithValue("@TenNhanVien", txtten.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", txtngaysinh.Value.Date);
            cmd.Parameters.AddWithValue("@SDT", txtsdt.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@mk", txtmk.Text);
            if (rbtnam.Checked)
            {
                cmd.Parameters.AddWithValue("@GioiTinh", rbtnam.Text);
            }
            else if (rbtnu.Checked)
            {
                cmd.Parameters.AddWithValue("@GioiTinh", rbtnu.Text);
            }
            cmd.Parameters.AddWithValue("@LuongNhanVien", txtuong.Text);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        void Them2()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvnhanvien.DataSource = dt;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            Them();
            LayDL();
            Them2();
            MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Quanlynhanvien_Load(object sender, EventArgs e)
        {
            conn.Open();
            HienThi();
            LayDL();
            this.dgvnhanvien.Columns[0].Visible = false;
        }
        void Sua()
        {
            SqlCommand cmd = new SqlCommand("UPDATE NhanVien set IDNhanVien = @IDNhanVien, TenNhanVien = @TenNhanVien, NgaySinh = @NgaySinh, SDT = @SDT, email = @Email, mk = @mk, GioiTinh = @GioiTinh, LuongNhanVien=@LuongNhanVien where IDNhanVien = @IDNhanVien ", conn);
            cmd.Parameters.AddWithValue("@IDNhanVien", txtid.Text);
            cmd.Parameters.AddWithValue("@TenNhanVien", txtten.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", txtngaysinh.Value.Date);
            cmd.Parameters.AddWithValue("@SDT", txtsdt.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@mk", txtmk.Text);
            if (rbtnam.Checked)
            {
                cmd.Parameters.AddWithValue("@GioiTinh", rbtnam.Text);
            }
            else if (rbtnu.Checked)
            {
                cmd.Parameters.AddWithValue("@GioiTinh", rbtnu.Text);
            }
            cmd.Parameters.AddWithValue("@LuongNhanVien", txtuong.Text);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            HienThi();
        }
        void Sua2()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvnhanvien.DataSource = dt;
        }
        private void dgvnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvnhanvien.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvnhanvien.CurrentRow.Selected = true;
                txtid.Text = dgvnhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtten.Text = dgvnhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtngaysinh.Text = dgvnhanvien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtsdt.Text = dgvnhanvien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtemail.Text = dgvnhanvien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtmk.Text = dgvnhanvien.Rows[e.RowIndex].Cells[7].Value.ToString();

                if (dgvnhanvien.Rows[e.RowIndex].Cells[5].Value.ToString() == "Nam" || dgvnhanvien.Rows[e.RowIndex].Cells[5].Value.ToString() == "Male")
                {
                    rbtnam.Checked = true;
                    rbtnu.Checked = false;
                }
                else if (dgvnhanvien.Rows[e.RowIndex].Cells[5].Value.ToString() == "Nữ" || dgvnhanvien.Rows[e.RowIndex].Cells[5].Value.ToString() == "Female")
                {
                    rbtnam.Checked = false;
                    rbtnu.Checked = true;
                }
                txtuong.Text = dgvnhanvien.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            LayDL();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Sua();
            LayDL();
            Sua2();
            MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // xoa
        void Xoa()
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM HoaDonChiTiet WHERE IDHoaDon IN (SELECT IDHoaDon FROM HoaDon WHERE IDNhanVien = @IDNhanVien); DELETE FROM HoaDon WHERE IDNhanVien = @IDNhanVien; DELETE FROM NhanVien WHERE IDNhanVien = @IDNhanVien", conn);
            cmd.Parameters.AddWithValue("@IDNhanVien", txtid.Text);
            cmd.ExecuteNonQuery();
        }

        void Xoa2()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien", conn); //MaNV, hotenNV, SDT, diaChi, GioiTinh, roles, email, ngaySinh
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvnhanvien.DataSource = dt;
        }

        void Xoa3()
        {
            txtemail.Text = string.Empty;
            if (rbtnam.Checked)
            {
                rbtnam.Text = string.Empty;
            }
            else if (rbtnu.Checked)
            {
                rbtnu.Text = string.Empty;
            }
            txtid.Text = string.Empty;
            txtmk.Text = string.Empty;
            txtsdt.Text = string.Empty;
            txtten.Text = string.Empty;
            txtuong.Text = string.Empty;
            txtngaysinh.Text = string.Empty;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            Xoa();
            LayDL();
            Xoa3();
            Xoa2();
            MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM NhanVien WHERE IDNhanVien LIKE '%" + txttimkiem.Text + "%'";
            sda = new SqlDataAdapter(sql, conn);
            ds.Clear();
            sda.Fill(ds);
            dgvnhanvien.DataSource = ds.Tables[0];
        }

        private void rbtnu_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
