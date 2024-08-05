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
    public partial class hoadon : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-64M86CN;Initial Catalog=Duan1_N6_Demo4;Integrated Security=True;TrustServerCertificate=true");
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AN16NPP\\MSSQLSERVER01;Initial Catalog=Duan1_N6_Demo3;Integrated Security=True;TrustServerCertificate=true");
        SqlDataAdapter sda;
        DataSet ds;
        public hoadon()
        {
            InitializeComponent();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHD.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvHD.CurrentRow.Selected = true;
                txtMSP.Text = dgvHD.Rows[e.RowIndex].Cells[0].Value.ToString();

                txtSP.Text = dgvHD.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSZ.Text = dgvHD.Rows[e.RowIndex].Cells[3].Value.ToString();
                DTPVC.Text = dgvHD.Rows[e.RowIndex].Cells[4].Value.ToString();
                //txtSL.Text = dgvHD.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtGia.Text = dgvHD.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
            LayDL();
        }
        void LayDL()
        {
            string sql = "select a.MaHoaDonCT, b.IDHoaDon, c.MaSanPham, d.IDVoucher, c.TenSanPham, d.MenhGia, d.HanSuDung, f.SoLuong\r\nfrom HoaDonChiTiet a\r\njoin HoaDon b on a.IDHoaDon = b.IDHoaDon\r\njoin SanPham c on a.MaSanPham = c.MaSanPham\r\njoin Voucher d on a.IDVoucher = d.IDVoucher\r\njoin ChiTietSanPham f on c.MaSanPham = f.MaSanPham";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
        }
        void LayDL2()
        {
            string sql = "select * from HoaDonChiTietIN";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();

        }

        void HienThi()
        {
            //SqlCommand cmd = new SqlCommand("select a.MaHoaDonCT, b.IDHoaDon, c.MaSanPham, d.IDVoucher, c.TenSanPham, d.MenhGia, d.HanSuDung, f.SoLuong\r\nfrom HoaDonChiTiet a\r\njoin HoaDon b on a.IDHoaDon = b.IDHoaDon\r\njoin SanPham c on a.MaSanPham = c.MaSanPham\r\njoin Voucher d on c.IDVoucher = d.IDVoucher\r\njoin ChiTietSanPham f on c.MaSanPham = f.MaSanPham", conn);
            SqlCommand cmd = new SqlCommand("select c.MaSanPham, d.IDVoucher, c.TenSanPham, d.MenhGia, d.HanSuDung, f.SoLuong, f.Gia from SanPham c join Voucher d on c.IDVoucher = d.IDVoucher join ChiTietSanPham f on c.MaSanPham = f.MaSanPham", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvHD.DataSource = dt;

        }
        void HienThi2()
        {
            SqlCommand cmd = new SqlCommand("select MaHoaDonCTIN,MaSanPham,TenSanPham,MenhGiaVoucher,HSDVoucher,SoLuong,TongTien,TrangThai from HoaDonChiTietIN", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvHDCT.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maSanPhamTimKiem = txtTK.Text.Trim();

            if (string.IsNullOrEmpty(maSanPhamTimKiem))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm cần tìm.", "Lỗi");
                return;
            }

            //using (SqlCommand cmd = new SqlCommand("select a.MaHoaDonCT, b.IDHoaDon, c.MaSanPham, d.IDVoucher, c.TenSanPham, d.MenhGia, d.HanSuDung, f.SoLuong\r\nfrom HoaDonChiTiet a\r\njoin HoaDon b on a.IDHoaDon = b.IDHoaDon\r\njoin SanPham c on a.MaSanPham = c.MaSanPham\r\njoin Voucher d on a.IDVoucher = d.IDVoucher\r\njoin ChiTietSanPham f on c.MaSanPham = f.MaSanPham WHERE c.MaSanPham = @MaSanPham", conn))
            using (SqlCommand cmd = new SqlCommand("select MaHoaDonCTIN,MaSanPham,TenSanPham,MenhGiaVoucher,HSDVoucher,SoLuong,TongTien,TrangThai from HoaDonChiTietIN where @MaHoaDonCTIN = MaHoaDonCTIN", conn))
            {
                cmd.Parameters.AddWithValue("@MaHoaDonCTIN", maSanPhamTimKiem);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Tạo DataTable để chứa dữ liệu
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Hiển thị dữ liệu trên DataGridView
                    dgvHDCT.DataSource = dataTable;
                }
            }
        }

        private void hoadon_Load_1(object sender, EventArgs e)
        {
            conn.Open();
            HienThi();
            HienThi2();
            LayDL();
            LayDL2();
        }
        void Them()
        {
            try
            {
                // Check if the quantity is a valid integer
                if (!int.TryParse(txtSL.Text, out int soLuongMua))
                {
                    MessageBox.Show("Vui lòng nhập số lượng mua hợp lệ.", "Lỗi");
                    return;
                }

                // Check if the quantity is greater than 0
                if (soLuongMua <= 0)
                {
                    MessageBox.Show("Số lượng mua phải lớn hơn 0.", "Lỗi");
                    return;
                }

                // Check if the remaining quantity is sufficient
                using (SqlCommand cmdCheckQuantity = new SqlCommand("SELECT SoLuong FROM ChiTietSanPham WHERE MaSanPham = @MaSanPham", conn))
                {
                    cmdCheckQuantity.Parameters.AddWithValue("@MaSanPham", txtMSP.Text);

                    int remainingQuantity = Convert.ToInt32(cmdCheckQuantity.ExecuteScalar());

                    if (soLuongMua > remainingQuantity)
                    {
                        MessageBox.Show("Số lượng mua vượt quá số lượng sản phẩm còn lại.", "Lỗi");
                        return;
                    }
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO HoaDonChiTietIN VALUES ( @MaSanPham, @IDNhanVien, @TenSanPham, @MenhGiaVoucher, @HSDVoucher, @SoLuong, @TongTien, @TrangThai)", conn);


                cmd.Parameters.AddWithValue("@MaSanPham", txtMSP.Text);
                cmd.Parameters.AddWithValue("@IDNhanVien", txtIDNV.Text);
                cmd.Parameters.AddWithValue("@TenSanPham", txtSP.Text);
                cmd.Parameters.AddWithValue("@MenhGiaVoucher", txtSZ.Text);
                cmd.Parameters.AddWithValue("@HSDVoucher", DTPVC.Text);
                cmd.Parameters.AddWithValue("@SoLuong", txtSL.Text);

                if (int.TryParse(txtSL.Text, out int soLuong) && int.TryParse(txtGia.Text, out int donGia) && int.TryParse(txtSZ.Text, out int MenhGia))
                {
                    decimal tong = TinhTong(soLuong, donGia, MenhGia);
                    cmd.Parameters.AddWithValue("@TongTien", tong);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng và đơn giá hợp lệ.", "Lỗi");
                    return;
                }

                if (RBDTT.Checked)
                {
                    cmd.Parameters.AddWithValue("@TrangThai", RBDTT.Text);
                }
                else if (RBCTT.Checked)
                {
                    cmd.Parameters.AddWithValue("@TrangThai", RBCTT.Text);
                }

                using (SqlCommand cmdUpdate = new SqlCommand("UPDATE ChiTietSanPham SET SoLuong = SoLuong - @SoLuongMua WHERE MaSanPham = @MaSanPham", conn))
                {
                    cmdUpdate.Parameters.AddWithValue("@SoLuongMua", txtSL.Text);
                    cmdUpdate.Parameters.AddWithValue("@MaSanPham", txtMSP.Text);

                    cmdUpdate.ExecuteNonQuery();
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
        }

        private decimal TinhTong(int soLuong, int donGia, int MenhGia)
        {
            return soLuong * (donGia - MenhGia);
        }
        void Them2()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDonChiTietIN", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvHDCT.DataSource = dt;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Them();
            LayDL2();
            Them2();

        }
        void Sua()
        {
            //SqlCommand cmd = new SqlCommand("UPDATE SANPHAM SET MaSP = @MaSP, tenSp = @tenSp, LoaiHH = @LoaiHH, hang = @hang, donGiaBan = @donGiaBan, donGiaNhap = @donGiaNhap, soLuong = @soLuong, donVi = @donVi, ngayNhap = @ngayNhap, ngayBan = @ngayBan where MaSP = @MaSP", conn);
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE HoaDonChiTietIN SET MaSanPham = @MaSanPham, TenSanPham = @TenSanPham, MenhGiaVoucher = @MenhGiaVoucher, HSDVoucher = @HSDVoucher, SoLuong = @SoLuong, TongTien = @TongTien , TrangThai = @TrangThai WHERE  MaHoaDonCTIN = @MaHoaDonCTIN", conn);

                cmd.Parameters.AddWithValue("@MaHoaDonCTIN", txtHDCT.Text);
                cmd.Parameters.AddWithValue("@MaSanPham", txtMSP.Text);
                cmd.Parameters.AddWithValue("@TenSanPham", txtSP.Text);
                cmd.Parameters.AddWithValue("@MenhGiaVoucher", txtSZ.Text);
                cmd.Parameters.AddWithValue("@HSDVoucher", DTPVC.Text);
                cmd.Parameters.AddWithValue("@SoLuong", txtSL.Text);

                // Tính tổng và gán giá trị vào tham số TongTien
                if (int.TryParse(txtSL.Text, out int soLuong) && int.TryParse(txtGia.Text, out int donGia) && int.TryParse(txtSZ.Text, out int MenhGia))
                {
                    decimal tong = TinhTong(soLuong, donGia, MenhGia);
                    cmd.Parameters.AddWithValue("@TongTien", tong);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng và đơn giá hợp lệ.", "Lỗi");
                    return; // Thoát khỏi phương thức nếu có lỗi
                }

                // Thêm tham số TrangThai dựa trên RadioButton được chọn
                if (RBDTT.Checked)
                {
                    cmd.Parameters.AddWithValue("@TrangThai", RBDTT.Text);
                }
                else if (RBCTT.Checked)
                {
                    cmd.Parameters.AddWithValue("@TrangThai", RBCTT.Text);
                }



                using (SqlCommand cmdUpdate = new SqlCommand("UPDATE ChiTietSanPham SET SoLuong = (SoLuong + @SoluongCT) - @SoLuongMua WHERE MaSanPham = @MaSanPham", conn))
                {
                    cmdUpdate.Parameters.AddWithValue("@SoLuongMua", txtSL.Text);
                    cmdUpdate.Parameters.AddWithValue("@SoluongCT", txtSLHDCY.Text);
                    cmdUpdate.Parameters.AddWithValue("@MaSanPham", txtMSP.Text); // Thay thế bằng mã sản phẩm cụ thể cần giảm

                    cmdUpdate.ExecuteNonQuery();

                }

                LayDL();
                LayDL2();
                HienThi2();
                txtSLHDCY.Text = string.Empty;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
        }
        void Sua2()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDonChiTietIN", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvHDCT.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sua();
            LayDL();
            Sua2();

        }

        private void dgvHDCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHDCT.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvHDCT.CurrentRow.Selected = true;
                txtHDCT.Text = dgvHDCT.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMSP.Text = dgvHDCT.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSP.Text = dgvHDCT.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSLHDCY.Text = dgvHDCT.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtSL.Text = dgvHDCT.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtSZ.Text = dgvHDCT.Rows[e.RowIndex].Cells[3].Value.ToString();
                DTPVC.Text = dgvHDCT.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (dgvHDCT.Rows[e.RowIndex].Cells[7].Value.ToString() == "Đã thanh toán")
                {
                    RBDTT.Checked = true;
                    RBCTT.Checked = false;
                }
                else
                {
                    RBDTT.Checked = false;
                    RBCTT.Checked = true;
                }

            }
            LayDL();
        }

        void Xoa()
        {
            SqlCommand cmd = new SqlCommand("DELETE HoaDonChiTietIN WHERE MaHoaDonCTIN = @MaHoaDonCTIN", conn);
            cmd.Parameters.AddWithValue("@MaHoaDonCTIN", txtHDCT.Text);
            cmd.ExecuteNonQuery();
        }


        void Xoa2()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDonChiTietIN", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvHDCT.DataSource = dt;
        }
        void Xoa3()
        {
            txtHDCT.Text = string.Empty;

            txtSP.Text = string.Empty;
            txtSZ.Text = string.Empty;
            DTPVC.Text = string.Empty;
            txtSL.Text = string.Empty;
            txtGia.Text = string.Empty;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Xoa();
            LayDL();
            Xoa2();
            Xoa3();
            MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtHDCT.Text = string.Empty;

            txtSP.Text = string.Empty;
            txtSZ.Text = string.Empty;
            DTPVC.Text = string.Empty;
            txtSL.Text = string.Empty;
            txtGia.Text = string.Empty;
        }

        private void BTHDCT_Click(object sender, EventArgs e)
        {
            HoaDonCho hoaDonCho = new HoaDonCho();
            hoaDonCho.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HienThi();
            HienThi2();
            LayDL();
            LayDL2();
        }
    }
}
