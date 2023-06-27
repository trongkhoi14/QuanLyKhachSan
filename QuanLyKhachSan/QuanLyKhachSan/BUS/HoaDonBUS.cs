using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class HoaDonBUS
    {
        private static HoaDonBUS instance;
        public static HoaDonBUS Instance
        {
            get { if (instance == null) instance = new HoaDonBUS(); return instance; }
            set => instance = value;
        }
        private HoaDonBUS() { }
        public DataTable TongTienThanhToan(string MaPhong, string PhuThu)
        {
            return HoaDonDAO.Instance.TongTienThanhToan(MaPhong, PhuThu);
        }
        public DataTable TienHoanLai(string MaPhong, string TienNhan)
        {
            return HoaDonDAO.Instance.TienHoanLai(MaPhong, TienNhan);
        }
    }
}
