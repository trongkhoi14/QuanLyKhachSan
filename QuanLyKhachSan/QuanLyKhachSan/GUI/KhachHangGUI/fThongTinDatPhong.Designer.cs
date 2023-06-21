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
            this.ThongTinDatPhongDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ThongTinDatPhongDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ThongTinDatPhongDataGridView.Location = new System.Drawing.Point(12, 27);
            this.ThongTinDatPhongDataGridView.MultiSelect = false;
            this.ThongTinDatPhongDataGridView.Name = "ThongTinDatPhongDataGridView";
            this.ThongTinDatPhongDataGridView.ReadOnly = true;
            this.ThongTinDatPhongDataGridView.RowHeadersWidth = 51;
            this.ThongTinDatPhongDataGridView.RowTemplate.Height = 24;
            this.ThongTinDatPhongDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ThongTinDatPhongDataGridView.Size = new System.Drawing.Size(911, 200);
            this.ThongTinDatPhongDataGridView.TabIndex = 1;
            // 
            // LoaiPhongDaDatDataGridView
            // 
            this.LoaiPhongDaDatDataGridView.AllowUserToAddRows = false;
            this.LoaiPhongDaDatDataGridView.AllowUserToDeleteRows = false;
            this.LoaiPhongDaDatDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.LoaiPhongDaDatDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.LoaiPhongDaDatDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.LoaiPhongDaDatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoaiPhongDaDatDataGridView.Location = new System.Drawing.Point(12, 250);
            this.LoaiPhongDaDatDataGridView.MultiSelect = false;
            this.LoaiPhongDaDatDataGridView.Name = "LoaiPhongDaDatDataGridView";
            this.LoaiPhongDaDatDataGridView.ReadOnly = true;
            this.LoaiPhongDaDatDataGridView.RowHeadersWidth = 51;
            this.LoaiPhongDaDatDataGridView.RowTemplate.Height = 24;
            this.LoaiPhongDaDatDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LoaiPhongDaDatDataGridView.Size = new System.Drawing.Size(1012, 200);
            this.LoaiPhongDaDatDataGridView.TabIndex = 2;
            // 
            // fThongTinDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 476);
            this.Controls.Add(this.LoaiPhongDaDatDataGridView);
            this.Controls.Add(this.ThongTinDatPhongDataGridView);
            this.Name = "fThongTinDatPhong";
            this.Text = "fThongTinDatPhong";
            this.Load += new System.EventHandler(this.fThongTinDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinDatPhongDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoaiPhongDaDatDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ThongTinDatPhongDataGridView;
        private System.Windows.Forms.DataGridView LoaiPhongDaDatDataGridView;
    }
}