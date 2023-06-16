using QuanLyKhachSan.BUS;
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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txbTenDangNhap.Text;
            string matKhau = txbMatKhau.Text;
            if(TaiKhoanBUS.Instance.KiemTraThongTinDangNhap(tenDangNhap, matKhau))
            {
                string vaiTro = TaiKhoanBUS.Instance.LayVaiTro(tenDangNhap, matKhau);
                switch (vaiTro)
                {
                    case "Letan":
                        LeTanGUI LeTanGUI = new LeTanGUI();
                        this.Hide();
                        LeTanGUI.ShowDialog();
                        this.Show();
                        break;
                    case "KhachHang":
                        
                        break;
                    case "BuongPhong":
                        
                        break;
                    default:

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
    
    }
}
