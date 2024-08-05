using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DuAn1_Nhom6
{
    public partial class TaiKhoan : Form
    {
        string IDNhanVien, TenNhanVien, NgaySinh, SDT, Email, GioiTinh, LuongNhanVien, mk, roles;
        string MaAdmin, HoVaTen, MatKhau, GioiTinh1, Email1, Chucvu;
        public TaiKhoan()
        {
            InitializeComponent();

        }
        public TaiKhoan(string IDNhanVien, string TenNhanVien, string NgaySinh, string SDT, string Email, string GioiTinh, string LuongNhanVien, string mk)
        {
            InitializeComponent();
            this.IDNhanVien = IDNhanVien;
            this.TenNhanVien = TenNhanVien;
            this.NgaySinh = NgaySinh;
            this.SDT = SDT;
            this.Email = Email;
            this.GioiTinh = GioiTinh;
            this.LuongNhanVien = LuongNhanVien;
            this.mk = mk;
        }
        public TaiKhoan(string MaAdmin, string HoVaTen, string MatKhau, string GioiTinh1, string Email1, string Chucvu)
        {
            InitializeComponent();
            this.MaAdmin = MaAdmin;
            this.HoVaTen = HoVaTen;
            this.MatKhau = MatKhau;
            this.GioiTinh1 = GioiTinh1;
            this.Email1 = Email1;
            this.Chucvu = Chucvu;
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
            panel2.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (Chucvu == "Admin" || Chucvu == "admin")
            {
                OpenChildForm(new Quanlynhanvien());
            }
            else
            {
                MessageBox.Show("Nhân viên thì làm gì có quyền vào đây?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            LoginAdmin dk = new LoginAdmin();
            DialogResult dangxuat = MessageBox.Show("Chắc chắn muốn đăng xuất?", "Đăng xuất?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dangxuat == DialogResult.OK)
            {
                dk.Show();
                this.Dispose();
                MessageBox.Show("Đăng xuất thành công!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Quanlysanpham());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Quanlykhachhang());
        }


        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Quanlykho());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new hoadon());
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TrangChu());
        }
    }
}
