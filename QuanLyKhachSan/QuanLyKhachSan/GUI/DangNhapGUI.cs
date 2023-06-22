using QuanLyKhachSan.BUS;
using QuanLyKhachSan.GUI.BuongPhongGUI;
using QuanLyKhachSan.GUI.KhachHangGUI;
using QuanLyKhachSan.GUI.LeTanGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class DangNhapGUI : Form
    {
        public DangNhapGUI()
        {
            InitializeComponent();
        }
        #region event
        [Obsolete]
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txbTenDangNhap.Text;
            string matKhau = txbMatKhau.Text;

            PhieuDatPhongBUS.MAKH = tenDangNhap;
            PDGTinhTrangPhongBUS.MANV = tenDangNhap;

            if (TaiKhoanBUS.Instance.KiemTraThongTinDangNhap(tenDangNhap, matKhau))
            {
                string vaiTro = TaiKhoanBUS.Instance.LayVaiTro(tenDangNhap, matKhau);
                switch (vaiTro)
                {
                    case "Le tan":
                        LeTanGUI lt = new LeTanGUI();
                        this.Hide();
                        lt.ShowDialog();
                        this.Show();
                        break;

                    case "Buong phong":
                        BuongPhongGUI bp = new BuongPhongGUI();
                        this.Hide();
                        bp.ShowDialog();
                        this.Show();
                        break;

                    default:
                        KhachHangGUI kh = new KhachHangGUI();
                        this.Hide();
                        kh.ShowDialog();
                        this.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập chưa chính xác!");
            }
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhapGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel)
                != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        #endregion

    }
}
