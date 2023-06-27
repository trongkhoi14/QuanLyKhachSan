using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;
        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return instance; }
            set => instance = value;
        }
        private HoaDonDAO() { }
        public DataTable TongTienThanhToan(string MaPhong, string PhuThu)
        {
           try
            {
                string query = string.Format("UPDATE HOTELADMIN.HOADON SET PHUTHU = '{0}' WHERE MAPDP = '{1}'", PhuThu, MaPhong);
                DataProvider.Instance.ExecuteNonQuery(query);
                string query1 = string.Format("SELECT PDP.MAPDP, (SELECT SUM(PDP2.SODEMLUUTRU * LP.GIAMOTDEM) AS TIENPHONG FROM  HOTELADMIN.PHIEUDATPHONG PDP2 JOIN HOTELADMIN.CT_PHIEUDATPHONG CTPDP ON CTPDP.MAPDP = PDP2.MAPDP JOIN HOTELADMIN.PHONG P ON P.MAPHONG = CTPDP.MAPHONG JOIN HOTELADMIN.LOAIPHONG LP ON LP.MALP = P.LOAIPHONG WHERE PDP2.MAPDP = '{0}') + (CTPDV.SOLUONG * DV.GIADV) + HD.PHUTHU - HD.TIENCOC AS TONGTIEN FROM HOTELADMIN.PHIEUDATPHONG PDP JOIN HOTELADMIN.PHIEUDICHVU PDV ON PDV.MAPDP = PDP.MAPDP JOIN HOTELADMIN.CT_PHIEUDICHVU CTPDV ON PDV.MAPDV = CTPDV.MAPDV JOIN HOTELADMIN.DICHVU DV ON CTPDV.MADV = DV.MADV JOIN HOTELADMIN.HOADON HD ON PDP.MAPDP = HD.MAPDP WHERE PDP.MAPDP = '{0}'", MaPhong);
                return DataProvider.Instance.ExecuteQuery(query1);
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }
        public DataTable TienHoanLai(string MaPhong, string TienNhan)
        {
            try
            {
                string query = string.Format("UPDATE HOTELADMIN.HOADON SET TIENNHAN = '{0}' WHERE MAPDP = '{1}'", TienNhan, MaPhong);
                DataProvider.Instance.ExecuteNonQuery(query);
                string query1 = string.Format("SELECT PDP.MAPDP, HD.TIENNHAN - ((SELECT SUM(PDP2.SODEMLUUTRU * LP.GIAMOTDEM) AS TIENPHONG FROM  HOTELADMIN.PHIEUDATPHONG PDP2 JOIN HOTELADMIN.CT_PHIEUDATPHONG CTPDP ON CTPDP.MAPDP = PDP2.MAPDP JOIN HOTELADMIN.PHONG P ON P.MAPHONG = CTPDP.MAPHONG JOIN HOTELADMIN.LOAIPHONG LP ON LP.MALP = P.LOAIPHONG WHERE PDP2.MAPDP = '{0}') + (CTPDV.SOLUONG * DV.GIADV) + HD.PHUTHU - HD.TIENCOC) AS TIENHOAN FROM HOTELADMIN.PHIEUDATPHONG PDP JOIN HOTELADMIN.PHIEUDICHVU PDV ON PDV.MAPDP = PDP.MAPDP JOIN HOTELADMIN.CT_PHIEUDICHVU CTPDV ON PDV.MAPDV = CTPDV.MAPDV JOIN HOTELADMIN.DICHVU DV ON CTPDV.MADV = DV.MADV JOIN HOTELADMIN.HOADON HD ON PDP.MAPDP = HD.MAPDP WHERE PDP.MAPDP = '{0}'", MaPhong);
                return DataProvider.Instance.ExecuteQuery(query1);
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }
    }
}
