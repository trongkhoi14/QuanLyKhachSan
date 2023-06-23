using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            set => instance = value;
        }

        private NhanVienDAO() { }
        
        [Obsolete]
        public DataTable LayNhanVien(string MaNV)
        {
            string query = string.Format("SELECT * FROM HOTELADMIN.NHANVIEN WHERE MANV = '{0}'", MaNV);
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
