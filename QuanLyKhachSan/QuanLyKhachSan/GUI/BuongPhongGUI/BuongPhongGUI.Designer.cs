namespace QuanLyKhachSan.GUI.BuongPhongGUI
{
    partial class BuongPhongGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.MaPhongTBox = new System.Windows.Forms.TextBox();
            this.MoTaTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HoanThanhBtn = new System.Windows.Forms.Button();
            this.NotiLabel = new System.Windows.Forms.Label();
            this.HuongDanTBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(181, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(472, 36);
            this.label11.TabIndex = 89;
            this.label11.Text = "Phiếu đánh giá tình trạng phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 90;
            this.label1.Text = "Mã phòng";
            // 
            // MaPhongTBox
            // 
            this.MaPhongTBox.Location = new System.Drawing.Point(103, 84);
            this.MaPhongTBox.Name = "MaPhongTBox";
            this.MaPhongTBox.Size = new System.Drawing.Size(100, 22);
            this.MaPhongTBox.TabIndex = 91;
            // 
            // MoTaTBox
            // 
            this.MoTaTBox.Location = new System.Drawing.Point(103, 126);
            this.MoTaTBox.Multiline = true;
            this.MoTaTBox.Name = "MoTaTBox";
            this.MoTaTBox.Size = new System.Drawing.Size(396, 283);
            this.MoTaTBox.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 92;
            this.label2.Text = "Mô tả";
            // 
            // HoanThanhBtn
            // 
            this.HoanThanhBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HoanThanhBtn.Location = new System.Drawing.Point(736, 417);
            this.HoanThanhBtn.Name = "HoanThanhBtn";
            this.HoanThanhBtn.Size = new System.Drawing.Size(103, 33);
            this.HoanThanhBtn.TabIndex = 94;
            this.HoanThanhBtn.Text = "Hoàn thành";
            this.HoanThanhBtn.UseVisualStyleBackColor = false;
            this.HoanThanhBtn.Click += new System.EventHandler(this.HoanThanhBtn_Click);
            // 
            // NotiLabel
            // 
            this.NotiLabel.AutoSize = true;
            this.NotiLabel.ForeColor = System.Drawing.Color.Red;
            this.NotiLabel.Location = new System.Drawing.Point(100, 425);
            this.NotiLabel.Name = "NotiLabel";
            this.NotiLabel.Size = new System.Drawing.Size(31, 16);
            this.NotiLabel.TabIndex = 95;
            this.NotiLabel.Text = "Noti";
            // 
            // HuongDanTBox
            // 
            this.HuongDanTBox.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuongDanTBox.Location = new System.Drawing.Point(533, 126);
            this.HuongDanTBox.Multiline = true;
            this.HuongDanTBox.Name = "HuongDanTBox";
            this.HuongDanTBox.ReadOnly = true;
            this.HuongDanTBox.Size = new System.Drawing.Size(294, 194);
            this.HuongDanTBox.TabIndex = 96;
            // 
            // BuongPhongGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 481);
            this.Controls.Add(this.HuongDanTBox);
            this.Controls.Add(this.NotiLabel);
            this.Controls.Add(this.HoanThanhBtn);
            this.Controls.Add(this.MoTaTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaPhongTBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Name = "BuongPhongGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuongPhongGUI";
            this.Load += new System.EventHandler(this.BuongPhongGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaPhongTBox;
        private System.Windows.Forms.TextBox MoTaTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HoanThanhBtn;
        private System.Windows.Forms.Label NotiLabel;
        private System.Windows.Forms.TextBox HuongDanTBox;
    }
}