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
        public DataTable LayDSTheoPDP(string MaPDP)
        {
            string query = string.Format("SELECT P.MAPHONG, P.TRANGTHAI, L.HANGPHONG, L.GIAMOTDEM " +
                                         "FROM HOTELADMIN.PHONG P " +
                                         "JOIN HOTELADMIN.CT_PHIEUDATPHONG C ON C.MAPHONG = P.MAPHONG " +
                                         "JOIN HOTELADMIN.LOAIPHONG L ON L.MALP = P.LOAIPHONG " +
                                         "WHERE C.MAPDP = '{0}'", MaPDP);
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
