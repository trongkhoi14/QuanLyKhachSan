using QuanLyKhachSan.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.GUI.KhachHangGUI
{
    public partial class fTaiKhoan : Form
    {
        public fTaiKhoan()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void fTaiKhoan_Load(object sender, EventArgs e)
        {
            var info = KhachHangBUS.Instance.KHLayThongTinBanThan();
            HoVaTenTBox.Text = info.Rows[0]["TENKH"].ToString();
            NgaySinhPicker.Value = Convert.ToDateTime(info.Rows[0]["NGAYSINH"]);
            DiaChiTBox.Text= info.Rows[0]["DIACHI"].ToString();
            EmailTBox.Text = info.Rows[0]["EMAIL"].ToString();
            SoDtTBox.Text = info.Rows[0]["SODT"].ToString();
            SoFaxTBox.Text = info.Rows[0]["SOFAX"].ToString();
        }
    }
}
