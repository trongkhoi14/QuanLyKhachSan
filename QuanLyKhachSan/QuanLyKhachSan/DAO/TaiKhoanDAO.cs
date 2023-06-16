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

        public bool Login(string userName, string passWord)
        {
            try
            {
                string connectionSTR = @"DATA SOURCE=localhost:1521/xe; USER ID=" + userName + ";PASSWORD=" + passWord;

                DataProvider.Instance.SetConnectionString(connectionSTR);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
