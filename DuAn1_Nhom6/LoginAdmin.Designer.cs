namespace DuAn1_Nhom6
{
    partial class LoginAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtdangnhap = new TextBox();
            txtpass = new TextBox();
            label9 = new Label();
            txtIdAdmin = new TextBox();
            txtTen = new TextBox();
            txtMatKhau = new TextBox();
            txtEmail = new TextBox();
            btnDangnhap = new Button();
            btndky = new Button();
            panel2 = new Panel();
            txtGioiTinh = new ComboBox();
            txtChucVu = new TextBox();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(145, 23);
            label1.Name = "label1";
            label1.Size = new Size(135, 31);
            label1.TabIndex = 6;
            label1.Text = "Đăng Nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(472, 23);
            label2.Name = "label2";
            label2.Size = new Size(181, 31);
            label2.TabIndex = 7;
            label2.Text = "Đăng Ký Admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(145, 76);
            label3.Name = "label3";
            label3.Size = new Size(222, 20);
            label3.TabIndex = 8;
            label3.Text = "Tên tài khoản hoặc địa chỉ eamil\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(471, 76);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 9;
            label4.Text = "Mã Admin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(145, 132);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 10;
            label5.Text = "Mật khẩu";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(603, 76);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 11;
            label6.Text = "Họ và tên";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(471, 132);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 12;
            label7.Text = "Mật khẩu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(472, 188);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 13;
            label8.Text = "Giới tính";
            // 
            // txtdangnhap
            // 
            txtdangnhap.Location = new Point(145, 99);
            txtdangnhap.Name = "txtdangnhap";
            txtdangnhap.Size = new Size(257, 27);
            txtdangnhap.TabIndex = 14;
            txtdangnhap.TextChanged += textBox2_TextChanged;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(145, 155);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(257, 27);
            txtpass.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(471, 243);
            label9.Name = "label9";
            label9.Size = new Size(96, 20);
            label9.TabIndex = 16;
            label9.Text = "Địa chỉ email";
            // 
            // txtIdAdmin
            // 
            txtIdAdmin.Location = new Point(471, 99);
            txtIdAdmin.Name = "txtIdAdmin";
            txtIdAdmin.Size = new Size(125, 27);
            txtIdAdmin.TabIndex = 17;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(603, 99);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(125, 27);
            txtTen.TabIndex = 18;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(472, 155);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(257, 27);
            txtMatKhau.TabIndex = 19;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(472, 267);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(257, 27);
            txtEmail.TabIndex = 21;
            // 
            // btnDangnhap
            // 
            btnDangnhap.BackColor = SystemColors.ActiveCaptionText;
            btnDangnhap.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangnhap.ForeColor = SystemColors.ButtonHighlight;
            btnDangnhap.Location = new Point(141, 201);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(266, 37);
            btnDangnhap.TabIndex = 23;
            btnDangnhap.Text = "Đăng Nhập";
            btnDangnhap.UseVisualStyleBackColor = false;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // btndky
            // 
            btndky.BackColor = SystemColors.ActiveCaptionText;
            btndky.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btndky.ForeColor = SystemColors.ButtonHighlight;
            btndky.Location = new Point(471, 357);
            btndky.Name = "btndky";
            btndky.Size = new Size(266, 37);
            btndky.TabIndex = 24;
            btndky.Text = "Đăng ký";
            btndky.UseVisualStyleBackColor = false;
            btndky.Click += btndky_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtGioiTinh);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btndky);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnDangnhap);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtChucVu);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtMatKhau);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtTen);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtIdAdmin);
            panel2.Controls.Add(txtdangnhap);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtpass);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(11, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(863, 415);
            panel2.TabIndex = 25;
            panel2.Paint += panel2_Paint;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.AutoCompleteCustomSource.AddRange(new string[] { "Nam", "Nữ" });
            txtGioiTinh.FormattingEnabled = true;
            txtGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Không muốn tiết lộ" });
            txtGioiTinh.Location = new Point(472, 211);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(256, 28);
            txtGioiTinh.TabIndex = 27;
            // 
            // txtChucVu
            // 
            txtChucVu.Enabled = false;
            txtChucVu.Location = new Point(472, 321);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(257, 27);
            txtChucVu.TabIndex = 21;
            txtChucVu.Text = "Admin";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(471, 297);
            label11.Name = "label11";
            label11.Size = new Size(61, 20);
            label11.TabIndex = 16;
            label11.Text = "Chức vụ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bg1;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(863, 412);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // LoginAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 1055);
            Controls.Add(panel2);
            Name = "LoginAdmin";
            Text = "Form1";
            Load += Dangky_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtdangnhap;
        private TextBox txtpass;
        private Label label9;
        private TextBox txtIdAdmin;
        private TextBox txtTen;
        private TextBox txtMatKhau;
        private TextBox txtEmail;
        private Button btnDangnhap;
        private Button btndky;
        private Panel panel2;
        private ComboBox txtGioiTinh;
        private TextBox txtChucVu;
        private Label label11;
        private PictureBox pictureBox1;
    }
}