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
        public fDangKyTour()
        {
            InitializeComponent();
        }

        private void traCuuTourBtn_Click(object sender, EventArgs e)
        {
            fTraCuuTour f = new fTraCuuTour();
            f.ShowDialog();
        }
    }
}
