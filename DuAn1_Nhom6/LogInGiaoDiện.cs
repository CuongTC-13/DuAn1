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
    public partial class LogInGiaoDien : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-64M86CN;Initial Catalog=Duan1_N6_Demo4;Integrated Security=True;TrustServerCertificate=true");
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AN16NPP\\MSSQLSERVER01;Initial Catalog=Duan1_N6_Demo3;Integrated Security=True;TrustServerCertificate=true");
        SqlDataAdapter sda;
        public LogInGiaoDien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            string xn = txtXacNhan.Text;
            string sql = "select * from MaShop where MaMayChu = '" + xn + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if (xn.Equals("@DocLaNhom6"))
                {
                    LoginAdmin lgad = new LoginAdmin();
                    this.Hide();
                    lgad.Show();
                    MessageBox.Show("Vai trò Admin");
                }
                else if (xn.Equals("@Khongdoclacholam"))
                {
                    LoginNhanVien lgnv = new LoginNhanVien();
                    this.Hide();
                    lgnv.Show();
                    MessageBox.Show("Nhân Viên");
                }

            }
            else
            {
                MessageBox.Show("Mã nhân sự không hợp lệ!", "Thông báo");
                txtXacNhan.Clear();
            }
        }
    }
}
