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
        public fDangKyDichVu()
        {
            InitializeComponent();
        }

        private void traCuuDVBtn_Click(object sender, EventArgs e)
        {
            fTraCuuDichVu f = new fTraCuuDichVu();
            f.ShowDialog();
        }
    }
}
