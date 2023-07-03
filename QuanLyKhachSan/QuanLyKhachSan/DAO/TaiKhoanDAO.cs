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
        public void KHDoiMatKhau(string password,string username)
        {
                
        }

        [Obsolete]
        public string LayTenTaiKhoanLogin()
        {
            string query = string.Format("SELECT SYS_CONTEXT ('USERENV', 'SESSION_USER') FROM DUAL");
            return DataProvider.Instance.ExecuteQuery(query).Rows[0][0].ToString();
        }
    }
}
