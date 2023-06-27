using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class PhongDAO
    {
        private static PhongDAO instance;
        public static PhongDAO Instance
        {
            get { if (instance == null) instance = new PhongDAO(); return instance; }
            set => instance = value;
        }
        private PhongDAO() { }

        [Obsolete]
        public DataTable LTLayDSTheoPDP(string MaPDP)
        {
            string query = string.Format("SELECT P.MAPHONG, P.TRANGTHAI, L.HANGPHONG, L.GIAMOTDEM " +
                                         "FROM HOTELADMIN.PHONG P " +
                                         "JOIN HOTELADMIN.CT_PHIEUDATPHONG C ON C.MAPHONG = P.MAPHONG " +
                                         "JOIN HOTELADMIN.LOAIPHONG L ON L.MALP = P.LOAIPHONG " +
                                         "WHERE C.MAPDP = '{0}'", MaPDP);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable KHLayDSTheoPDP(string MaPDP)
        {
            string query = string.Format("SELECT P.MAPHONG, P.TRANGTHAI, L.HANGPHONG, L.GIAMOTDEM " +
                                         "FROM HOTELADMIN.PHONG P " +
                                         "JOIN HOTELADMIN.CT_PHIEUDATPHONG C ON C.MAPHONG = P.MAPHONG " +
                                         "JOIN HOTELADMIN.LOAIPHONG L ON L.MALP = P.LOAIPHONG " +
                                         "WHERE C.MAPDP = '{0}'", MaPDP);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        [Obsolete]
        public DataTable BPSelectPDGCodeFromDB(string maPhong)
        {
            string query = string.Format($"select count(*) from HOTELADMIN.phong where maphong = '{maPhong}'");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        //checkout
        public DataTable PhongTraCuuCK(string MaPhong)
        {
            try
            {
                string query = string.Format("SELECT KH.TENKH, P.MAPHONG, PDG.MOTA FROM HOTELADMIN.PDGTINHTRANGPHONG PDG JOIN HOTELADMIN.PHIEUDATPHONG PDP ON PDG.MAPDP = PDP.MAPDP JOIN HOTELADMIN.KHACHHANG KH ON PDP.MAKH = KH.MAKH JOIN HOTELADMIN.PHONG P ON PDG.MAPHONG = P.MAPHONG WHERE PDP.MAPDP = '{0}'", MaPhong);
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }
        public DataTable PhongCapNhatCK(string MaPhong, string TrangThai)
        {
            try
            {
                string query = string.Format("UPDATE HOTELADMIN.PHONG SET TRANGTHAI = '{0}' WHERE MAPHONG IN (SELECT MAPHONG FROM HOTELADMIN.CT_PHIEUDATPHONG WHERE MAPDP = '{1}')", TrangThai, MaPhong);
                DataProvider.Instance.ExecuteNonQuery(query);
                string query1 = string.Format("SELECT * FROM HOTELADMIN.PHONG WHERE MAPHONG IN (SELECT MAPHONG FROM HOTELADMIN.CT_PHIEUDATPHONG WHERE MAPDP = '{0}')", MaPhong);
                return DataProvider.Instance.ExecuteQuery(query1);
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }
    }
}
