namespace DuAn1_Nhom6
{
    partial class Quanlynhanvien
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
            panel2 = new Panel();
            btntimkiem = new Button();
            txttimkiem = new TextBox();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            groupBox2 = new GroupBox();
            dgvnhanvien = new DataGridView();
            groupBox1 = new GroupBox();
            txtid = new TextBox();
            label4 = new Label();
            txtmk = new TextBox();
            txtuong = new TextBox();
            txtsdt = new TextBox();
            rbtnam = new RadioButton();
            rbtnu = new RadioButton();
            txtngaysinh = new DateTimePicker();
            txtemail = new TextBox();
            txtten = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvnhanvien).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btntimkiem);
            panel2.Controls.Add(txttimkiem);
            panel2.Controls.Add(btnxoa);
            panel2.Controls.Add(btnsua);
            panel2.Controls.Add(btnthem);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(844, 491);
            panel2.TabIndex = 74;
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(83, 243);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(94, 29);
            btntimkiem.TabIndex = 12;
            btntimkiem.Text = "Tìm Kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(183, 244);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(163, 27);
            txttimkiem.TabIndex = 11;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(725, 240);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 9;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(625, 240);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 8;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(525, 240);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 7;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvnhanvien);
            groupBox2.Location = new Point(12, 271);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(815, 213);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hiển thị";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dgvnhanvien
            // 
            dgvnhanvien.AllowUserToAddRows = false;
            dgvnhanvien.AllowUserToDeleteRows = false;
            dgvnhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvnhanvien.Location = new Point(19, 67);
            dgvnhanvien.Name = "dgvnhanvien";
            dgvnhanvien.ReadOnly = true;
            dgvnhanvien.RowHeadersWidth = 51;
            dgvnhanvien.RowTemplate.Height = 29;
            dgvnhanvien.Size = new Size(785, 140);
            dgvnhanvien.TabIndex = 0;
            dgvnhanvien.CellContentClick += dgvnhanvien_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtid);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtmk);
            groupBox1.Controls.Add(txtuong);
            groupBox1.Controls.Add(txtsdt);
            groupBox1.Controls.Add(rbtnam);
            groupBox1.Controls.Add(rbtnu);
            groupBox1.Controls.Add(txtngaysinh);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(txtten);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(3, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(819, 219);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý nhân viên";
            // 
            // txtid
            // 
            txtid.Location = new Point(120, 35);
            txtid.Name = "txtid";
            txtid.Size = new Size(251, 27);
            txtid.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 38);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 12;
            label4.Text = "Mã nhân viên";
            // 
            // txtmk
            // 
            txtmk.Location = new Point(522, 127);
            txtmk.Name = "txtmk";
            txtmk.PasswordChar = '*';
            txtmk.Size = new Size(205, 27);
            txtmk.TabIndex = 11;
            // 
            // txtuong
            // 
            txtuong.Location = new Point(522, 79);
            txtuong.Name = "txtuong";
            txtuong.Size = new Size(205, 27);
            txtuong.TabIndex = 11;
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(522, 35);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(205, 27);
            txtsdt.TabIndex = 11;
            // 
            // rbtnam
            // 
            rbtnam.AutoSize = true;
            rbtnam.Location = new Point(611, 178);
            rbtnam.Name = "rbtnam";
            rbtnam.Size = new Size(62, 24);
            rbtnam.TabIndex = 10;
            rbtnam.TabStop = true;
            rbtnam.Text = "Nam";
            rbtnam.UseVisualStyleBackColor = true;
            // 
            // rbtnu
            // 
            rbtnu.AutoSize = true;
            rbtnu.Location = new Point(522, 178);
            rbtnu.Name = "rbtnu";
            rbtnu.Size = new Size(50, 24);
            rbtnu.TabIndex = 10;
            rbtnu.TabStop = true;
            rbtnu.Text = "Nữ";
            rbtnu.UseVisualStyleBackColor = true;
            rbtnu.CheckedChanged += rbtnu_CheckedChanged;
            // 
            // txtngaysinh
            // 
            txtngaysinh.CustomFormat = "";
            txtngaysinh.Format = DateTimePickerFormat.Short;
            txtngaysinh.Location = new Point(121, 119);
            txtngaysinh.Name = "txtngaysinh";
            txtngaysinh.Size = new Size(250, 27);
            txtngaysinh.TabIndex = 9;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(121, 169);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(250, 27);
            txtemail.TabIndex = 8;
            // 
            // txtten
            // 
            txtten.Location = new Point(121, 77);
            txtten.Name = "txtten";
            txtten.Size = new Size(250, 27);
            txtten.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(397, 84);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 7;
            label8.Text = "Lương";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(397, 178);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 6;
            label7.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(397, 134);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 5;
            label6.Text = "Mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 172);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 84);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 124);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 42);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // Quanlynhanvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 615);
            Controls.Add(panel2);
            Name = "Quanlynhanvien";
            Text = "Quanlynhanvien";
            Load += Quanlynhanvien_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvnhanvien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private GroupBox groupBox2;
        private DataGridView dgvnhanvien;
        private GroupBox groupBox1;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
        private TextBox txtmk;
        private TextBox txtuong;
        private TextBox txtsdt;
        private RadioButton rbtnam;
        private RadioButton rbtnu;
        private DateTimePicker txtngaysinh;
        private TextBox txtemail;
        private TextBox txtten;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtid;
        private Label label4;
        private TextBox txttimkiem;
        private Button btntimkiem;
    }
}