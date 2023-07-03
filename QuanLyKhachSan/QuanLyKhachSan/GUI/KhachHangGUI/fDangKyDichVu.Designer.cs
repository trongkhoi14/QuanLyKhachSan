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
            this.dvDaDKDtgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xacNhanBtn = new System.Windows.Forms.Button();
            this.traCuuDVBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.maPDPLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dvDaChonDtgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDaDKDtgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDaChonDtgv)).BeginInit();
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
            this.panel1.Controls.Add(this.dvDaDKDtgv);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dvDaChonDtgv);
            this.panel1.Location = new System.Drawing.Point(14, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 482);
            this.panel1.TabIndex = 91;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dvDaDKDtgv
            // 
            this.dvDaDKDtgv.AllowUserToAddRows = false;
            this.dvDaDKDtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvDaDKDtgv.Location = new System.Drawing.Point(6, 279);
            this.dvDaDKDtgv.Name = "dvDaDKDtgv";
            this.dvDaDKDtgv.RowHeadersWidth = 51;
            this.dvDaDKDtgv.RowTemplate.Height = 24;
            this.dvDaDKDtgv.Size = new System.Drawing.Size(795, 200);
            this.dvDaDKDtgv.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dịch vụ đã đăng ký:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.xacNhanBtn);
            this.panel2.Controls.Add(this.traCuuDVBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(807, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 456);
            this.panel2.TabIndex = 4;
            // 
            // xacNhanBtn
            // 
            this.xacNhanBtn.Location = new System.Drawing.Point(130, 36);
            this.xacNhanBtn.Name = "xacNhanBtn";
            this.xacNhanBtn.Size = new System.Drawing.Size(89, 23);
            this.xacNhanBtn.TabIndex = 7;
            this.xacNhanBtn.Text = "Đăng ký";
            this.xacNhanBtn.UseVisualStyleBackColor = true;
            this.xacNhanBtn.Click += new System.EventHandler(this.xacNhanBtn_Click);
            // 
            // traCuuDVBtn
            // 
            this.traCuuDVBtn.Location = new System.Drawing.Point(3, 36);
            this.traCuuDVBtn.Name = "traCuuDVBtn";
            this.traCuuDVBtn.Size = new System.Drawing.Size(121, 23);
            this.traCuuDVBtn.TabIndex = 6;
            this.traCuuDVBtn.Text = "Tra cứu dịch vụ";
            this.traCuuDVBtn.UseVisualStyleBackColor = true;
            this.traCuuDVBtn.Click += new System.EventHandler(this.traCuuDVBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.maPDPLb);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 27);
            this.panel3.TabIndex = 5;
            // 
            // maPDPLb
            // 
            this.maPDPLb.AutoSize = true;
            this.maPDPLb.Location = new System.Drawing.Point(4, 4);
            this.maPDPLb.Name = "maPDPLb";
            this.maPDPLb.Size = new System.Drawing.Size(128, 16);
            this.maPDPLb.TabIndex = 0;
            this.maPDPLb.Text = "Mã phiếu đặt phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dịch vụ đã chọn:";
            // 
            // dvDaChonDtgv
            // 
            this.dvDaChonDtgv.AllowUserToAddRows = false;
            this.dvDaChonDtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvDaChonDtgv.Location = new System.Drawing.Point(6, 23);
            this.dvDaChonDtgv.Name = "dvDaChonDtgv";
            this.dvDaChonDtgv.RowHeadersWidth = 51;
            this.dvDaChonDtgv.RowTemplate.Height = 24;
            this.dvDaChonDtgv.Size = new System.Drawing.Size(795, 200);
            this.dvDaChonDtgv.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)(this.dvDaDKDtgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDaChonDtgv)).EndInit();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label maPDPLb;
        private System.Windows.Forms.DataGridView dvDaDKDtgv;
        private System.Windows.Forms.Label label3;
    }
}