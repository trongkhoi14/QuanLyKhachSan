using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class KhachHangBUS
    {
        private static KhachHangBUS instance;
        public static KhachHangBUS Instance
        {
            get { if (instance == null) instance = new KhachHangBUS(); return instance; }
            set => instance = value;
        }
        private KhachHangBUS() { }

        [Obsolete]
        public DataTable LTLayDanhSachKhachHang()
        {
            return KhachHangDAO.Instance.LTLayDanhSach();
        }
        [Obsolete]
        public bool KiemTraTonTai(string tenkh, string ngaysinh, string diachi)
        {
            DataTable kh = KhachHangDAO.Instance.LTLayKhachHang(tenkh, ngaysinh, diachi);
            if(kh.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }
    }
}
