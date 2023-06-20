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
            // KhachHangGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 478);
            this.Controls.Add(this.DatPhongBtn);
            this.Name = "KhachHangGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KhachHangGUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DatPhongBtn;
    }
}