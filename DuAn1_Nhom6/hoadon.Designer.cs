namespace DuAn1_Nhom6
{
    partial class hoadon
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
            dgvHDCT = new DataGridView();
            dgvHD = new DataGridView();
            button1 = new Button();
            txtSP = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSZ = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtSL = new TextBox();
            label5 = new Label();
            txtGia = new TextBox();
            label6 = new Label();
            DTPVC = new DateTimePicker();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            txtTK = new TextBox();
            button4 = new Button();
            RBDTT = new RadioButton();
            RBCTT = new RadioButton();
            label9 = new Label();
            txtHDCT = new TextBox();
            button5 = new Button();
            label10 = new Label();
            txtMSP = new TextBox();
            BTHDCT = new Button();
            button6 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtSLHDCY = new TextBox();
            txtIDNV = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvHDCT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHD).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHDCT
            // 
            dgvHDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHDCT.Location = new Point(19, 29);
            dgvHDCT.Margin = new Padding(3, 4, 3, 4);
            dgvHDCT.Name = "dgvHDCT";
            dgvHDCT.RowHeadersWidth = 51;
            dgvHDCT.RowTemplate.Height = 25;
            dgvHDCT.Size = new Size(537, 343);
            dgvHDCT.TabIndex = 1;
            dgvHDCT.CellContentClick += dgvHDCT_CellContentClick;
            // 
            // dgvHD
            // 
            dgvHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHD.Location = new Point(7, 29);
            dgvHD.Margin = new Padding(3, 4, 3, 4);
            dgvHD.Name = "dgvHD";
            dgvHD.RowHeadersWidth = 51;
            dgvHD.RowTemplate.Height = 25;
            dgvHD.Size = new Size(1035, 263);
            dgvHD.TabIndex = 2;
            dgvHD.CellContentClick += dataGridView3_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(971, 452);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 3;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSP
            // 
            txtSP.Location = new Point(142, 123);
            txtSP.Margin = new Padding(3, 4, 3, 4);
            txtSP.Name = "txtSP";
            txtSP.Size = new Size(340, 27);
            txtSP.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 127);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 5;
            label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 183);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 7;
            label2.Text = "MenhGiaVoucher";
            // 
            // txtSZ
            // 
            txtSZ.Location = new Point(142, 179);
            txtSZ.Margin = new Padding(3, 4, 3, 4);
            txtSZ.Name = "txtSZ";
            txtSZ.Size = new Size(340, 27);
            txtSZ.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 240);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 9;
            label3.Text = "HSDVoucher";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 296);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 11;
            label4.Text = "Số lượng Mua";
            // 
            // txtSL
            // 
            txtSL.Location = new Point(142, 285);
            txtSL.Margin = new Padding(3, 4, 3, 4);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(340, 27);
            txtSL.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 351);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 13;
            label5.Text = "Giá";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(142, 340);
            txtGia.Margin = new Padding(3, 4, 3, 4);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(340, 27);
            txtGia.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 408);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 15;
            label6.Text = "Trạng thái";
            // 
            // DTPVC
            // 
            DTPVC.CustomFormat = "";
            DTPVC.Format = DateTimePickerFormat.Short;
            DTPVC.Location = new Point(142, 232);
            DTPVC.Name = "DTPVC";
            DTPVC.Size = new Size(251, 27);
            DTPVC.TabIndex = 17;
            // 
            // button2
            // 
            button2.Location = new Point(67, 453);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 18;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(291, 453);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 19;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(526, 464);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 21;
            label7.Text = "Tìm kiếm";
            label7.Click += label7_Click;
            // 
            // txtTK
            // 
            txtTK.Location = new Point(625, 455);
            txtTK.Margin = new Padding(3, 4, 3, 4);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(340, 27);
            txtTK.TabIndex = 20;
            // 
            // button4
            // 
            button4.Location = new Point(181, 453);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 22;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // RBDTT
            // 
            RBDTT.AutoSize = true;
            RBDTT.Location = new Point(142, 403);
            RBDTT.Margin = new Padding(3, 4, 3, 4);
            RBDTT.Name = "RBDTT";
            RBDTT.Size = new Size(124, 24);
            RBDTT.TabIndex = 23;
            RBDTT.TabStop = true;
            RBDTT.Text = "Đã thanh toán";
            RBDTT.UseVisualStyleBackColor = true;
            // 
            // RBCTT
            // 
            RBCTT.AutoSize = true;
            RBCTT.Location = new Point(307, 403);
            RBCTT.Margin = new Padding(3, 4, 3, 4);
            RBCTT.Name = "RBCTT";
            RBCTT.Size = new Size(131, 24);
            RBCTT.TabIndex = 24;
            RBCTT.TabStop = true;
            RBCTT.Text = "Chờ thanh toán";
            RBCTT.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 68);
            label9.Name = "label9";
            label9.Size = new Size(113, 20);
            label9.TabIndex = 28;
            label9.Text = "Mã Hóa đơn CT";
            // 
            // txtHDCT
            // 
            txtHDCT.Location = new Point(142, 64);
            txtHDCT.Margin = new Padding(3, 4, 3, 4);
            txtHDCT.Name = "txtHDCT";
            txtHDCT.Size = new Size(340, 27);
            txtHDCT.TabIndex = 27;
            // 
            // button5
            // 
            button5.Location = new Point(407, 455);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 31);
            button5.TabIndex = 29;
            button5.Text = "Xóa";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 20);
            label10.Name = "label10";
            label10.Size = new Size(99, 20);
            label10.TabIndex = 31;
            label10.Text = "Mã Sản Phẩm";
            // 
            // txtMSP
            // 
            txtMSP.Location = new Point(142, 16);
            txtMSP.Margin = new Padding(3, 4, 3, 4);
            txtMSP.Name = "txtMSP";
            txtMSP.Size = new Size(340, 27);
            txtMSP.TabIndex = 30;
            // 
            // BTHDCT
            // 
            BTHDCT.Location = new Point(1007, 25);
            BTHDCT.Margin = new Padding(3, 4, 3, 4);
            BTHDCT.Name = "BTHDCT";
            BTHDCT.Size = new Size(86, 31);
            BTHDCT.TabIndex = 32;
            BTHDCT.Text = "HDCT";
            BTHDCT.UseVisualStyleBackColor = true;
            BTHDCT.Click += BTHDCT_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1072, 93);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(39, 31);
            button6.TabIndex = 33;
            button6.Text = "RL";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvHD);
            groupBox1.Location = new Point(23, 492);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1070, 300);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản phẩm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvHDCT);
            groupBox2.Location = new Point(502, 64);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(563, 380);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn";
            // 
            // txtSLHDCY
            // 
            txtSLHDCY.Location = new Point(521, 16);
            txtSLHDCY.Margin = new Padding(3, 4, 3, 4);
            txtSLHDCY.Name = "txtSLHDCY";
            txtSLHDCY.Size = new Size(37, 27);
            txtSLHDCY.TabIndex = 38;
            txtSLHDCY.Visible = false;
            // 
            // txtIDNV
            // 
            txtIDNV.Location = new Point(566, 16);
            txtIDNV.Margin = new Padding(3, 4, 3, 4);
            txtIDNV.Name = "txtIDNV";
            txtIDNV.Size = new Size(37, 27);
            txtIDNV.TabIndex = 39;
            txtIDNV.Visible = false;
            // 
            // hoadon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 884);
            Controls.Add(txtIDNV);
            Controls.Add(txtSLHDCY);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button6);
            Controls.Add(BTHDCT);
            Controls.Add(label10);
            Controls.Add(txtMSP);
            Controls.Add(button5);
            Controls.Add(label9);
            Controls.Add(txtHDCT);
            Controls.Add(RBCTT);
            Controls.Add(RBDTT);
            Controls.Add(button4);
            Controls.Add(label7);
            Controls.Add(txtTK);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(DTPVC);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtGia);
            Controls.Add(label4);
            Controls.Add(txtSL);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSZ);
            Controls.Add(label1);
            Controls.Add(txtSP);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "hoadon";
            Text = "hoadon";
            Load += hoadon_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvHDCT).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHD).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvHDCT;
        private DataGridView dgvHD;
        private Button button1;
        private TextBox txtSP;
        private Label label1;
        private Label label2;
        private TextBox txtSZ;
        private Label label3;
        private Label label4;
        private TextBox txtSL;
        private Label label5;
        private TextBox txtGia;
        private Label label6;
        private DateTimePicker DTPVC;
        private Button button2;
        private Button button3;
        private Label label7;
        private TextBox txtTK;
        private Button button4;
        private RadioButton RBDTT;
        private RadioButton RBCTT;
        private Label label9;
        private TextBox txtHDCT;
        private Button button5;
        private Label label10;
        private TextBox txtMSP;
        private Button BTHDCT;
        private Button button6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtSLHDCY;
        private TextBox txtIDNV;
    }
}