
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
    public partial class Quanlykhachhang : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-64M86CN;Initial Catalog=Duan1_N6_Demo4;Integrated Security=True;TrustServerCertificate=true");
        //SqlConnection conn = new SqlConnection("Data Source=LAPTOP-K5I0S8PT;Initial Catalog=Duan1_N6_Demo3;Integrated Security=True;TrustServerCertificate=true");
        SqlDataAdapter sda;
        DataSet ds;
        public Quanlykhachhang()
        {
            InitializeComponent();
        }

        private void Quanlykhachhang_Load(object sender, EventArgs e)
        {
            conn.Open();
            HienThi();
            LayDL();
            this.dgvQLKH.Columns[0].Visible = false;
        }

        void HienThi()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvQLKH.DataSource = dt;
        }

        void LayDL()
        {
            string sql = "SELECT * FROM KhachHang";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
        }

        void Them()
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO KHACHHANG values (@IDKhachHang, @TenKhachHang, @SDT, @Email,@GioiTinh, @DiaChi)", conn);
            cmd.Parameters.AddWithValue("@IDKhachHang", txtIDKH.Text);
            cmd.Parameters.AddWithValue("@TenKhachHang", txtTenKH.Text);
            cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            if (rdbNam.Checked)
            {
                cmd.Parameters.AddWithValue("@GioiTinh", rdbNam.Text);
            }
            else if (rdbNu.Checked)
            {
                cmd.Parameters.AddWithValue("@GioiTinh", rdbNu.Text);
            }
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        void Them2()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KHACHHANG", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvQLKH.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them();
            LayDL();
            Them2();
            MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void Sua()
        {
            SqlCommand cmd = new SqlCommand("UPDATE KHACHHANG SET IDKhachHang = @IDKhachHang, TenKhachHang = @TenKH, SDT = @SDT, Email = @Email, GioiTinh = @GioiTinh, DiaChi = @DiaChi where IDKhachHang = @IDKhachHang", conn);
            cmd.Parameters.AddWithValue("@IDKhachHang", txtIDKH.Text);
            cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
            cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            if (rdbNam.Checked)
            {
                cmd.Parameters.AddWithValue("@GioiTinh", rdbNam.Text);
            }
            else if (rdbNu.Checked)
            {
                cmd.Parameters.AddWithValue("@GioiTinh", rdbNu.Text);
            }
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        void Sua2()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KHACHHANG", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvQLKH.DataSource = dt;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Sua();
            LayDL();
            Sua2();
            MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        void Xoa()
        {
            SqlCommand cmd = new SqlCommand("DELETE KHACHHANG where IDKhachHang = @IDKH", conn);
            cmd.Parameters.AddWithValue("@IDKH", txtIDKH.Text);
            cmd.ExecuteNonQuery();
        }

        void Xoa2()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KHACHHANG", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvQLKH.DataSource = dt;
        }

        void Xoa3()
        {
            txtIDKH.Text = string.Empty;
            txtTenKH.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            LayDL();
            Xoa();
            Xoa2();
            Xoa3();
        }

        private void dgvQLKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQLKH.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvQLKH.CurrentRow.Selected = true;
                txtIDKH.Text = dgvQLKH.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKH.Text = dgvQLKH.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSDT.Text = dgvQLKH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmail.Text = dgvQLKH.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (dgvQLKH.Rows[e.RowIndex].Cells[4].Value.ToString() == "Nam" || dgvQLKH.Rows[e.RowIndex].Cells[4].Value.ToString() == "Male")
                {
                    rdbNam.Checked = true;
                    rdbNu.Checked = false;
                }
                else if (dgvQLKH.Rows[e.RowIndex].Cells[4].Value.ToString() == "Nữ" || dgvQLKH.Rows[e.RowIndex].Cells[4].Value.ToString() == "Female")
                {
                    rdbNam.Checked = false;
                    rdbNu.Checked = true;
                }
                txtDiaChi.Text = dgvQLKH.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            LayDL();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            (dgvQLKH.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("IDKhachHang like '%" + txtTimKiem.Text + "%' or TenKhachHang like '%" + txtTimKiem.Text + "%'");
        }
    }
}
