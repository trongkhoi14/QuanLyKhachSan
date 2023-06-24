using System.Windows.Forms;

namespace QuanLyKhachSan.GUI.KhachHangGUI
{
    partial class fPhieuDatPhong
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
            this.HoanThanhBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.NgaydenTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SoNgTrongDoanTBox = new System.Windows.Forms.TextBox();
            this.SoDemLuuTruTBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.doanCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DsPhongDataGridView = new System.Windows.Forms.DataGridView();
            this.NotiLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PhuongThucThanhToanComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DsPhongDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HoanThanhBtn
            // 
            this.HoanThanhBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HoanThanhBtn.Location = new System.Drawing.Point(959, 502);
            this.HoanThanhBtn.Name = "HoanThanhBtn";
            this.HoanThanhBtn.Size = new System.Drawing.Size(107, 29);
            this.HoanThanhBtn.TabIndex = 90;
            this.HoanThanhBtn.Text = "Hoàn thành";
            this.HoanThanhBtn.UseVisualStyleBackColor = false;
            this.HoanThanhBtn.Click += new System.EventHandler(this.HoanThanhBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(436, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(270, 25);
            this.label12.TabIndex = 89;
            this.label12.Text = "Hãy chọn các phòng dưới đây";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(393, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(249, 36);
            this.label11.TabIndex = 88;
            this.label11.Text = "Phiếu đặt phòng";
            // 
            // NgaydenTimePicker
            // 
            this.NgaydenTimePicker.Location = new System.Drawing.Point(128, 111);
            this.NgaydenTimePicker.Name = "NgaydenTimePicker";
            this.NgaydenTimePicker.Size = new System.Drawing.Size(183, 22);
            this.NgaydenTimePicker.TabIndex = 87;
            // 
            // SoNgTrongDoanTBox
            // 
            this.SoNgTrongDoanTBox.Location = new System.Drawing.Point(166, 281);
            this.SoNgTrongDoanTBox.Name = "SoNgTrongDoanTBox";
            this.SoNgTrongDoanTBox.Size = new System.Drawing.Size(100, 22);
            this.SoNgTrongDoanTBox.TabIndex = 86;
            // 
            // SoDemLuuTruTBox
            // 
            this.SoDemLuuTruTBox.Location = new System.Drawing.Point(128, 145);
            this.SoDemLuuTruTBox.Name = "SoDemLuuTruTBox";
            this.SoDemLuuTruTBox.Size = new System.Drawing.Size(111, 22);
            this.SoDemLuuTruTBox.TabIndex = 85;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 16);
            this.label10.TabIndex = 79;
            this.label10.Text = "Số người trong đoàn";
            // 
            // doanCheckBox
            // 
            this.doanCheckBox.AutoSize = true;
            this.doanCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doanCheckBox.Location = new System.Drawing.Point(31, 247);
            this.doanCheckBox.Name = "doanCheckBox";
            this.doanCheckBox.Size = new System.Drawing.Size(116, 20);
            this.doanCheckBox.TabIndex = 78;
            this.doanCheckBox.Text = "Đi theo đoàn";
            this.doanCheckBox.UseVisualStyleBackColor = true;
            this.doanCheckBox.CheckedChanged += new System.EventHandler(this.doanCheckBox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 77;
            this.label7.Text = "Số đêm lưu trú";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 76;
            this.label6.Text = "Ngày đến";
            // 
            // DsPhongDataGridView
            // 
            this.DsPhongDataGridView.AllowUserToAddRows = false;
            this.DsPhongDataGridView.AllowUserToDeleteRows = false;
            this.DsPhongDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DsPhongDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DsPhongDataGridView.Location = new System.Drawing.Point(441, 111);
            this.DsPhongDataGridView.Name = "DsPhongDataGridView";
            this.DsPhongDataGridView.RowHeadersWidth = 51;
            this.DsPhongDataGridView.RowTemplate.Height = 24;
            this.DsPhongDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DsPhongDataGridView.Size = new System.Drawing.Size(625, 367);
            this.DsPhongDataGridView.TabIndex = 91;
            // 
            // NotiLabel
            // 
            this.NotiLabel.AutoSize = true;
            this.NotiLabel.ForeColor = System.Drawing.Color.Red;
            this.NotiLabel.Location = new System.Drawing.Point(438, 508);
            this.NotiLabel.Name = "NotiLabel";
            this.NotiLabel.Size = new System.Drawing.Size(31, 16);
            this.NotiLabel.TabIndex = 92;
            this.NotiLabel.Text = "Noti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 16);
            this.label1.TabIndex = 93;
            this.label1.Text = "Lưu ý: số người trong đoàn phải lớn hơn 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 94;
            this.label2.Text = "Phương thức thanh toán";
            // 
            // PhuongThucThanhToanComboBox
            // 
            this.PhuongThucThanhToanComboBox.FormattingEnabled = true;
            this.PhuongThucThanhToanComboBox.Items.AddRange(new object[] {
            "Tiền mặt",
            "Thẻ tín dụng",
            "Chuyển khoản"});
            this.PhuongThucThanhToanComboBox.Location = new System.Drawing.Point(190, 180);
            this.PhuongThucThanhToanComboBox.Name = "PhuongThucThanhToanComboBox";
            this.PhuongThucThanhToanComboBox.Size = new System.Drawing.Size(121, 24);
            this.PhuongThucThanhToanComboBox.TabIndex = 95;
            // 
            // fPhieuDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 549);
            this.Controls.Add(this.PhuongThucThanhToanComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NotiLabel);
            this.Controls.Add(this.DsPhongDataGridView);
            this.Controls.Add(this.HoanThanhBtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NgaydenTimePicker);
            this.Controls.Add(this.SoNgTrongDoanTBox);
            this.Controls.Add(this.SoDemLuuTruTBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.doanCheckBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "fPhieuDatPhong";
            this.Text = "fPhieuDatPhong";
            this.Load += new System.EventHandler(this.fPhieuDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsPhongDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button HoanThanhBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker NgaydenTimePicker;
        private System.Windows.Forms.TextBox SoNgTrongDoanTBox;
        private System.Windows.Forms.TextBox SoDemLuuTruTBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox doanCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DsPhongDataGridView;
        private System.Windows.Forms.Label NotiLabel;
        private Label label1;
        private Label label2;
        private ComboBox PhuongThucThanhToanComboBox;
    }
}