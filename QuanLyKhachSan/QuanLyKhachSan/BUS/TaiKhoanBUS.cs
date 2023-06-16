using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;
        public static TaiKhoanBUS Instance
        {
            get { if (instance == null) instance = new TaiKhoanBUS(); return instance; }
            set => instance = value;
        }
        private TaiKhoanBUS() { }

        #region method
        public bool KiemTraThongTinDangNhap(string TenDangNhap, string MatKhau)
        {

            return false;
        }
        public string LayVaiTro(string TenDangNhap, string MatKhau)
        {

            return "";
        }
        #endregion
    }
}
