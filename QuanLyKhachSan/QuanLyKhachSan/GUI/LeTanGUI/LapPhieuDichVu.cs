using QuanLyKhachSan.BUS;
using QuanLyKhachSan.DAO;
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
    public partial class LapPhieuDichVu : Form
    {
        public LapPhieuDichVu()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            pdvCCNDtgv.DataSource = PhieuDichVuBUS.Instance.LayPhieuDichVuChuaCapNhat();
            pdvHTDtgv.DataSource = PhieuDichVuBUS.Instance.LayPhieuDichVuHienCo();
        }

        [Obsolete]
        void refresh()
        {
            pdvCCNDtgv.DataSource = PhieuDichVuBUS.Instance.LayPhieuDichVuChuaCapNhat();
            pdvHTDtgv.DataSource = PhieuDichVuBUS.Instance.LayPhieuDichVuHienCo();
        }

        [Obsolete]
        private void capNhatBtn_Click(object sender, EventArgs e)
        {
            PhieuDichVuBUS.Instance.CapNhatPDV(TaiKhoanBUS.Instance.LayTenTaiKhoanLogin(), DateTime.Now, maPhieuTxb.Text);
            refresh();
        }

        private void pdvCCNDtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            maPhieuTxb.Text = pdvCCNDtgv.CurrentRow.Cells[0].Value.ToString();
        }

        [Obsolete]
        private void pdvHTDtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ChiTietPhieuDichVu f = new ChiTietPhieuDichVu(pdvHTDtgv.CurrentRow.Cells["MAPDV"].Value.ToString());
            f.ShowDialog();
        }
    }
}
