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
    public partial class QuenMK : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-64M86CN;Initial Catalog=Duan1_N6_Demo4;Integrated Security=True;TrustServerCertificate=true");
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AN16NPP\\MSSQLSERVER01;Initial Catalog=Duan1_N6_Demo3;Integrated Security=True;TrustServerCertificate=true");
        SqlDataAdapter sda;
        DataSet ds;
        public QuenMK()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE NhanVien set mk = @mk where IDNhanVien = @IDNhanVien", conn);
            cmd.Parameters.AddWithValue("@IDNhanVien", txtIDSua.Text);
            cmd.Parameters.AddWithValue("@mk", txtPassMoi.Text);
            if (txtPassMoi.Text != txtNhapLai.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp với nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginNhanVien nv = new LoginNhanVien();
                nv.Show();
                this.Dispose();
            }
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginAdmin dangky = new LoginAdmin();
            dangky.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in txtIDSua.Text)
            {
                if (txtIDSua == null)
                {
                    MessageBox.Show("Mời bạn nhập Email", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MessageBox.Show("Mã đã được gửi", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }

            //Scaffold-DbContext 'Data Source=DESKTOP-AN16NPP\MSSQLSERVER01;Initial Catalog=Duan1_N6_Demo3;Integrated Security=True;TrustServerCertificate=true' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context DBContext -Contextdir Context -DataAnnotations -Force

        }
    }
}
