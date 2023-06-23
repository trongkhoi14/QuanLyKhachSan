using System.Windows.Forms;

namespace QuanLyKhachSan.GUI.KhachHangGUI
{
    partial class fTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTaiKhoan));
            this.HoVaTenTBox = new System.Windows.Forms.TextBox();
            this.DiaChiTBox = new System.Windows.Forms.TextBox();
            this.NgaySinhPicker = new System.Windows.Forms.DateTimePicker();
            this.EmailTBox = new System.Windows.Forms.TextBox();
            this.SoFaxTBox = new System.Windows.Forms.TextBox();
            this.SoDtTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.NotiLabel = new System.Windows.Forms.Label();
            this.CapNhatBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HoVaTenTBox
            // 
            this.HoVaTenTBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoVaTenTBox.Location = new System.Drawing.Point(134, 53);
            this.HoVaTenTBox.Margin = new System.Windows.Forms.Padding(2);
            this.HoVaTenTBox.Multiline = true;
            this.HoVaTenTBox.Name = "HoVaTenTBox";
            this.HoVaTenTBox.ReadOnly = true;
            this.HoVaTenTBox.Size = new System.Drawing.Size(199, 26);
            this.HoVaTenTBox.TabIndex = 0;
            // 
            // DiaChiTBox
            // 
            this.DiaChiTBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChiTBox.Location = new System.Drawing.Point(134, 145);
            this.DiaChiTBox.Margin = new System.Windows.Forms.Padding(2);
            this.DiaChiTBox.Multiline = true;
            this.DiaChiTBox.Name = "DiaChiTBox";
            this.DiaChiTBox.ReadOnly = true;
            this.DiaChiTBox.Size = new System.Drawing.Size(274, 71);
            this.DiaChiTBox.TabIndex = 1;
            // 
            // NgaySinhPicker
            // 
            this.NgaySinhPicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinhPicker.Enabled = false;
            this.NgaySinhPicker.Location = new System.Drawing.Point(134, 101);
            this.NgaySinhPicker.Margin = new System.Windows.Forms.Padding(2);
            this.NgaySinhPicker.Name = "NgaySinhPicker";
            this.NgaySinhPicker.Size = new System.Drawing.Size(154, 22);
            this.NgaySinhPicker.TabIndex = 2;
            // 
            // EmailTBox
            // 
            this.EmailTBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTBox.Location = new System.Drawing.Point(134, 245);
            this.EmailTBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailTBox.Multiline = true;
            this.EmailTBox.Name = "EmailTBox";
            this.EmailTBox.ReadOnly = true;
            this.EmailTBox.Size = new System.Drawing.Size(274, 30);
            this.EmailTBox.TabIndex = 3;
            // 
            // SoFaxTBox
            // 
            this.SoFaxTBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoFaxTBox.Location = new System.Drawing.Point(134, 354);
            this.SoFaxTBox.Margin = new System.Windows.Forms.Padding(2);
            this.SoFaxTBox.Multiline = true;
            this.SoFaxTBox.Name = "SoFaxTBox";
            this.SoFaxTBox.ReadOnly = true;
            this.SoFaxTBox.Size = new System.Drawing.Size(199, 26);
            this.SoFaxTBox.TabIndex = 4;
            // 
            // SoDtTBox
            // 
            this.SoDtTBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoDtTBox.Location = new System.Drawing.Point(134, 300);
            this.SoDtTBox.Margin = new System.Windows.Forms.Padding(2);
            this.SoDtTBox.Multiline = true;
            this.SoDtTBox.Name = "SoDtTBox";
            this.SoDtTBox.ReadOnly = true;
            this.SoDtTBox.Size = new System.Drawing.Size(199, 28);
            this.SoDtTBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 357);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số fax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Họ và tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 173);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Địa chỉ";
            // 
            // EditBtn
            // 
            this.EditBtn.Image = ((System.Drawing.Image)(resources.GetObject("EditBtn.Image")));
            this.EditBtn.Location = new System.Drawing.Point(537, 407);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(105, 41);
            this.EditBtn.TabIndex = 12;
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // NotiLabel
            // 
            this.NotiLabel.AutoSize = true;
            this.NotiLabel.ForeColor = System.Drawing.Color.Red;
            this.NotiLabel.Location = new System.Drawing.Point(131, 419);
            this.NotiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NotiLabel.Name = "NotiLabel";
            this.NotiLabel.Size = new System.Drawing.Size(31, 16);
            this.NotiLabel.TabIndex = 13;
            this.NotiLabel.Text = "Noti";
            // 
            // CapNhatBtn
            // 
            this.CapNhatBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CapNhatBtn.Location = new System.Drawing.Point(537, 407);
            this.CapNhatBtn.Name = "CapNhatBtn";
            this.CapNhatBtn.Size = new System.Drawing.Size(105, 41);
            this.CapNhatBtn.TabIndex = 14;
            this.CapNhatBtn.Text = "Cập nhật";
            this.CapNhatBtn.UseVisualStyleBackColor = false;
            this.CapNhatBtn.Visible = false;
            this.CapNhatBtn.Click += new System.EventHandler(this.CapNhatBtn_Click);
            // 
            // label7
            // 
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(485, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 155);
            this.label7.TabIndex = 15;
            // 
            // fTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 522);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CapNhatBtn);
            this.Controls.Add(this.NotiLabel);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SoDtTBox);
            this.Controls.Add(this.SoFaxTBox);
            this.Controls.Add(this.EmailTBox);
            this.Controls.Add(this.NgaySinhPicker);
            this.Controls.Add(this.DiaChiTBox);
            this.Controls.Add(this.HoVaTenTBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fTaiKhoan";
            this.Text = "Thông tin tài khoản";
            this.Load += new System.EventHandler(this.fTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HoVaTenTBox;
        private System.Windows.Forms.TextBox DiaChiTBox;
        private System.Windows.Forms.DateTimePicker NgaySinhPicker;
        private System.Windows.Forms.TextBox EmailTBox;
        private System.Windows.Forms.TextBox SoFaxTBox;
        private System.Windows.Forms.TextBox SoDtTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Button EditBtn;
        private Label NotiLabel;
        private Button CapNhatBtn;
        private Label label7;
    }
}