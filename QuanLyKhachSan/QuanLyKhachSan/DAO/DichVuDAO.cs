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
        public DataTable LayDSTheoPDP(string MaPDP)
        {
            string query = string.Format("SELECT * FROM HOTELADMIN.PHIEUDATPHONG");
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
