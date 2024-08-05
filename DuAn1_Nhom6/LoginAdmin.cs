
using Microsoft.Data.SqlClient;
using System.Data;

namespace DuAn1_Nhom6
{
    public partial class LoginAdmin : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-64M86CN;Initial Catalog=Duan1_N6_Demo4;Integrated Security=True;TrustServerCertificate=true");
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AN16NPP\\MSSQLSERVER01;Initial Catalog=Duan1_N6_Demo3;Integrated Security=True;TrustServerCertificate=true");
        SqlDataAdapter sda;
        DataSet ds;
        public LoginAdmin()
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
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string tk = txtdangnhap.Text;
            string mk = txtpass.Text;
            string sql = "select * from Adminacc where MaAdmin = '" + tk + "' and MatKhau = '" + mk + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                TaiKhoan admin = new TaiKhoan(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString());
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
            OpenChildForm(new QuenMK());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new());
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            LoginAdmin dangky = new LoginAdmin();
            dangky.Show();
        }

        private void btnGH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        // đăng ký
        void LayDL()
        {
            string sql = "SELECT * FROM Adminacc";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
        }
        void HienThi()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Adminacc", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
        }
        void Them()
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Adminacc values (@MaAdmin,@HoVaTen,@MatKhau,@GioiTinh,@Email,@Chucvu)", conn);
            cmd.Parameters.AddWithValue("@MaAdmin", txtIdAdmin.Text);
            cmd.Parameters.AddWithValue("@HoVaTen", txtTen.Text);
            cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Chucvu", txtChucVu.Text);
            cmd.ExecuteNonQuery();
        }
        void Them2()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Adminacc", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }
        private void btndky_Click(object sender, EventArgs e)
        {
            conn.Open();
            Them();
            LayDL();
            Them2();
            HienThi();
            MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }
        void ClearForm()
        {
            txtIdAdmin.Text = "";
            txtTen.Text = "";
            txtMatKhau.Text = "";
            txtGioiTinh.Text = "";
            txtEmail.Text = "";
            txtChucVu.Text = "";
        }
        private void Dangky_Load(object sender, EventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}