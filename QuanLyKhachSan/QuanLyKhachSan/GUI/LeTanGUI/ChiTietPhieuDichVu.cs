using QuanLyKhachSan.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.GUI.LeTanGUI
{
    public partial class ChiTietPhieuDichVu : Form
    {
        string mapdv;

        [Obsolete]
        public ChiTietPhieuDichVu(string MaPDV)
        {
            InitializeComponent();
            dataGridView1.DataSource = CTPhieuDichVuBUS.Instance.LayCTPhieuDichVu(MaPDV);
            mapdv = MaPDV;
        }

        [Obsolete]
        private void tinhPhiBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phí dịch vụ tạm thời là: " + (CTPhieuDichVuBUS.Instance.TinhPhiDVTamThoi(mapdv)*0.1).ToString());
        }
    }
}
