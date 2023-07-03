using QuanLyKhachSan.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            set => instance = value;
        }
        private TaiKhoanDAO() { }

        [Obsolete]
        public void KHChangePassword(string password)
        {
            string query = $"ALTER USER {PhieuDatPhongBUS.MAKH} IDENTIFIED BY {password}";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        [Obsolete]
        public string LayTenTaiKhoanLogin()
        {
            string query = string.Format("SELECT SYS_CONTEXT ('USERENV', 'SESSION_USER') FROM DUAL");
            return DataProvider.Instance.ExecuteQuery(query).Rows[0][0].ToString();
        }
    }
}
