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
    public partial class fDangKyTour : Form
    {
        public TourDuLichBUS tour = new TourDuLichBUS("", "", "", "", 0, "");

        
        public fDangKyTour()
        {
            InitializeComponent();
        }

        private void traCuuTourBtn_Click(object sender, EventArgs e)
        {
            fTraCuuTour f = new fTraCuuTour(this);
            f.ShowDialog();
        }

        [Obsolete]
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            maKHLb.Text = maKHLb.Text + " " + PhieuDatPhongBUS.MAKH;
            soNguoiTxb.Text = "1";
            dvDuaDonCbb.Text = "Không";
            HienThiTourDangChon();
            HienThiPDKTour(PhieuDatPhongBUS.MAKH);
        }

        [Obsolete]
        private void HienThiPDKTour (string MaKh)
        {
            tourDaChonDtgv.DataSource = PDKTourBUS.Instance.LayPDKTour(MaKh);
        }

        private void HienThiTourDangChon()
        {
            tenTourLb.Text = tenTourLb.Text + " " + tour.Ten;
            diaDiemLb.Text = diaDiemLb.Text + " " + tour.DiaDiem;
            moTaLb.Text = moTaLb.Text + " " + tour.MoTa;
            giaLb.Text = "Giá: " + tour.Gia.ToString();
            maDTLb.Text = maDTLb.Text + " " + tour.MaDT;
            maTourLb.Text = maTourLb.Text + " " + tour.MaTDL;
        }

        [Obsolete]
        public void refesh()
        {
            HienThiPDKTour(PhieuDatPhongBUS.MAKH);
            HienThiTourDangChon();
        }

        [Obsolete]
        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            PDKTourBUS p = new PDKTourBUS();
            p.MaPDKT = "PDK0" + (PDKTourBUS.Instance.LaySoLuongPDK() + 1).ToString();
            p.TGKhoiHanh = tgKhoiHanhDtpk.Value;
            p.SoNguoiTG = Convert.ToInt32(soNguoiTxb.Text);
            p.DVDuaDon = dvDuaDonCbb.Text;
            p.MaTDL = tour.MaTDL;
            p.YCDB = yeuCauDBTxb.Text;
            p.MaKH = PhieuDatPhongBUS.MAKH;

            PDKTourBUS.Instance.ThemPDK(p);

            tenTourLb.Text = "Tên tour: ";
            diaDiemLb.Text = "Địa điểm: ";
            moTaLb.Text = "Mô tả: ";
            giaLb.Text = "Giá: ";
            maDTLb.Text = "Mã đối tác: ";
            maTourLb.Text = "Mã tour du lịch: ";

            tour = new TourDuLichBUS("", "", "", "", 0, "");

            refesh();

            MessageBox.Show("Đăng ký tour du lịch thành công!");
        }
    }
}
