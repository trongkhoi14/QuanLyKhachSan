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
        public DataTable LayDanhSach()
        {
            string query = string.Format("select p.maphong, lp.loaigiuong,lp.succhua, lp.giamotdem " +
                                        "from HOTELADMIN.phong p join HOTELADMIN.loaiphong lp " +
                                            "on p.loaiphong=lp.malp " +
                                        "where p.maphong not in (select maphong from HOTELADMIN.ct_phieudatphong)");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public void ThemPhieuDatPhong(PhieuDatPhongBUS pdp)
        {
            string query = string.Format($"INSERT INTO HOTELADMIN.phieudatphong(MAPDP, TINHTRANG, NGAYLAP, NGAYDEN, SODEMLUUTRU, SONGUOI, MANV, MAKH) " +
               $"VALUES ('{pdp.MAPDP}', 'Chua coc', TO_DATE('{pdp.NGAYLAP.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY'), " +
               $"TO_DATE('{pdp.NGAYDEN.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY'), '{pdp.SODEMLUUTRU}', '{pdp.SONGUOI}', 'NV001', '{PhieuDatPhongBUS.MAKH}')");
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        [Obsolete]
        public DataTable LayMaPDPMoiNhat()
        {
            string query = string.Format("select mapdp " +
                                        "from HOTELADMIN.phieudatphong " +
                                        "where ngaylap = ((SELECT MAX(ngaylap) FROM HOTELADMIN.phieudatphong))");
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
