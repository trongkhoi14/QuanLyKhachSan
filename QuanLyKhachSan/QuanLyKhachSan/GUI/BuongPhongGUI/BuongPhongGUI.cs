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

namespace QuanLyKhachSan.GUI.BuongPhongGUI
{
    public partial class BuongPhongGUI : Form
    {
        public BuongPhongGUI()
        {
            InitializeComponent();
        }

        private void HoanThanhBtn_Click(object sender, EventArgs e)
        {
            PhieuDanhGiaTinhTrangPhongBUS pdgttp = new PhieuDanhGiaTinhTrangPhongBUS();

            pdgttp.MAPDG = "";
        }
    }
}
