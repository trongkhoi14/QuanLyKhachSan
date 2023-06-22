using System.Windows.Forms;

namespace QuanLyKhachSan.GUI.KhachHangGUI
{
    partial class fThongTinDatPhong
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
            this.ThongTinDatPhongDataGridView = new System.Windows.Forms.DataGridView();
            this.LoaiPhongDaDatDataGridView = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinDatPhongDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoaiPhongDaDatDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ThongTinDatPhongDataGridView
            // 
            this.ThongTinDatPhongDataGridView.AllowUserToAddRows = false;
            this.ThongTinDatPhongDataGridView.AllowUserToDeleteRows = false;
            this.ThongTinDatPhongDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ThongTinDatPhongDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.ThongTinDatPhongDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ThongTinDatPhongDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ThongTinDatPhongDataGridView.Location = new System.Drawing.Point(12, 94);
            this.ThongTinDatPhongDataGridView.MultiSelect = false;
            this.ThongTinDatPhongDataGridView.Name = "ThongTinDatPhongDataGridView";
            this.ThongTinDatPhongDataGridView.ReadOnly = true;
            this.ThongTinDatPhongDataGridView.RowHeadersWidth = 51;
            this.ThongTinDatPhongDataGridView.RowTemplate.Height = 24;
            this.ThongTinDatPhongDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ThongTinDatPhongDataGridView.Size = new System.Drawing.Size(904, 200);
            this.ThongTinDatPhongDataGridView.TabIndex = 1;
            // 
            // LoaiPhongDaDatDataGridView
            // 
            this.LoaiPhongDaDatDataGridView.AllowUserToAddRows = false;
            this.LoaiPhongDaDatDataGridView.AllowUserToDeleteRows = false;
            this.LoaiPhongDaDatDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.LoaiPhongDaDatDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.LoaiPhongDaDatDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.LoaiPhongDaDatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoaiPhongDaDatDataGridView.Location = new System.Drawing.Point(12, 313);
            this.LoaiPhongDaDatDataGridView.MultiSelect = false;
            this.LoaiPhongDaDatDataGridView.Name = "LoaiPhongDaDatDataGridView";
            this.LoaiPhongDaDatDataGridView.ReadOnly = true;
            this.LoaiPhongDaDatDataGridView.RowHeadersWidth = 51;
            this.LoaiPhongDaDatDataGridView.RowTemplate.Height = 24;
            this.LoaiPhongDaDatDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LoaiPhongDaDatDataGridView.Size = new System.Drawing.Size(1034, 200);
            this.LoaiPhongDaDatDataGridView.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(365, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(346, 36);
            this.label11.TabIndex = 89;
            this.label11.Text = "Thông tin phòng đã đặt";
            // 
            // fThongTinDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 525);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LoaiPhongDaDatDataGridView);
            this.Controls.Add(this.ThongTinDatPhongDataGridView);
            this.Name = "fThongTinDatPhong";
            this.Text = "fThongTinDatPhong";
            this.Load += new System.EventHandler(this.fThongTinDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinDatPhongDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoaiPhongDaDatDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ThongTinDatPhongDataGridView;
        private System.Windows.Forms.DataGridView LoaiPhongDaDatDataGridView;
        private Label label11;
    }
}