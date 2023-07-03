namespace QuanLyKhachSan.GUI.KhachHangGUI
{
    partial class fDangKyTour
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maTourLb = new System.Windows.Forms.Label();
            this.maKHLb = new System.Windows.Forms.Label();
            this.moTaLb = new System.Windows.Forms.Label();
            this.maDTLb = new System.Windows.Forms.Label();
            this.giaLb = new System.Windows.Forms.Label();
            this.diaDiemLb = new System.Windows.Forms.Label();
            this.tenTourLb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tourDaChonDtgv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.yeuCauDBTxb = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dvDuaDonCbb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.soNguoiTxb = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tgKhoiHanhDtpk = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.xacNhanBtn = new System.Windows.Forms.Button();
            this.traCuuTourBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourDaChonDtgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(390, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 36);
            this.label1.TabIndex = 91;
            this.label1.Text = "Đăng ký tour du lịch";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maTourLb);
            this.panel1.Controls.Add(this.maKHLb);
            this.panel1.Controls.Add(this.moTaLb);
            this.panel1.Controls.Add(this.maDTLb);
            this.panel1.Controls.Add(this.giaLb);
            this.panel1.Controls.Add(this.diaDiemLb);
            this.panel1.Controls.Add(this.tenTourLb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tourDaChonDtgv);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(14, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 482);
            this.panel1.TabIndex = 92;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // maTourLb
            // 
            this.maTourLb.AutoSize = true;
            this.maTourLb.Location = new System.Drawing.Point(3, 65);
            this.maTourLb.Name = "maTourLb";
            this.maTourLb.Size = new System.Drawing.Size(95, 16);
            this.maTourLb.TabIndex = 0;
            this.maTourLb.Text = "Mã tour du lịch:";
            // 
            // maKHLb
            // 
            this.maKHLb.AutoSize = true;
            this.maKHLb.Location = new System.Drawing.Point(690, 10);
            this.maKHLb.Name = "maKHLb";
            this.maKHLb.Size = new System.Drawing.Size(101, 16);
            this.maKHLb.TabIndex = 10;
            this.maKHLb.Text = "Mã khách hàng:";
            // 
            // moTaLb
            // 
            this.moTaLb.AutoSize = true;
            this.moTaLb.Location = new System.Drawing.Point(3, 165);
            this.moTaLb.Name = "moTaLb";
            this.moTaLb.Size = new System.Drawing.Size(43, 16);
            this.moTaLb.TabIndex = 9;
            this.moTaLb.Text = "Mô tả:";
            // 
            // maDTLb
            // 
            this.maDTLb.AutoSize = true;
            this.maDTLb.Location = new System.Drawing.Point(3, 140);
            this.maDTLb.Name = "maDTLb";
            this.maDTLb.Size = new System.Drawing.Size(72, 16);
            this.maDTLb.TabIndex = 8;
            this.maDTLb.Text = "Mã đối tác:";
            // 
            // giaLb
            // 
            this.giaLb.AutoSize = true;
            this.giaLb.Location = new System.Drawing.Point(3, 115);
            this.giaLb.Name = "giaLb";
            this.giaLb.Size = new System.Drawing.Size(31, 16);
            this.giaLb.TabIndex = 7;
            this.giaLb.Text = "Giá:";
            // 
            // diaDiemLb
            // 
            this.diaDiemLb.AutoSize = true;
            this.diaDiemLb.Location = new System.Drawing.Point(3, 90);
            this.diaDiemLb.Name = "diaDiemLb";
            this.diaDiemLb.Size = new System.Drawing.Size(63, 16);
            this.diaDiemLb.TabIndex = 6;
            this.diaDiemLb.Text = "Địa điểm:";
            // 
            // tenTourLb
            // 
            this.tenTourLb.AutoSize = true;
            this.tenTourLb.Location = new System.Drawing.Point(3, 40);
            this.tenTourLb.Name = "tenTourLb";
            this.tenTourLb.Size = new System.Drawing.Size(59, 16);
            this.tenTourLb.TabIndex = 5;
            this.tenTourLb.Text = "Tên tour:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tour đang chọn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tour đã đăng ký:";
            // 
            // tourDaChonDtgv
            // 
            this.tourDaChonDtgv.AllowUserToAddRows = false;
            this.tourDaChonDtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tourDaChonDtgv.Location = new System.Drawing.Point(6, 237);
            this.tourDaChonDtgv.Name = "tourDaChonDtgv";
            this.tourDaChonDtgv.RowHeadersWidth = 51;
            this.tourDaChonDtgv.RowTemplate.Height = 24;
            this.tourDaChonDtgv.Size = new System.Drawing.Size(670, 239);
            this.tourDaChonDtgv.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.xacNhanBtn);
            this.panel2.Controls.Add(this.traCuuTourBtn);
            this.panel2.Location = new System.Drawing.Point(682, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 447);
            this.panel2.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.yeuCauDBTxb);
            this.panel8.Location = new System.Drawing.Point(3, 100);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(341, 64);
            this.panel8.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Yêu cầu khác:";
            // 
            // yeuCauDBTxb
            // 
            this.yeuCauDBTxb.Location = new System.Drawing.Point(125, 1);
            this.yeuCauDBTxb.Multiline = true;
            this.yeuCauDBTxb.Name = "yeuCauDBTxb";
            this.yeuCauDBTxb.Size = new System.Drawing.Size(213, 60);
            this.yeuCauDBTxb.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dvDuaDonCbb);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(3, 36);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(341, 27);
            this.panel7.TabIndex = 7;
            // 
            // dvDuaDonCbb
            // 
            this.dvDuaDonCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dvDuaDonCbb.FormattingEnabled = true;
            this.dvDuaDonCbb.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.dvDuaDonCbb.Location = new System.Drawing.Point(125, 3);
            this.dvDuaDonCbb.Name = "dvDuaDonCbb";
            this.dvDuaDonCbb.Size = new System.Drawing.Size(213, 24);
            this.dvDuaDonCbb.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Dịch vụ đưa đón:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.soNguoiTxb);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(341, 27);
            this.panel6.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số người:";
            // 
            // soNguoiTxb
            // 
            this.soNguoiTxb.Location = new System.Drawing.Point(125, 2);
            this.soNguoiTxb.Name = "soNguoiTxb";
            this.soNguoiTxb.Size = new System.Drawing.Size(213, 22);
            this.soNguoiTxb.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tgKhoiHanhDtpk);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(3, 69);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(341, 27);
            this.panel5.TabIndex = 5;
            // 
            // tgKhoiHanhDtpk
            // 
            this.tgKhoiHanhDtpk.Location = new System.Drawing.Point(125, 3);
            this.tgKhoiHanhDtpk.Name = "tgKhoiHanhDtpk";
            this.tgKhoiHanhDtpk.Size = new System.Drawing.Size(213, 22);
            this.tgKhoiHanhDtpk.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thời gian:";
            // 
            // xacNhanBtn
            // 
            this.xacNhanBtn.Location = new System.Drawing.Point(252, 170);
            this.xacNhanBtn.Name = "xacNhanBtn";
            this.xacNhanBtn.Size = new System.Drawing.Size(89, 23);
            this.xacNhanBtn.TabIndex = 4;
            this.xacNhanBtn.Text = "Xác nhận";
            this.xacNhanBtn.UseVisualStyleBackColor = true;
            this.xacNhanBtn.Click += new System.EventHandler(this.xacNhanBtn_Click);
            // 
            // traCuuTourBtn
            // 
            this.traCuuTourBtn.Location = new System.Drawing.Point(128, 170);
            this.traCuuTourBtn.Name = "traCuuTourBtn";
            this.traCuuTourBtn.Size = new System.Drawing.Size(121, 23);
            this.traCuuTourBtn.TabIndex = 3;
            this.traCuuTourBtn.Text = "Tra cứu tour";
            this.traCuuTourBtn.UseVisualStyleBackColor = true;
            this.traCuuTourBtn.Click += new System.EventHandler(this.traCuuTourBtn_Click);
            // 
            // fDangKyTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 573);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "fDangKyTour";
            this.Text = "fDangKyTour";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourDaChonDtgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tourDaChonDtgv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button xacNhanBtn;
        private System.Windows.Forms.Button traCuuTourBtn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox yeuCauDBTxb;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox soNguoiTxb;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker tgKhoiHanhDtpk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dvDuaDonCbb;
        private System.Windows.Forms.Label maTourLb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tenTourLb;
        private System.Windows.Forms.Label diaDiemLb;
        private System.Windows.Forms.Label maDTLb;
        private System.Windows.Forms.Label giaLb;
        private System.Windows.Forms.Label moTaLb;
        private System.Windows.Forms.Label maKHLb;
    }
}