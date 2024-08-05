namespace DuAn1_Nhom6
{
    partial class ThayMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThayMK));
            label1 = new Label();
            label2 = new Label();
            txtPassMoi = new TextBox();
            txtMKMoi = new TextBox();
            btnConfirm = new Button();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(246, 439);
            label1.Name = "label1";
            label1.Size = new Size(185, 28);
            label1.TabIndex = 0;
            label1.Text = "Nhập mật khẩu mới";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(246, 510);
            label2.Name = "label2";
            label2.Size = new Size(216, 28);
            label2.TabIndex = 0;
            label2.Text = "Xác nhận mật khẩu mới";
            // 
            // txtPassMoi
            // 
            txtPassMoi.Location = new Point(468, 441);
            txtPassMoi.Name = "txtPassMoi";
            txtPassMoi.Size = new Size(309, 27);
            txtPassMoi.TabIndex = 1;
            // 
            // txtMKMoi
            // 
            txtMKMoi.Location = new Point(468, 514);
            txtMKMoi.Name = "txtMKMoi";
            txtMKMoi.Size = new Size(309, 27);
            txtMKMoi.TabIndex = 1;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Red;
            btnConfirm.FlatStyle = FlatStyle.Popup;
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.ForeColor = SystemColors.Control;
            btnConfirm.Location = new Point(679, 115);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(130, 40);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1258, 317);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-229, 70);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(155, 65);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 66;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(468, 377);
            label3.Name = "label3";
            label3.Size = new Size(281, 28);
            label3.TabIndex = 0;
            label3.Text = "Vui lòng nhập mật khẩu mới";
            label3.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnConfirm);
            panel1.Location = new Point(197, 422);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 170);
            panel1.TabIndex = 68;
            // 
            // ThayMK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 636);
            Controls.Add(pictureBox3);
            Controls.Add(txtMKMoi);
            Controls.Add(txtPassMoi);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "ThayMK";
            Text = "ThayMK";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPassMoi;
        private TextBox txtMKMoi;
        private Button btnConfirm;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label3;
        private Panel panel1;
    }
}