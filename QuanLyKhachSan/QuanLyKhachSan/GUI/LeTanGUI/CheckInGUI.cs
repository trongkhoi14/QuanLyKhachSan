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
    public partial class CheckInGUI : Form
    {
        public CheckInGUI()
        {
            InitializeComponent();
        }

        private void btnDangKyThongTinLuuTru_Click(object sender, EventArgs e)
        {
            DKThongTinLuuTruGUI dk = new DKThongTinLuuTruGUI();
            this.Hide();
            dk.ShowDialog();
            this.Show();
        }
    }
}
