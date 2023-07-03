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

namespace QuanLyKhachSan.GUI.LeTanGUI
{
    public partial class CheckOutGUI : Form
    {
        public CheckOutGUI()
        {
            InitializeComponent();
        }
        void LoadPhongTraCuuCK()
        {
            string MaPhong = txtMaPhongCK.Text;
            dtgvTraCuuPhongCK.DataSource = PhongBUS.Instance.PhongTraCuuCK(MaPhong);
        }
        private void btnTraCuuPhongCK_Click(object sender, EventArgs e)
        {
            string MaPhong = txtMaPhongCK.Text;
            if (MaPhong == "")
            {
                MessageBox.Show("Chưa điền mã phiếu đặt phòng!");
            }
            else
            {
                if (PhongBUS.Instance.PhongTraCuuCK(MaPhong).Rows.Count != 0)
                {
                    LoadPhongTraCuuCK();
                }
                else
                {
                    MessageBox.Show("Phiếu đặt phòng không tồn tại!");
                }
            }
        }
        void LoadPhongCapNhatCK()
        {
            string MaPhong = txtMaPhongCK.Text;
            string TrangThai = cbTrangThaiCK.SelectedItem.ToString();
            dtgvCapNhatPhongCK.DataSource = PhongBUS.Instance.PhongCapNhatCK(MaPhong, TrangThai);
        }
        private void BtnCapNhatPhongCK_Click(object sender, EventArgs e)
        {
            string MaPhong = txtMaPhongCK.Text;
            string TrangThai = "";
            if (cbTrangThaiCK.SelectedItem != null)
            {
                TrangThai = cbTrangThaiCK.SelectedItem.ToString();
            }
            if (TrangThai == "" || MaPhong == "")
            {
                MessageBox.Show("Chưa điền đủ thông tin!");
            }
            else
            {
                if (PhongBUS.Instance.PhongCapNhatCK(MaPhong, TrangThai).Rows.Count != 0)
                {
                    LoadPhongCapNhatCK();
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Phòng không tồn tại!");
                }
            }
        }
        void LoadTongTienThanhToan()
        {
            string MaPhong = txtMaPDPCK.Text;
            string PhuThu = txtPhuThuCK.Text;
            dtgvTongTienThanhToanCK.DataSource = HoaDonBUS.Instance.TongTienThanhToan(MaPhong, PhuThu);
        }
        private void btnCapNhatHoaDonCK_Click(object sender, EventArgs e)
        {
            string MaPhong = txtMaPDPCK.Text;
            string PhuThu = txtPhuThuCK.Text;
            if (MaPhong == "" || PhuThu=="")
            {
                MessageBox.Show("Chưa điền đủ thông tin!");
            }
            else
            {
                if (HoaDonBUS.Instance.TongTienThanhToan(MaPhong, PhuThu).Rows.Count != 0)
                {
                    LoadTongTienThanhToan();
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Phiếu đặt phòng không tồn tại!");
                }
            }
        }
        void LoadTienHoanLai()
        {
            string MaPhong = txtMaPDPCK.Text;
            string TienNhan = txtTienNhanCK.Text;
            dtgvTienHoanLaiCK.DataSource = HoaDonBUS.Instance.TienHoanLai(MaPhong, TienNhan);
        }
        private void btnTraCuuHoaDonCK_Click(object sender, EventArgs e)
        {
            string MaPhong = txtMaPDPCK.Text;
            string TienNhan = txtTienNhanCK.Text;
            if (MaPhong == "" || TienNhan == "")
            {
                MessageBox.Show("Chưa điền đủ thông tin!");
            }
            else
            {
                if (HoaDonBUS.Instance.TienHoanLai(MaPhong, TienNhan).Rows.Count != 0)
                {
                    LoadTienHoanLai();
                    MessageBox.Show("Thanh toán thành công!");
                }
                else
                {
                    MessageBox.Show("Phiếu đặt phòng không tồn tại!");
                }
            }
        }
    }
}
