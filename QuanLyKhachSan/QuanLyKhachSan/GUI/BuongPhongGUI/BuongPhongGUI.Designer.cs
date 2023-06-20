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
            this.HoanThanhBtn = new System.Windows.Forms.Button();
            this.MoTaTBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ManvTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NgayLapTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.MaPhongTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(190, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(385, 36);
            this.label11.TabIndex = 89;
            this.label11.Text = "Đánh giá tình trạng phòng";
            // 
            // HoanThanhBtn
            // 
            this.HoanThanhBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HoanThanhBtn.Location = new System.Drawing.Point(718, 440);
            this.HoanThanhBtn.Name = "HoanThanhBtn";
            this.HoanThanhBtn.Size = new System.Drawing.Size(94, 30);
            this.HoanThanhBtn.TabIndex = 99;
            this.HoanThanhBtn.Text = "Hoàn thành";
            this.HoanThanhBtn.UseVisualStyleBackColor = false;
            // 
            // MoTaTBox
            // 
            this.MoTaTBox.Location = new System.Drawing.Point(83, 201);
            this.MoTaTBox.Multiline = true;
            this.MoTaTBox.Name = "MoTaTBox";
            this.MoTaTBox.Size = new System.Drawing.Size(467, 222);
            this.MoTaTBox.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 97;
            this.label4.Text = "Mô tả";
            // 
            // ManvTBox
            // 
            this.ManvTBox.Location = new System.Drawing.Point(184, 155);
            this.ManvTBox.Name = "ManvTBox";
            this.ManvTBox.Size = new System.Drawing.Size(163, 22);
            this.ManvTBox.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 95;
            this.label3.Text = "Mã nhân viên lập phiếu";
            // 
            // NgayLapTimePicker
            // 
            this.NgayLapTimePicker.Location = new System.Drawing.Point(184, 114);
            this.NgayLapTimePicker.Name = "NgayLapTimePicker";
            this.NgayLapTimePicker.Size = new System.Drawing.Size(163, 22);
            this.NgayLapTimePicker.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 93;
            this.label2.Text = "Ngày lập";
            // 
            // MaPhongTBox
            // 
            this.MaPhongTBox.Location = new System.Drawing.Point(184, 73);
            this.MaPhongTBox.Name = "MaPhongTBox";
            this.MaPhongTBox.Size = new System.Drawing.Size(163, 22);
            this.MaPhongTBox.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 91;
            this.label1.Text = "Mã phòng";
            // 
            // BuongPhongGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 482);
            this.Controls.Add(this.HoanThanhBtn);
            this.Controls.Add(this.MoTaTBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ManvTBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NgayLapTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaPhongTBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Name = "BuongPhongGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuongPhongGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button HoanThanhBtn;
        private System.Windows.Forms.TextBox MoTaTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ManvTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker NgayLapTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaPhongTBox;
        private System.Windows.Forms.Label label1;
    }
}