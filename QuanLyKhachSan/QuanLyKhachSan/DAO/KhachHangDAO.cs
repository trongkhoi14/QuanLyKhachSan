using QuanLyKhachSan.BUS;
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
        public DataTable KHGetSelfInformation()
        {
            string query = string.Format($"SELECT * FROM HOTELADMIN.khachhang WHERE makh = '{PhieuDatPhongBUS.MAKH}'");
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
