using QuanLyKhachSan.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class PhieuDatPhongDAO
    {
        private static PhieuDatPhongDAO instance;
        public static PhieuDatPhongDAO Instance
        {
            get { if (instance == null) instance = new PhieuDatPhongDAO(); return instance; }
            set => instance = value;
        }
        private PhieuDatPhongDAO() { }

        [Obsolete]
        public DataTable LTLayDanhSach()
        {
            string query = string.Format("SELECT P.MAPDP, K.TENKH, K.NGAYSINH, K.DIACHI, K.EMAIL, K.SODT, K.SOFAX, P.NGAYDEN, P.SODEMLUUTRU, P.SONGUOI, P.TINHTRANG AS THANHTOAN " +
                                         "FROM HOTELADMIN.PHIEUDATPHONG P " +
                                         "JOIN HOTELADMIN.KHACHHANG K ON K.MAKH = P.MAKH");
        public DataTable KHLayDanhSach()
        {
            string query = string.Format("select p.maphong, lp.loaigiuong,lp.succhua, lp.giamotdem " +
                                        "from HOTELADMIN.phong p join HOTELADMIN.loaiphong lp " +
                                            "on p.loaiphong=lp.malp " +
                                        "where p.maphong not in (select maphong from HOTELADMIN.ct_phieudatphong)");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public void KHThemPhieuDatPhong(PhieuDatPhongBUS pdp)
        {
            string query = string.Format($"INSERT INTO HOTELADMIN.phieudatphong(MAPDP, TINHTRANG, NGAYLAP, NGAYDEN, SODEMLUUTRU, SONGUOI, MANV, MAKH) " +
               $"VALUES ('{pdp.MAPDP}', 'Chua coc', TO_DATE('{pdp.NGAYLAP.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY'), " +
               $"TO_DATE('{pdp.NGAYDEN.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY'), '{pdp.SODEMLUUTRU}', '{pdp.SONGUOI}', 'NV001', '{PhieuDatPhongBUS.MAKH}')");
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        [Obsolete]
        public DataTable KHLayMaPDPMoiNhat()
        {
            string query = string.Format("select count(*) from HOTELADMIN.phieudatphong");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        [Obsolete]
        public DataTable KHRetrieveBookedPDP()
        {
            string query = string.Format(
            $"select p.mapdp, p.tinhtrang, p.ngaylap, p.ngayden, p.sodemluutru, p.songuoi, ct.maphong " +
            $"from HOTELADMIN.phieudatphong p join HOTELADMIN.ct_phieudatphong ct " +
                $"on p.mapdp = ct.mapdp " +
            $"where makh='{PhieuDatPhongBUS.MAKH}' " +
            $"order by p.mapdp");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        [Obsolete]
        public DataTable KhRetrieveRoomType()
        {
            string query = string.Format(
                "select pdp.mapdp, lp.hangphong, lp.loaigiuong, lp.mota, lp.succhua, lp.giamotdem " +
                "from HOTELADMIN.phieudatphong pdp " +
                "join HOTELADMIN.ct_phieudatphong ct " +
                  "on pdp.mapdp = ct.mapdp " +
                "join HOTELADMIN.phong p " +
                  "on ct.maphong=p.maphong " +
                "join HOTELADMIN.loaiphong lp " +
                  "on p.loaiphong=lp.malp " +
                $"where pdp.makh='{PhieuDatPhongBUS.MAKH}' " +
                $" order by pdp.mapdp");
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
