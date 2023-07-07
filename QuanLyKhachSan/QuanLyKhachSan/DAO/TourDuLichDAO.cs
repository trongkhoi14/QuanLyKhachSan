using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class TourDuLichDAO
    {
        private static TourDuLichDAO instance;
        public static TourDuLichDAO Instance
        {
            get { if (instance == null) instance = new TourDuLichDAO(); return instance; }
            set => instance = value;
        }
        private TourDuLichDAO() { }

        [Obsolete]
        public DataTable LayDSTour()
        {
            string query = string.Format("SELECT * FROM HOTELADMIN.TOURDULICH");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public DataTable LayDSDoiTac()
        {
            string query = string.Format("SELECT * FROM HOTELADMIN.DOITAC");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public int ThemTour(string matdl, string ten, string diadiem, string mota, string gia, string madt)
        {
            string query = string.Format("INSERT INTO HOTELADMIN.TOURDULICH " +
                "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", matdl, ten, diadiem, mota, gia, madt);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        [Obsolete]
        public int XoaTour(string matdl)
        {
            string query = string.Format("DELETE HOTELADMIN.TOURDULICH WHERE MATDL = '{0}'", matdl);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        [Obsolete]
        public int CapNhatTour(string matdl, string ten, string diadiem, string mota, string gia, string madt)
        {
            string query = string.Format("UPDATE HOTELADMIN.TOURDULICH " +
                "SET TEN = '{0}'," +
                "DIADIEM = '{1}'," +
                "MOTA = '{2}'," +
                "GIA = '{3}'," +
                "MADT = '{4}'" +
                "WHERE MATDL = '{5}'",ten, diadiem, mota, gia, madt, matdl);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

    }
}
