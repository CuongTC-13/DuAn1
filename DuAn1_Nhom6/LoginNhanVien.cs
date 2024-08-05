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
    public partial class LoginNhanVien : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-64M86CN;Initial Catalog=Duan1_N6_Demo4;Integrated Security=True;TrustServerCertificate=true");
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AN16NPP\\MSSQLSERVER01;Initial Catalog=Duan1_N6_Demo3;Integrated Security=True;TrustServerCertificate=true");
        SqlDataAdapter sda;
        DataSet ds;
        public LoginNhanVien()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string tk = txtdangnhap.Text;
            string mk = txtpass.Text;
            string sql = "select * from NhanVien where IDNhanVien = '" + tk + "' and Mk = '" + mk + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                TaiKhoan admin = new TaiKhoan(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString());
                this.Hide();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản  hoặc mật khẩu, vui lòng kiểm tra lại!", "Thông báo");
                txtpass.Clear();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            QuenMK quenmk = new QuenMK();
            this.Hide();
            quenmk.Show();
        }
    }
}
