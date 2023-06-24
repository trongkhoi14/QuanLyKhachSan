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
            DoiMatKhauBtn.Visible = true;
            label8.Visible = false;
            MatKhauTBox.Visible = false;
            ConfirmDoiMatKhauBtn.Visible = false;
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

            ToolTip myToolTip = new ToolTip();
            myToolTip.SetToolTip(CapNhatThongTinBtn, "Cập nhật thông tin tài khoản");
            myToolTip.SetToolTip(DoiMatKhauBtn, "Đổi mật khẩu");

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            HoVaTenTBox.ReadOnly = false;
            NgaySinhPicker.Enabled = true;
            DiaChiTBox.ReadOnly = false;
            EmailTBox.ReadOnly = false;
            SoDtTBox.ReadOnly = false;
            SoFaxTBox.ReadOnly = false;

            label8.Visible = false;
            MatKhauTBox.Visible = false;
            ConfirmDoiMatKhauBtn.Visible = false;
            DoiMatKhauBtn.Visible = true;
            MessageBox.Show("Hãy thay đổi thông tin bạn muốn chỉnh sửa", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);


            HoVaTenTBox.Focus();
            ConfirmCapNhatTTBtn.Visible = true;
            CapNhatThongTinBtn.Visible = false;

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

            CapNhatThongTinBtn.Focus();
            
            ConfirmCapNhatTTBtn.Visible = false;
            CapNhatThongTinBtn.Visible = true;
        }

        [Obsolete]
        private async void ConfirmChangeBtn_Click(object sender, EventArgs e)
        {
            var newPW = MatKhauTBox.Text;
            if (TaiKhoanBUS.Instance.KHKiemTraMatKhau(newPW) == 0)
            {
                NotiLabel.Visible = true;
                await Task.Delay(300);
                NotiLabel.Text = "Vui lòng nhập mật khẩu mới";
            }
            else
            {
                TaiKhoanBUS.Instance.KHDoiMatKhau(newPW);
                MessageBox.Show("Đổi mật khẩu thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                ConfirmDoiMatKhauBtn.Visible = false;
                DoiMatKhauBtn.Visible = true;
                //ConfirmCapNhatTTBtn.Visible = false;
                //CapNhatThongTinBtn.Visible = true;
            }
        }

        private void DoiMatKhauBtn_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            MatKhauTBox.Visible = true;
            MatKhauTBox.Focus();
            ConfirmDoiMatKhauBtn.Visible = true;
            DoiMatKhauBtn.Visible = false;
            ConfirmCapNhatTTBtn.Visible = false;
            CapNhatThongTinBtn.Visible = true;


        }
    }
}
