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
    public partial class KhachHangGUI : Form
    {
        public KhachHangGUI()
        {
            InitializeComponent();
        }
        private void active_form(Form f)
        {
            panel.Controls.Clear();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Height = 500;
            f.Width = 950;
            f.Dock = DockStyle.Fill;
            panel.Controls.Add(f);
            panel.Tag = f;
            f.BringToFront();
            f.Show();
        }
        private void DatPhongBtn_Click(object sender, EventArgs e)
        {
            var pdp = new fPhieuDatPhong();
            active_form(pdp);
        }

        private void DoiMatKhauBtn_Click(object sender, EventArgs e)
        {

        }

        private void ThongTinPhongDaDatBtn_Click(object sender, EventArgs e)
        {
            var pdp = new fThongTinDatPhong();
            active_form(pdp);
        }

        private void dangKyDVBtn_Click(object sender, EventArgs e)
        {
            var dkdv = new fDangKyDichVu();
            active_form(dkdv);  
        }

        private void dangKyTourBtn_Click(object sender, EventArgs e)
        {
            var dkt = new fDangKyTour();
            active_form(dkt);
        }
    }
}
