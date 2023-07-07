using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class DichVuDAO
    {
        private static DichVuDAO instance;
        public static DichVuDAO Instance
        {
            get { if (instance == null) instance = new DichVuDAO(); return instance; }
            set => instance = value;
        }
        private DichVuDAO() { }

        [Obsolete]
        public DataTable LayDSDV()
        {
            string query = string.Format("SELECT * FROM HOTELADMIN.DICHVU");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public DataTable LayDVTheoMaDV(string MaDV)
        {
            string query = string.Format($"SELECT * FROM HOTELADMIN.DICHVU WHERE MADV = '{MaDV}'");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        //-------
        [Obsolete]
        public int ThemDV(string madv, string tendv, string donvitinh, string gia, string loai)
        {
            string query = string.Format("INSERT INTO HOTELADMIN.DICHVU " +
                "VALUES ('{0}','{1}','{2}','{3}','{4}')", madv, tendv, donvitinh, gia, loai);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        [Obsolete]
        public int XoaDV(string madv)
        {
            string query = string.Format("DELETE HOTELADMIN.DICHVU WHERE MADV = '{0}'", madv);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        [Obsolete]
        public int CapNhatDV(string madv, string tendv, string donvitinh, string gia, string loai)
        {
            string query = string.Format("UPDATE HOTELADMIN.DICHVU " +
                "SET TENDV = '{0}'," +
                "DONVITINH = '{1}'," +
                "GIADV = '{2}'," +
                "LOAIDV = '{3}'" +
                "WHERE MADV = '{4}'", tendv, donvitinh, gia, loai, madv);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
