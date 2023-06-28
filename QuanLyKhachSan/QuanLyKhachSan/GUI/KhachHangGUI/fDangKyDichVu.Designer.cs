namespace QuanLyKhachSan.GUI.KhachHangGUI
{
    partial class fDangKyDichVu
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
            this.label2 = new System.Windows.Forms.Label();
            this.dvDaChonDtgv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xacNhanBtn = new System.Windows.Forms.Button();
            this.traCuuDVBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.maKHTxb = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.maPDPTxb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDaChonDtgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(418, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 36);
            this.label1.TabIndex = 90;
            this.label1.Text = "Đăng ký dịch vụ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dvDaChonDtgv);
            this.panel1.Location = new System.Drawing.Point(14, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 482);
            this.panel1.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dịch vụ đã chọn:";
            // 
            // dvDaChonDtgv
            // 
            this.dvDaChonDtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvDaChonDtgv.Location = new System.Drawing.Point(6, 23);
            this.dvDaChonDtgv.Name = "dvDaChonDtgv";
            this.dvDaChonDtgv.RowHeadersWidth = 51;
            this.dvDaChonDtgv.RowTemplate.Height = 24;
            this.dvDaChonDtgv.Size = new System.Drawing.Size(594, 453);
            this.dvDaChonDtgv.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.xacNhanBtn);
            this.panel2.Controls.Add(this.traCuuDVBtn);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(606, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 453);
            this.panel2.TabIndex = 4;
            // 
            // xacNhanBtn
            // 
            this.xacNhanBtn.Location = new System.Drawing.Point(332, 69);
            this.xacNhanBtn.Name = "xacNhanBtn";
            this.xacNhanBtn.Size = new System.Drawing.Size(89, 23);
            this.xacNhanBtn.TabIndex = 4;
            this.xacNhanBtn.Text = "Xác nhận";
            this.xacNhanBtn.UseVisualStyleBackColor = true;
            // 
            // traCuuDVBtn
            // 
            this.traCuuDVBtn.Location = new System.Drawing.Point(205, 69);
            this.traCuuDVBtn.Name = "traCuuDVBtn";
            this.traCuuDVBtn.Size = new System.Drawing.Size(121, 23);
            this.traCuuDVBtn.TabIndex = 3;
            this.traCuuDVBtn.Text = "Tra cứu dịch vụ";
            this.traCuuDVBtn.UseVisualStyleBackColor = true;
            this.traCuuDVBtn.Click += new System.EventHandler(this.traCuuDVBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.maKHTxb);
            this.panel4.Location = new System.Drawing.Point(2, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(418, 27);
            this.panel4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã khách hàng:";
            // 
            // maKHTxb
            // 
            this.maKHTxb.Location = new System.Drawing.Point(139, 1);
            this.maKHTxb.Name = "maKHTxb";
            this.maKHTxb.Size = new System.Drawing.Size(276, 22);
            this.maKHTxb.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.maPDPTxb);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 27);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã phiếu đặt phòng:";
            // 
            // maPDPTxb
            // 
            this.maPDPTxb.Location = new System.Drawing.Point(138, 1);
            this.maPDPTxb.Name = "maPDPTxb";
            this.maPDPTxb.Size = new System.Drawing.Size(276, 22);
            this.maPDPTxb.TabIndex = 0;
            // 
            // fDangKyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 573);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "fDangKyDichVu";
            this.Text = "fDangKyDichVu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDaChonDtgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dvDaChonDtgv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button xacNhanBtn;
        private System.Windows.Forms.Button traCuuDVBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox maKHTxb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maPDPTxb;
    }
}