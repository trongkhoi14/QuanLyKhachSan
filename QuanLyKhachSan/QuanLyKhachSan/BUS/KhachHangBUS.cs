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
        public string MAKH { get; set; }
        public string TENKH { get; set; }
        public DateTime NGAYSINH { get; set; }
        public string DIACHI { get; set; }
        public string EMAIL { get; set; }
        public string SODT { get; set; }

        public string SOFAX { get; set; }

        public string TINHTRANG { get; set; }

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
            if (kh.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }

        [Obsolete]
        public bool LTThemKhachHang(string tenkh, string ngaysinh, string diachi, string email, string sodt, string sofax)
        {
            //Lấy ds khách hàng
            DataTable dsKhachHang = KhachHangDAO.Instance.LTLayDanhSach();
            //Tạo mã khách hàng
            int soKH = dsKhachHang.Rows.Count;
            soKH = soKH + 1;
            string maKH = $"KH00{soKH}";
            try
            {
                int r = KhachHangDAO.Instance.LTThemKhachHang(maKH, tenkh, ngaysinh, diachi, email, sodt, sofax);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        [Obsolete]
        public bool LTCapNhatKhachHang(string makh, string email, string sodt, string sofax)
        {
            try
            {
                int r = KhachHangDAO.Instance.LTCapNhatKhachHang(makh, email, sodt, sofax);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public DataTable KHLayThongTinBanThan(string maKH)
        {
            return KhachHangDAO.Instance.KHLayThongTinCaNhan(maKH);
        }

        [Obsolete]
        public int KHKiemTraThongTinCapNhat(KhachHangBUS newInfo)
        {
            var oldInfo = KhachHangBUS.Instance.KHLayThongTinBanThan(PhieuDatPhongBUS.MAKH);
            if (oldInfo.Rows[0]["TENKH"]==newInfo.TENKH &&
                Convert.ToDateTime(oldInfo.Rows[0]["NGAYSINH"])== newInfo.NGAYSINH&&
                oldInfo.Rows[0]["DIACHI"]== newInfo.DIACHI&&
                oldInfo.Rows[0]["EMAIL"]==newInfo.EMAIL&&
                oldInfo.Rows[0]["SODT"]== newInfo.SODT&&
                oldInfo.Rows[0]["SOFAX"]== newInfo.SOFAX)
            {
                return 2;
            }
            return 0;
        }

        [Obsolete]
        public void KhCapNhatThongTin(KhachHangBUS newInfo, string maKH)
        {
            KhachHangDAO.Instance.KHCapNhatThongTinCaNhan(newInfo, maKH);
        }
    }
}
