using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1_Nhom6
{
    public partial class CTSP : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-64M86CN;Initial Catalog=Duan1_N6_Demo4;Integrated Security=True;TrustServerCertificate=true");
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AN16NPP\\MSSQLSERVER01;Initial Catalog=Duan1_N6_Demo3;Integrated Security=True;TrustServerCertificate=true");
        SqlDataAdapter sda;
        DataSet ds;
        private string maSanPham;

        public CTSP(string maSanPham)
        {
            InitializeComponent();
            this.maSanPham = maSanPham;
        }

        private void CTSP_Load(object sender, EventArgs e)
        {

            // Sử dụng giá trị maSanPham để truy vấn dữ liệu từ ChiTietSanPham
            string query = "SELECT a.MaCTSanPham, g.MaSanPham,d.MaNhaSanXuat, b.MaSize, c.MaChatLieu,h.IDVoucher,b.LoaiSize,c.LoaiChatLieu,g.TenSanPham,d.TenNhaSanXuat, a.SoLuong, a.Gia, h.MenhGia, h.HanSuDung, h.NguoiTao  FROM ChiTietSanPham a join KichCo b on a.MaSize = b.MaSize join ChatLieu c on a.MaChatlieu = c.MaChatlieu join SanPham g on g.MaSanPham = a.MaSanPham join NhaSanXuat d on g.MaNhaSanXuat = d.MaNhaSanXuat join Voucher h on h.IDVoucher = g.IDVoucher WHERE a.MaSanPham = @MaSanPham";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCTSP.DataSource = dt;
            }


            txtCTSP.Text = dgvCTSP.Rows[0].Cells[0].Value.ToString();
            txtSP.Text = dgvCTSP.Rows[0].Cells[1].Value.ToString();
            txtSZ.Text = dgvCTSP.Rows[0].Cells[3].Value.ToString();
            txtCL.Text = dgvCTSP.Rows[0].Cells[4].Value.ToString();
            txtSL.Text = dgvCTSP.Rows[0].Cells[10].Value.ToString();
            txtGia.Text = dgvCTSP.Rows[0].Cells[11].Value.ToString();
            //dtpNSX.Text = dgvCTSP.Rows[0].Cells[6].Value.ToString();
            //dtpNT.Text = dgvCTSP.Rows[0].Cells[7].Value.ToString();
            //txtKH.Text = dgvCTSP.Rows[0].Cells[15].Value.ToString();
            txtNSX.Text = dgvCTSP.Rows[0].Cells[3].Value.ToString();
            //txtDM.Text = dgvCTSP.Rows[0].Cells[17].Value.ToString();
            txtVC.Text = dgvCTSP.Rows[0].Cells[5].Value.ToString();
            dtpVC.Text = dgvCTSP.Rows[0].Cells[13].Value.ToString();
            txtNT.Text = dgvCTSP.Rows[0].Cells[14].Value.ToString();
            txtTenNSX.Text = dgvCTSP.Rows[0].Cells[9].Value.ToString();
            //txtMT.Text = dgvCTSP.Rows[0].Cells[10].Value.ToString();
            txtLSZ.Text = dgvCTSP.Rows[0].Cells[6].Value.ToString();
            txtLoaiCL.Text = dgvCTSP.Rows[0].Cells[7].Value.ToString();
            //txtNSX.Text = dgvCTSP.Rows[0].Cells[20].Value.ToString();
            //txtMThue.Text = dgvCTSP.Rows[0].Cells[21].Value.ToString();
            txtDVC.Text = dgvCTSP.Rows[0].Cells[12].Value.ToString();
            txtTSP.Text = dgvCTSP.Rows[0].Cells[8].Value.ToString();




            LayDL();
        }
        void LayDL()
        {
            string sql = "SELECT * FROM ChiTietSanPham a join KichCo b on a.MaSize = b.MaSize join ChatLieu c on a.MaChatlieu = c.MaChatlieu join SanPham g on g.MaSanPham = a.MaSanPham join NhaSanXuat d on g.MaNhaSanXuat = d.MaNhaSanXuat  join Voucher j on g.IDVoucher = j.IDVoucher WHERE a.MaSanPham = @MaSanPham";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sua2();
            string query = "SELECT * FROM ChiTietSanPham a join KichCo b on a.MaSize = b.MaSize join ChatLieu c on a.MaChatlieu = c.MaChatlieu join SanPham g on g.MaSanPham = a.MaSanPham join NhaSanXuat d on g.MaNhaSanXuat = d.MaNhaSanXuat  join Voucher j on g.IDVoucher = j.IDVoucher WHERE a.MaSanPham = @MaSanPham";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCTSP.DataSource = dt;
            }

        }
        void Sua1()
        {
            try
            {
                conn.Open();

                SqlCommand cmd1 = new SqlCommand("UPDATE ChiTietSanPham \r\nSET \r\n    MaCTSanPham = @MaCTSanPham,\r\n    MaSanPham = @MaSanPham,\r\n    MaSize = @MaSize,\r\n    MaChatLieu = @MaChatLieu,\r\n    SoLuong = @SoLuong,\r\n    Gia = @Gia\r\n    WHERE \r\n    MaSanPham = @MaSanPham;\r\n", conn);
                SqlCommand cmd2 = new SqlCommand("UPDATE Size \r\nSET \r\n    MaSize = @MaSize,\r\n    LoaiSize = @LoaiSize,\r\n    Mota = @Mota \r\n FROM \r\n    ChiTietSanPham a \r\nJOIN \r\n    Size b ON a.MaSize = b.MaSize \r\nWHERE \r\n    a.MaSanPham = @MaSanPham;", conn);
                SqlCommand cmd3 = new SqlCommand("UPDATE ChatLieu \r\nSET \r\n    MaChatLieu = @MaChatLieu,\r\n    LoaiChatLieu = @LoaiChatLieu,\r\n    Mota = @Mota \r\n FROM \r\n    ChiTietSanPham a \r\nJOIN \r\n    ChatLieu c ON a.MaChatlieu = c.MaChatLieu \r\nWHERE \r\n    a.MaSanPham = @MaSanPham;", conn);
                SqlCommand cmd4 = new SqlCommand("UPDATE SanPham \r\nSET \r\n    MaSanPham = @MaSanPham,\r\n    MaKhoHang = @MaKhoHang,\r\n    MaNhaSanXuat = @MaNhaSanXuat,\r\n    MaDanhMuc = @MaDanhMuc,\r\n    TenSanPham = @TenSanPham \r\nWHERE \r\n    MaSanPham = @MaSanPham;", conn);
                SqlCommand cmd5 = new SqlCommand("UPDATE NhaSanXuat \r\nSET \r\n    MaNhaSanXuat = @MaNhaSanXuat,\r\n    TenNhaSanXuat = @TenNhaSanXuat,\r\n    MaThue = @MaThue\r\n FROM \r\n    SanPham g \r\nJOIN \r\n    NhaSanXuat d ON g.MaNhaSanXuat = d.MaNhaSanXuat \r\nWHERE \r\n    g.MaSanPham = @MaSanPham;", conn);
                //SqlCommand cmd6 = new SqlCommand("UPDATE ChiTietSanPham SET NgayTao = @NgayTao WHERE MaSanPham = @MaSanPham;\r\n", conn);
                SqlCommand cmd7 = new SqlCommand("UPDATE Voucher SET NguoiTao = @NguoiTao WHERE MaSanPham = @MaSanPham;\r\n", conn);

                cmd1.Parameters.AddWithValue("@MaCTSanPham", txtCTSP.Text);
                cmd1.Parameters.AddWithValue("@MaSanPham", txtSP.Text);
                cmd1.Parameters.AddWithValue("@MaSize", txtSZ.Text);
                cmd1.Parameters.AddWithValue("@MaChatLieu", txtCL.Text);
                cmd1.Parameters.AddWithValue("@SoLuong", txtSL.Text);
                cmd1.Parameters.AddWithValue("@Gia", txtGia.Text);
                // cmd1.Parameters.AddWithValue("@NgaySanXuat", dtpNSX.Text);
                // cmd1.Parameters.AddWithValue("@NgayTao", dtpNT.Text);

                cmd2.Parameters.AddWithValue("@MaSanPham", txtSP.Text);
                cmd2.Parameters.AddWithValue("@MaSize", txtSZ.Text);
                cmd2.Parameters.AddWithValue("@LoaiSize", txtLSZ.Text);
                //cmd2.Parameters.AddWithValue("@Mota", txtMT.Text);

                cmd3.Parameters.AddWithValue("@MaSanPham", txtSP.Text);
                cmd3.Parameters.AddWithValue("@MaChatLieu", txtCL.Text);
                cmd3.Parameters.AddWithValue("@LoaiChatLieu", txtLoaiCL.Text);
                //cmd3.Parameters.AddWithValue("@Mota", txtMT.Text);


                cmd4.Parameters.AddWithValue("@MaSanPham", txtSP.Text);
                //cmd4.Parameters.AddWithValue("@MaKhoHang", txtKH.Text);
                cmd4.Parameters.AddWithValue("@MaNhaSanXuat", txtNSX.Text);
                //cmd4.Parameters.AddWithValue("@MaDanhMuc", txtDM.Text);
                cmd4.Parameters.AddWithValue("@TenSanPham", txtTSP.Text);

                cmd5.Parameters.AddWithValue("@MaSanPham", txtSP.Text);
                cmd5.Parameters.AddWithValue("@MaNhaSanXuat", txtNSX.Text);
                cmd5.Parameters.AddWithValue("@TenNhaSanXuat", txtTenNSX.Text);
                //cmd5.Parameters.AddWithValue("@MaThue", txtMThue.Text);

                //cmd6.Parameters.AddWithValue("@MaSanPham", txtSP.Text);
                //cmd6.Parameters.AddWithValue("@NgayTao", dtpNT.Text);

                cmd7.Parameters.AddWithValue("@MaSanPham", txtSP.Text);
                cmd7.Parameters.AddWithValue("@NguoiTao", txtNT.Text);







                LayDL();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
                cmd5.ExecuteNonQuery();
                //cmd6.ExecuteNonQuery();
                cmd7.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Dm, Lại lỗi");
            }
        }
        void Sua2()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd1 = new SqlCommand("UPDATE ChiTietSanPham SET   SoLuong = @SoLuong, Gia = @Gia  WHERE MaCTSanPham = @MaCTSanPham;\r\n", conn);
                SqlCommand cmd2 = new SqlCommand("UPDATE KichCo SET LoaiSize = @LoaiSize WHERE MaSize = @MaSize;\r\n", conn);
                SqlCommand cmd3 = new SqlCommand("UPDATE ChatLieu SET LoaiChatLieu = @LoaiChatLieu WHERE MaChatLieu = @MaChatLieu;\r\n", conn);
                SqlCommand cmd4 = new SqlCommand("UPDATE SanPham SET TenSanPham = @TenSanPham WHERE MaSanPham = @MaSanPham;\r\n", conn);
                SqlCommand cmd5 = new SqlCommand("UPDATE NhaSanXuat SET TenNhaSanXuat = @TenNhaSanXuat WHERE MaNhaSanXuat = @MaNhaSanXuat;\r\n", conn);
                SqlCommand cmd7 = new SqlCommand("UPDATE Voucher SET MenhGia = @MenhGia, HanSuDung = @HanSuDung, NguoiTao = @NguoiTao WHERE IDVoucher = @IDVoucher;\r\n", conn);

                //cmd1.Parameters.AddWithValue("@MaSize", txtSZ.Text);
                cmd1.Parameters.AddWithValue("@SoLuong", txtSL.Text);
                // cmd1.Parameters.AddWithValue("@MaChatLieu", txtCL.Text);
                cmd1.Parameters.AddWithValue("@Gia", txtGia.Text);
                //cmd1.Parameters.AddWithValue("@NgaySanXuat", dtpNSX.Value);
                //cmd1.Parameters.AddWithValue("@NgayTao", dtpNT.Value);
                cmd1.Parameters.AddWithValue("@MaCTSanPham", txtCTSP.Text);

                cmd2.Parameters.AddWithValue("@LoaiSize", txtLSZ.Text);
                //cmd2.Parameters.AddWithValue("@Mota", txtMT.Text);
                cmd2.Parameters.AddWithValue("@MaSize", txtSZ.Text);

                cmd3.Parameters.AddWithValue("@LoaiChatLieu", txtLoaiCL.Text);
                //cmd3.Parameters.AddWithValue("@Mota", txtMT.Text);
                cmd3.Parameters.AddWithValue("@MaChatLieu", txtCL.Text);

                cmd4.Parameters.AddWithValue("@TenSanPham", txtTSP.Text);
                cmd4.Parameters.AddWithValue("@MaSanPham", txtSP.Text);

                cmd5.Parameters.AddWithValue("@TenNhaSanXuat", txtTenNSX.Text);
                cmd5.Parameters.AddWithValue("@MaNhaSanXuat", txtNSX.Text);



                cmd7.Parameters.AddWithValue("@MenhGia", txtDVC.Text);
                cmd7.Parameters.AddWithValue("@HanSuDung", dtpVC.Value);
                cmd7.Parameters.AddWithValue("@NguoiTao", txtNT.Text);
                cmd7.Parameters.AddWithValue("@IDVoucher", txtVC.Text);


                LayDL();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
                cmd5.ExecuteNonQuery();
                //cmd6.ExecuteNonQuery();
                cmd7.ExecuteNonQuery();
                MessageBox.Show("Thành con mẹ nó công dcmn ", "oh yeahhhhhhhhhh");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Dm, Lại lỗi");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Sử dụng giá trị maSanPham để truy vấn dữ liệu từ ChiTietSanPham
            string query = "SELECT a.MaCTSanPham, g.MaSanPham,d.MaNhaSanXuat, b.MaSize, c.MaChatLieu,h.IDVoucher,b.LoaiSize,c.LoaiChatLieu,g.TenSanPham,d.TenNhaSanXuat, a.SoLuong, a.Gia, h.MenhGia, h.HanSuDung, h.NguoiTao  FROM ChiTietSanPham a join KichCo b on a.MaSize = b.MaSize join ChatLieu c on a.MaChatlieu = c.MaChatlieu join SanPham g on g.MaSanPham = a.MaSanPham join NhaSanXuat d on g.MaNhaSanXuat = d.MaNhaSanXuat join Voucher h on h.IDVoucher = g.IDVoucher WHERE a.MaSanPham = @MaSanPham";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCTSP.DataSource = dt;
            }


            txtCTSP.Text = dgvCTSP.Rows[0].Cells[0].Value.ToString();
            txtSP.Text = dgvCTSP.Rows[0].Cells[1].Value.ToString();
            txtSZ.Text = dgvCTSP.Rows[0].Cells[3].Value.ToString();
            txtCL.Text = dgvCTSP.Rows[0].Cells[4].Value.ToString();
            txtSL.Text = dgvCTSP.Rows[0].Cells[10].Value.ToString();
            txtGia.Text = dgvCTSP.Rows[0].Cells[11].Value.ToString();
            //dtpNSX.Text = dgvCTSP.Rows[0].Cells[6].Value.ToString();
            //dtpNT.Text = dgvCTSP.Rows[0].Cells[7].Value.ToString();
            //txtKH.Text = dgvCTSP.Rows[0].Cells[15].Value.ToString();
            txtNSX.Text = dgvCTSP.Rows[0].Cells[3].Value.ToString();
            //txtDM.Text = dgvCTSP.Rows[0].Cells[17].Value.ToString();
            txtVC.Text = dgvCTSP.Rows[0].Cells[5].Value.ToString();
            dtpVC.Text = dgvCTSP.Rows[0].Cells[13].Value.ToString();
            txtNT.Text = dgvCTSP.Rows[0].Cells[14].Value.ToString();
            txtTenNSX.Text = dgvCTSP.Rows[0].Cells[9].Value.ToString();
            //txtMT.Text = dgvCTSP.Rows[0].Cells[10].Value.ToString();
            txtLSZ.Text = dgvCTSP.Rows[0].Cells[6].Value.ToString();
            txtLoaiCL.Text = dgvCTSP.Rows[0].Cells[7].Value.ToString();
            //txtNSX.Text = dgvCTSP.Rows[0].Cells[20].Value.ToString();
            //txtMThue.Text = dgvCTSP.Rows[0].Cells[21].Value.ToString();
            txtDVC.Text = dgvCTSP.Rows[0].Cells[12].Value.ToString();
            txtTSP.Text = dgvCTSP.Rows[0].Cells[8].Value.ToString();



            LayDL();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCTSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCTSP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
