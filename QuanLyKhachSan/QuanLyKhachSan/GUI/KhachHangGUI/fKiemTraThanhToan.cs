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
    public partial class fKiemTraThanhToan : Form
    {
        public fKiemTraThanhToan()
        {
            InitializeComponent();
            pictureBox2.Visible=false;
            OkBtn.Visible=false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void fKiemTraThanhToan_Load(object sender, EventArgs e)
        {
            timer.Interval = 4500;
            timer.Start();
        }

        [Obsolete]
        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            label1.Text = null;
            label1.Text = "Hệ thống đã cập nhật hóa\nđơn của bạn";
            var maPDP = PhieuDatPhongBUS.Instance.KHLayMaPDPGanNhat(PhieuDatPhongBUS.MAKH);
            HoaDonBUS.Instance.KHCapNhatTienCoc(Convert.ToInt32(HoaDonBUS.Instance.KHCountRentalFee(maPDP) * 0.3),PhieuDatPhongBUS.MAKH);
            PhieuDatPhongBUS.Instance.KHCapNhatTinhTrangPDP("Da coc", maPDP);
            OkBtn.Visible = true;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
