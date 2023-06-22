namespace QuanLyKhachSan.GUI.KhachHangGUI
{
    partial class fCapNhatPhieuDatPhong
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
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SoDemLuuTruTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NgayDenDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SoNguoiTrongDoanTBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DsPhongDaDangKyDataGridView = new System.Windows.Forms.DataGridView();
            this.HoanThanhBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MaPDPTBox = new System.Windows.Forms.TextBox();
            this.LuuYTBox = new System.Windows.Forms.TextBox();
            this.NotiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DsPhongDaDangKyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(213, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(383, 36);
            this.label11.TabIndex = 89;
            this.label11.Text = "Cập nhật phiếu đặt phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 92;
            this.label2.Text = "Số đêm lưu trú";
            // 
            // SoDemLuuTruTBox
            // 
            this.SoDemLuuTruTBox.Location = new System.Drawing.Point(117, 142);
            this.SoDemLuuTruTBox.Name = "SoDemLuuTruTBox";
            this.SoDemLuuTruTBox.Size = new System.Drawing.Size(108, 22);
            this.SoDemLuuTruTBox.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 94;
            this.label3.Text = "Ngày đến";
            // 
            // NgayDenDateTimePicker
            // 
            this.NgayDenDateTimePicker.Location = new System.Drawing.Point(117, 180);
            this.NgayDenDateTimePicker.Name = "NgayDenDateTimePicker";
            this.NgayDenDateTimePicker.Size = new System.Drawing.Size(173, 22);
            this.NgayDenDateTimePicker.TabIndex = 95;
            // 
            // SoNguoiTrongDoanTBox
            // 
            this.SoNguoiTrongDoanTBox.Location = new System.Drawing.Point(153, 222);
            this.SoNguoiTrongDoanTBox.Name = "SoNguoiTrongDoanTBox";
            this.SoNguoiTrongDoanTBox.Size = new System.Drawing.Size(108, 22);
            this.SoNguoiTrongDoanTBox.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 96;
            this.label4.Text = "Số người trong đoàn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 16);
            this.label5.TabIndex = 98;
            this.label5.Text = "Lưu ý: mặc định 1 là không đi theo đoàn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 99;
            this.label6.Text = "Phòng đã đăng ký";
            // 
            // DsPhongDaDangKyDataGridView
            // 
            this.DsPhongDaDangKyDataGridView.AllowUserToAddRows = false;
            this.DsPhongDaDangKyDataGridView.AllowUserToDeleteRows = false;
            this.DsPhongDaDangKyDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DsPhongDaDangKyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DsPhongDaDangKyDataGridView.Location = new System.Drawing.Point(390, 96);
            this.DsPhongDaDangKyDataGridView.Name = "DsPhongDaDangKyDataGridView";
            this.DsPhongDaDangKyDataGridView.ReadOnly = true;
            this.DsPhongDaDangKyDataGridView.RowHeadersWidth = 51;
            this.DsPhongDaDangKyDataGridView.RowTemplate.Height = 24;
            this.DsPhongDaDangKyDataGridView.Size = new System.Drawing.Size(676, 265);
            this.DsPhongDaDangKyDataGridView.TabIndex = 100;
            // 
            // HoanThanhBtn
            // 
            this.HoanThanhBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HoanThanhBtn.Location = new System.Drawing.Point(959, 387);
            this.HoanThanhBtn.Name = "HoanThanhBtn";
            this.HoanThanhBtn.Size = new System.Drawing.Size(107, 29);
            this.HoanThanhBtn.TabIndex = 101;
            this.HoanThanhBtn.Text = "Cập nhật";
            this.HoanThanhBtn.UseVisualStyleBackColor = false;
            this.HoanThanhBtn.Click += new System.EventHandler(this.HoanThanhBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 90;
            this.label1.Text = "Mã phiếu đặt phòng";
            // 
            // MaPDPTBox
            // 
            this.MaPDPTBox.Location = new System.Drawing.Point(163, 97);
            this.MaPDPTBox.Name = "MaPDPTBox";
            this.MaPDPTBox.ReadOnly = true;
            this.MaPDPTBox.Size = new System.Drawing.Size(108, 22);
            this.MaPDPTBox.TabIndex = 91;
            // 
            // LuuYTBox
            // 
            this.LuuYTBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LuuYTBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuuYTBox.Location = new System.Drawing.Point(12, 346);
            this.LuuYTBox.Multiline = true;
            this.LuuYTBox.Name = "LuuYTBox";
            this.LuuYTBox.ReadOnly = true;
            this.LuuYTBox.Size = new System.Drawing.Size(339, 84);
            this.LuuYTBox.TabIndex = 102;
            // 
            // NotiLabel
            // 
            this.NotiLabel.AutoSize = true;
            this.NotiLabel.ForeColor = System.Drawing.Color.Red;
            this.NotiLabel.Location = new System.Drawing.Point(387, 387);
            this.NotiLabel.Name = "NotiLabel";
            this.NotiLabel.Size = new System.Drawing.Size(31, 16);
            this.NotiLabel.TabIndex = 103;
            this.NotiLabel.Text = "Noti";
            // 
            // fCapNhatPhieuDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1098, 487);
            this.Controls.Add(this.NotiLabel);
            this.Controls.Add(this.LuuYTBox);
            this.Controls.Add(this.HoanThanhBtn);
            this.Controls.Add(this.DsPhongDaDangKyDataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SoNguoiTrongDoanTBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NgayDenDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SoDemLuuTruTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaPDPTBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Name = "fCapNhatPhieuDatPhong";
            this.Text = "fCapNhatPhieuDatPhong";
            this.Load += new System.EventHandler(this.fCapNhatPhieuDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsPhongDaDangKyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SoDemLuuTruTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker NgayDenDateTimePicker;
        private System.Windows.Forms.TextBox SoNguoiTrongDoanTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DsPhongDaDangKyDataGridView;
        private System.Windows.Forms.Button HoanThanhBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaPDPTBox;
        private System.Windows.Forms.TextBox LuuYTBox;
        private System.Windows.Forms.Label NotiLabel;
    }
}