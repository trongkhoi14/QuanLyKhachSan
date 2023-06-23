using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;
        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            set => instance = value;
        }
        private KhachHangDAO() { }

        [Obsolete]
        public DataTable LTLayDanhSach()
        {
            string query = string.Format("SELECT * FROM HOTELADMIN.KHACHHANG");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public DataTable LTLayKhachHang(string tenkh, string ngaysinh, string diachi)
        {
            string query = string.Format("SELECT * FROM HOTELADMIN.KHACHHANG " +
                                        "WHERE TENKH = '{0}' " +
                                        "AND NGAYSINH = TO_DATE('{1}', 'DD/MM/YYYY') " +
                                        "AND DIACHI = '{2}'", tenkh, ngaysinh, diachi);
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
