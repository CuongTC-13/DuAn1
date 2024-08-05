namespace DuAn1_Nhom6
{
    partial class Quanlykho
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
            button2 = new Button();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            txtNgayNhap = new TextBox();
            txtDiaChi = new TextBox();
            txtSLCon = new TextBox();
            txtSLNhap = new TextBox();
            txtTenSanPham = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            btnAdd = new Button();
            btnEdit = new Button();
            txtTenKH = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtMaKhoHang = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(492, 170);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(44, 191);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 51);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNgayNhap);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtSLCon);
            groupBox1.Controls.Add(txtSLNhap);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(txtTenKH);
            groupBox1.Controls.Add(txtMaKhoHang);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(34, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(639, 322);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // txtNgayNhap
            // 
            txtNgayNhap.Location = new Point(141, 272);
            txtNgayNhap.Name = "txtNgayNhap";
            txtNgayNhap.Size = new Size(474, 27);
            txtNgayNhap.TabIndex = 3;
            txtNgayNhap.TextChanged += txtNgayNhap_TextChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(141, 235);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(474, 27);
            txtDiaChi.TabIndex = 3;
            // 
            // txtSLCon
            // 
            txtSLCon.Location = new Point(141, 197);
            txtSLCon.Name = "txtSLCon";
            txtSLCon.Size = new Size(474, 27);
            txtSLCon.TabIndex = 3;
            // 
            // txtSLNhap
            // 
            txtSLNhap.Location = new Point(141, 157);
            txtSLNhap.Name = "txtSLNhap";
            txtSLNhap.Size = new Size(474, 27);
            txtSLNhap.TabIndex = 3;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(141, 119);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(474, 27);
            txtTenSanPham.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 272);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 2;
            label7.Text = "Ngày Nhập";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 235);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 2;
            label6.Text = "Địa Chỉ";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 197);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 2;
            label5.Text = "Số Lượng Còn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 157);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 2;
            label4.Text = "Số Lượng Nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 121);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên Sản Phẩm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(37, 351);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(853, 211);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hiển thị";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(817, 143);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Controls.Add(btnEdit);
            groupBox3.Controls.Add(btnDelete);
            groupBox3.Location = new Point(694, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(196, 297);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(44, 47);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 51);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(44, 117);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(121, 51);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(141, 86);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(474, 27);
            txtTenKH.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 86);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên kho hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 50);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 2;
            label1.Text = "\u007fMã Kho Hang";
            // 
            // txtMaKhoHang
            // 
            txtMaKhoHang.Location = new Point(141, 50);
            txtMaKhoHang.Name = "txtMaKhoHang";
            txtMaKhoHang.Size = new Size(474, 27);
            txtMaKhoHang.TabIndex = 3;
            // 
            // Quanlykho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(groupBox3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Quanlykho";
            Text = "Quanlykho";
            Load += Quanlykho_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button btnDelete;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnAdd;
        private Button btnEdit;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtNgayNhap;
        private TextBox txtDiaChi;
        private TextBox txtSLCon;
        private TextBox txtSLNhap;
        private TextBox txtTenSanPham;
        private DataGridView dataGridView1;
        private TextBox txtTenKH;
        private TextBox txtMaKhoHang;
        private Label label2;
        private Label label1;
    }
}