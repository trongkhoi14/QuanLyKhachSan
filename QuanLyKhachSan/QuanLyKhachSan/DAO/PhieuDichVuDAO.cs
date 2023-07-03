using QuanLyKhachSan.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class PhieuDichVuDAO
    {
        private static PhieuDichVuDAO instance;
        public static PhieuDichVuDAO Instance
        {
            get { if (instance == null) instance = new PhieuDichVuDAO(); return instance; }
            set => instance = value;
        }
        private PhieuDichVuDAO() { }

        [Obsolete]
        public DataTable LTLayPhieuDichVuTheoPDP(string MaPDP)
        {
            string query = string.Format("SELECT D.TENDV, C.SOLUONG, D.DONVITINH, C.LICHSUDUNG, C.GHICHU, D.GIADV " +
                                         "FROM HOTELADMIN.PHIEUDICHVU P " +
                                         "JOIN HOTELADMIN.CT_PHIEUDICHVU C ON C.MAPDV = P.MAPDV " +
                                         "JOIN HOTELADMIN.DICHVU D ON D.MADV = C.MADV " +
                                         "WHERE P.MAPDP = '{0}'", MaPDP);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public DataTable LayMaPhieuDichVu(string MaPDP)
        {
            string query = string.Format($"SELECT MAPDV FROM HOTELADMIN.PHIEUDICHVU WHERE MAPDP = '{MaPDP}'");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public DataTable LayPhieuDichVuChuaCapNhat()
        {
            string query = string.Format("SELECT A.MAPDV, A.MADV, A.SOLUONG, A.LICHSUDUNG, A.GHICHU, A.NHANXET, B.NGAYCAPNHAT, B.MANV, B.MAPDP FROM HOTELADMIN.CT_PHIEUDICHVU A, HOTELADMIN.PHIEUDICHVU B WHERE A.MAPDV = B.MAPDV AND A.LICHSUDUNG > B.NGAYCAPNHAT");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public DataTable LayPhieuDichVuHienCo()
        {
            string query = string.Format("SELECT * FROM HOTELADMIN.PHIEUDICHVU");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public void CapNhatPDV(string MaNV, DateTime NgayCapNhat, string MaPDV)
        {
            string query = string.Format($"UPDATE HOTELADMIN.PHIEUDICHVU SET MANV = '{MaNV}', NGAYCAPNHAT = TO_DATE('{NgayCapNhat.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY') WHERE MAPDV = '{MaPDV}'");
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
