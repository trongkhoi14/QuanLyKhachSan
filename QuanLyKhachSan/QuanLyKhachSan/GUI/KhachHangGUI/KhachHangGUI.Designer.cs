namespace QuanLyKhachSan.GUI.KhachHangGUI
{
    partial class KhachHangGUI
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
            this.DatPhongBtn = new System.Windows.Forms.Button();
            this.DoiMatKhauBtn = new System.Windows.Forms.Button();
            this.ThongTinPhongDaDatBtn = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.ThanhToanBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DatPhongBtn
            // 
            this.DatPhongBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DatPhongBtn.Location = new System.Drawing.Point(12, 12);
            this.DatPhongBtn.Name = "DatPhongBtn";
            this.DatPhongBtn.Size = new System.Drawing.Size(111, 33);
            this.DatPhongBtn.TabIndex = 0;
            this.DatPhongBtn.Text = "Đặt phòng";
            this.DatPhongBtn.UseVisualStyleBackColor = false;
            this.DatPhongBtn.Click += new System.EventHandler(this.DatPhongBtn_Click);
            // 
            // DoiMatKhauBtn
            // 
            this.DoiMatKhauBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DoiMatKhauBtn.Location = new System.Drawing.Point(129, 12);
            this.DoiMatKhauBtn.Name = "DoiMatKhauBtn";
            this.DoiMatKhauBtn.Size = new System.Drawing.Size(111, 33);
            this.DoiMatKhauBtn.TabIndex = 1;
            this.DoiMatKhauBtn.Text = "Đổi mật khẩu";
            this.DoiMatKhauBtn.UseVisualStyleBackColor = false;
            this.DoiMatKhauBtn.Click += new System.EventHandler(this.DoiMatKhauBtn_Click);
            // 
            // ThongTinPhongDaDatBtn
            // 
            this.ThongTinPhongDaDatBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ThongTinPhongDaDatBtn.Location = new System.Drawing.Point(246, 12);
            this.ThongTinPhongDaDatBtn.Name = "ThongTinPhongDaDatBtn";
            this.ThongTinPhongDaDatBtn.Size = new System.Drawing.Size(112, 33);
            this.ThongTinPhongDaDatBtn.TabIndex = 2;
            this.ThongTinPhongDaDatBtn.Text = "Phòng đã đặt";
            this.ThongTinPhongDaDatBtn.UseVisualStyleBackColor = false;
            this.ThongTinPhongDaDatBtn.Click += new System.EventHandler(this.ThongTinPhongDaDatBtn_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 51);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1053, 542);
            this.panel.TabIndex = 3;
            // 
            // ThanhToanBtn
            // 
            this.ThanhToanBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ThanhToanBtn.Location = new System.Drawing.Point(364, 12);
            this.ThanhToanBtn.Name = "ThanhToanBtn";
            this.ThanhToanBtn.Size = new System.Drawing.Size(168, 33);
            this.ThanhToanBtn.TabIndex = 4;
            this.ThanhToanBtn.Text = "Hướng dẫn thanh toán";
            this.ThanhToanBtn.UseVisualStyleBackColor = false;
            this.ThanhToanBtn.Click += new System.EventHandler(this.ThanhToanBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(538, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cập nhật thông tin đặt phòng";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // KhachHangGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 613);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ThanhToanBtn);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.ThongTinPhongDaDatBtn);
            this.Controls.Add(this.DoiMatKhauBtn);
            this.Controls.Add(this.DatPhongBtn);
            this.Name = "KhachHangGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KhachHangGUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DatPhongBtn;
        private System.Windows.Forms.Button DoiMatKhauBtn;
        private System.Windows.Forms.Button ThongTinPhongDaDatBtn;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button ThanhToanBtn;
        private System.Windows.Forms.Button button1;
    }
}