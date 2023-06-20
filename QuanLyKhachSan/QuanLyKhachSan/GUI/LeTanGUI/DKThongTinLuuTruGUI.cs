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
    public partial class DKThongTinLuuTruGUI : Form
    {
        private string maPDP;
        public string MaPDP
        {
            get { return maPDP; }
            set { maPDP = value; }
        }

        public DKThongTinLuuTruGUI(string mapdp)
        {
            InitializeComponent();
            this.maPDP = mapdp;
            txbHoTen.Text = this.maPDP;
        }

    }
}
