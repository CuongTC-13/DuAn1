namespace DuAn1_Nhom6
{
    partial class LoginNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginNhanVien));
            label10 = new Label();
            label1 = new Label();
            btnDangnhap = new Button();
            label3 = new Label();
            label5 = new Label();
            txtdangnhap = new TextBox();
            txtpass = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(542, 237);
            label10.Name = "label10";
            label10.Size = new Size(109, 20);
            label10.TabIndex = 34;
            label10.Text = "Quên mật khẩu";
            label10.Click += label10_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(327, 107);
            label1.Name = "label1";
            label1.Size = new Size(135, 31);
            label1.TabIndex = 27;
            label1.Text = "Đăng Nhập";
            // 
            // btnDangnhap
            // 
            btnDangnhap.BackColor = SystemColors.ActiveCaptionText;
            btnDangnhap.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangnhap.ForeColor = SystemColors.ButtonHighlight;
            btnDangnhap.Location = new Point(259, 284);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(266, 37);
            btnDangnhap.TabIndex = 33;
            btnDangnhap.Text = "Đăng Nhập";
            btnDangnhap.UseVisualStyleBackColor = false;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(264, 155);
            label3.Name = "label3";
            label3.Size = new Size(222, 20);
            label3.TabIndex = 28;
            label3.Text = "Tên tài khoản hoặc địa chỉ eamil\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(264, 211);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 29;
            label5.Text = "Mật khẩu";
            // 
            // txtdangnhap
            // 
            txtdangnhap.Location = new Point(264, 178);
            txtdangnhap.Name = "txtdangnhap";
            txtdangnhap.Size = new Size(257, 27);
            txtdangnhap.TabIndex = 30;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(264, 234);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(257, 27);
            txtpass.TabIndex = 31;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(317, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(155, 65);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 67;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bg1;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(799, 456);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 68;
            pictureBox1.TabStop = false;
            // 
            // LoginNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(btnDangnhap);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(txtdangnhap);
            Controls.Add(txtpass);
            Controls.Add(pictureBox1);
            Name = "LoginNhanVien";
            Text = "LoginNhanVien";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label1;
        private Button btnDangnhap;
        private Label label3;
        private Label label5;
        private TextBox txtdangnhap;
        private TextBox txtpass;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}