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
            NotiLabel.Text = null;
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy thay đổi thông tin bạn muốn chỉnh sửa", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HoVaTenTBox.ReadOnly = false;
            NgaySinhPicker.Enabled = true;
            DiaChiTBox.ReadOnly = false;
            EmailTBox.ReadOnly = false;
            SoDtTBox.ReadOnly = false;
            SoFaxTBox.ReadOnly = false;

            HoVaTenTBox.Focus();
            CapNhatBtn.Visible = true;
            EditBtn.Visible = false;

        }

        [Obsolete]
        private void CapNhatBtn_Click(object sender, EventArgs e)
        {
            var newInfo = new KhachHangBUS();
            newInfo.TENKH = HoVaTenTBox.Text;
            newInfo.NGAYSINH = NgaySinhPicker.Value;
            newInfo.DIACHI = DiaChiTBox.Text;
            newInfo.EMAIL= EmailTBox.Text;
            newInfo.SODT=SoDtTBox.Text;
            newInfo.SOFAX= SoFaxTBox.Text;

            KhachHangBUS.Instance.KhCapNhatThongTin(newInfo);

            MessageBox.Show("Cập nhật thông tin thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HoVaTenTBox.ReadOnly = true;
            NgaySinhPicker.Enabled = false;
            DiaChiTBox.ReadOnly = true;
            EmailTBox.ReadOnly = true;
            SoDtTBox.ReadOnly = true;
            SoFaxTBox.ReadOnly = true;

            EditBtn.Focus();

            CapNhatBtn.Visible = false;
            EditBtn.Visible = true;
        }
    }
}
