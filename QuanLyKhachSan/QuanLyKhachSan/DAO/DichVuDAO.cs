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
    }
}
