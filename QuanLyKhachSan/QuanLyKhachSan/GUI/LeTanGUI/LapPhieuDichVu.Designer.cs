namespace QuanLyKhachSan.GUI.LeTanGUI
{
    partial class LapPhieuDichVu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.maPhieuTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pdvHTDtgv = new System.Windows.Forms.DataGridView();
            this.capNhatBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pdvCCNDtgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdvHTDtgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdvCCNDtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maPhieuTxb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pdvHTDtgv);
            this.panel1.Controls.Add(this.capNhatBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pdvCCNDtgv);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 482);
            this.panel1.TabIndex = 92;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // maPhieuTxb
            // 
            this.maPhieuTxb.Location = new System.Drawing.Point(762, 23);
            this.maPhieuTxb.Name = "maPhieuTxb";
            this.maPhieuTxb.Size = new System.Drawing.Size(69, 22);
            this.maPhieuTxb.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(690, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã phiếu:";
            // 
            // pdvHTDtgv
            // 
            this.pdvHTDtgv.AllowUserToAddRows = false;
            this.pdvHTDtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pdvHTDtgv.Location = new System.Drawing.Point(6, 279);
            this.pdvHTDtgv.Name = "pdvHTDtgv";
            this.pdvHTDtgv.RowHeadersWidth = 51;
            this.pdvHTDtgv.RowTemplate.Height = 24;
            this.pdvHTDtgv.Size = new System.Drawing.Size(677, 200);
            this.pdvHTDtgv.TabIndex = 6;
            this.pdvHTDtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pdvHTDtgv_CellContentClick);
            // 
            // capNhatBtn
            // 
            this.capNhatBtn.Location = new System.Drawing.Point(699, 67);
            this.capNhatBtn.Name = "capNhatBtn";
            this.capNhatBtn.Size = new System.Drawing.Size(132, 30);
            this.capNhatBtn.TabIndex = 7;
            this.capNhatBtn.Text = "Cập nhật phiếu";
            this.capNhatBtn.UseVisualStyleBackColor = true;
            this.capNhatBtn.Click += new System.EventHandler(this.capNhatBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phiếu dịch vụ hiện có:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phiếu dịch vụ chưa cập nhật:";
            // 
            // pdvCCNDtgv
            // 
            this.pdvCCNDtgv.AllowUserToAddRows = false;
            this.pdvCCNDtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pdvCCNDtgv.Location = new System.Drawing.Point(6, 23);
            this.pdvCCNDtgv.Name = "pdvCCNDtgv";
            this.pdvCCNDtgv.RowHeadersWidth = 51;
            this.pdvCCNDtgv.RowTemplate.Height = 24;
            this.pdvCCNDtgv.Size = new System.Drawing.Size(677, 200);
            this.pdvCCNDtgv.TabIndex = 2;
            this.pdvCCNDtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pdvCCNDtgv_CellContentClick);
            // 
            // LapPhieuDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 520);
            this.Controls.Add(this.panel1);
            this.Name = "LapPhieuDichVu";
            this.Text = "LapPhieuDichVu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdvHTDtgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdvCCNDtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView pdvHTDtgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button capNhatBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView pdvCCNDtgv;
        private System.Windows.Forms.TextBox maPhieuTxb;
        private System.Windows.Forms.Label label1;
    }
}