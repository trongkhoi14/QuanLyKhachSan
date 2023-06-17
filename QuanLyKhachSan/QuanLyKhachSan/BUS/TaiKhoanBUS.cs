using QuanLyKhachSan.DAO;
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
       
        public bool KiemTraThongTinDangNhap(string tenDangNhap, string matKhau)
        {
            if(tenDangNhap == "" || matKhau == "")
            {
                return false;
            }
            try
            {
                string connectionSTR = @"DATA SOURCE=localhost:1521/xe; USER ID=" + tenDangNhap + ";PASSWORD=" + matKhau;

                // Thiết lập lại chuỗi kết nối
                DataProvider.Instance.SetConnectionString(connectionSTR);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
        public string LayVaiTro(string TenDangNhap, string MatKhau)
        {

            return "LeTan";
        }
        #endregion
    }
}
