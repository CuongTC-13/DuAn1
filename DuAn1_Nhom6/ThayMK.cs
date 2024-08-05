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
    public partial class ThayMK : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-64M86CN;Initial Catalog=Duan1_N6_Demo4;Integrated Security=True;TrustServerCertificate=true");
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AN16NPP\\MSSQLSERVER01;Initial Catalog=Duan1_N6_Demo3;Integrated Security=True;TrustServerCertificate=true");
        SqlDataAdapter sda;
        DataSet ds;
        public ThayMK()
        {
            InitializeComponent();
        }

        void LayDL()
        {
            string sql = "SELECT * FROM NhanVien";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
        }
        void XacNhan()
        {
            SqlCommand cmd = new SqlCommand("UPDATE NhanVien set mk = @mk where IDNhanVien = @IDNhanVien", conn);
            cmd.Parameters.AddWithValue("@mk", txtMKMoi.Text);
            if (txtPassMoi.Text != txtMKMoi.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp với nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            XacNhan();
        }
    }
}
