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

namespace QuanLyKhachSan.GUI.KhachHangGUI
{
    public partial class fDangKyDichVu : Form
    {
        public BindingList<CTPhieuDichVuBUS> dsdvdc = new BindingList<CTPhieuDichVuBUS>();
        public fDangKyDichVu()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            string mapdp = PhieuDatPhongBUS.Instance.KHLayMaPDPGanNhat(PhieuDatPhongBUS.MAKH);
            if (mapdp == "")
            {
                this.Close();
                MessageBox.Show("Vui lòng đặt phòng trước!");
                return;
            }
            maPDPLb.Text = maPDPLb.Text + " " + mapdp;
            dvDaChonDtgv.DataSource = dsdvdc;
            dvDaDKDtgv.DataSource = CTPhieuDichVuBUS.Instance.LayCTPhieuDichVu(PhieuDichVuBUS.Instance.LayMaPhieuDichVu(mapdp));
        }

        [Obsolete]
        public void refesh()
        {
            dvDaChonDtgv.DataSource = dsdvdc;
            string mapdp = PhieuDatPhongBUS.Instance.KHLayMaPDPGanNhat(PhieuDatPhongBUS.MAKH);
            dvDaDKDtgv.DataSource = CTPhieuDichVuBUS.Instance.LayCTPhieuDichVu(PhieuDichVuBUS.Instance.LayMaPhieuDichVu(mapdp));
        }

        [Obsolete]
        private void traCuuDVBtn_Click(object sender, EventArgs e)
        {
            fTraCuuDichVu f = new fTraCuuDichVu(this);
            f.Show();
        }

        [Obsolete]
        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng ký dịch vụ thành công!\nVui lòng nhận phiếu dịch vụ tại quầy lễ tân.");
            foreach (CTPhieuDichVuBUS i in dsdvdc)
            {
                CTPhieuDichVuBUS.Instance.ThemCTPhieuDichVu(i.MaPDV, i.MaDV, i.SoLuong, i.LichSuDung, i.GhiChu, i.NhanXet);
                
            }
            while (dsdvdc.Count > 0)
            {
                dsdvdc.RemoveAt(0);
            }
            refesh();
        }
    }
}
