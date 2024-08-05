namespace DuAn1_Nhom6
{
    partial class LogInGiaoDien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInGiaoDien));
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            btnxacnhan = new Button();
            txtXacNhan = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1245, 317);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(14, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(155, 65);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 66;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(btnxacnhan);
            panel1.Controls.Add(txtXacNhan);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(270, 441);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 257);
            panel1.TabIndex = 68;
            // 
            // btnxacnhan
            // 
            btnxacnhan.BackColor = SystemColors.Highlight;
            btnxacnhan.FlatStyle = FlatStyle.Popup;
            btnxacnhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnxacnhan.ForeColor = SystemColors.ButtonFace;
            btnxacnhan.Location = new Point(251, 161);
            btnxacnhan.Name = "btnxacnhan";
            btnxacnhan.Size = new Size(286, 44);
            btnxacnhan.TabIndex = 2;
            btnxacnhan.Text = "Xác nhận";
            btnxacnhan.UseVisualStyleBackColor = false;
            btnxacnhan.Click += btnxacnhan_Click;
            // 
            // txtXacNhan
            // 
            txtXacNhan.Location = new Point(251, 110);
            txtXacNhan.Name = "txtXacNhan";
            txtXacNhan.Size = new Size(286, 27);
            txtXacNhan.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(122, 213);
            label3.Name = "label3";
            label3.Size = new Size(559, 25);
            label3.TabIndex = 0;
            label3.Text = "*Lưu ý: Nhập sai mã giao diện 5 lần sẽ phải chờ 30s để thực hiện tiếp";
            label3.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(251, 55);
            label2.Name = "label2";
            label2.Size = new Size(286, 31);
            label2.TabIndex = 0;
            label2.Text = "Vui lòng nhập mã nhân sự";
            label2.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(331, 15);
            label1.Name = "label1";
            label1.Size = new Size(109, 31);
            label1.TabIndex = 0;
            label1.Text = "Xin chào,";
            label1.Click += label1_Click;
            // 
            // LogInGiaoDien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 745);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Name = "LogInGiaoDien";
            Text = "Log_In_Giao_diện";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Label label1;
        private Button btnxacnhan;
        private TextBox txtXacNhan;
        private Label label2;
        private Label label3;
    }
}