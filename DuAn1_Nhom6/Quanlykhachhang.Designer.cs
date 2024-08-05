namespace DuAn1_Nhom6
{
    partial class Quanlykhachhang
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtIDKH = new TextBox();
            label6 = new Label();
            txtTenKH = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtDiaChi = new TextBox();
            dgvQLKH = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            label7 = new Label();
            rdbNam = new RadioButton();
            rdbNu = new RadioButton();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvQLKH).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Khách Hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 32);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 1;
            label2.Text = "ID Khách Hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 71);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên Khách Hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 109);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 3;
            label4.Text = "Điện Thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 138);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // txtIDKH
            // 
            txtIDKH.Location = new Point(156, 30);
            txtIDKH.Margin = new Padding(2);
            txtIDKH.Name = "txtIDKH";
            txtIDKH.Size = new Size(334, 27);
            txtIDKH.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 211);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 6;
            label6.Text = "Địa Chỉ";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(156, 66);
            txtTenKH.Margin = new Padding(2);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(334, 27);
            txtTenKH.TabIndex = 7;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(156, 104);
            txtSDT.Margin = new Padding(2);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(334, 27);
            txtSDT.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(156, 138);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(334, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(156, 211);
            txtDiaChi.Margin = new Padding(2);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(334, 27);
            txtDiaChi.TabIndex = 10;
            // 
            // dgvQLKH
            // 
            dgvQLKH.AllowUserToAddRows = false;
            dgvQLKH.AllowUserToDeleteRows = false;
            dgvQLKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLKH.Location = new Point(18, 250);
            dgvQLKH.Margin = new Padding(2);
            dgvQLKH.Name = "dgvQLKH";
            dgvQLKH.ReadOnly = true;
            dgvQLKH.RowHeadersWidth = 62;
            dgvQLKH.RowTemplate.Height = 33;
            dgvQLKH.Size = new Size(678, 146);
            dgvQLKH.TabIndex = 11;
            dgvQLKH.CellContentClick += dgvQLKH_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(534, 86);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 27);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(534, 138);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 27);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(534, 193);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 27);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 179);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 15;
            label7.Text = "Giới Tính";
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(156, 176);
            rdbNam.Margin = new Padding(2);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(62, 24);
            rdbNam.TabIndex = 16;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Location = new Point(377, 176);
            rdbNu.Margin = new Padding(2);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(50, 24);
            rdbNu.TabIndex = 17;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(502, 30);
            txtTimKiem.Margin = new Padding(2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(194, 27);
            txtTimKiem.TabIndex = 18;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(711, 30);
            btnTimKiem.Margin = new Padding(2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(90, 27);
            btnTimKiem.TabIndex = 19;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // Quanlykhachhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 398);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(rdbNu);
            Controls.Add(rdbNam);
            Controls.Add(label7);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvQLKH);
            Controls.Add(txtDiaChi);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtTenKH);
            Controls.Add(label6);
            Controls.Add(txtIDKH);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Quanlykhachhang";
            Text = "Quanlykhachhang";
            Load += Quanlykhachhang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQLKH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIDKH;
        private Label label6;
        private TextBox txtTenKH;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtDiaChi;
        private DataGridView dgvQLKH;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Label label7;
        private RadioButton rdbNam;
        private RadioButton rdbNu;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
    }
}