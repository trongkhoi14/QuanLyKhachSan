using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class KhachHangBUS
    {
        private static KhachHangBUS instance;
        public static KhachHangBUS Instance
        {
            get { if (instance == null) instance = new KhachHangBUS(); return instance; }
            set => instance = value;
        }
        private KhachHangBUS() { }

        [Obsolete]
        public DataTable KHLayThongTinBanThan()
        {
            return KhachHangDAO.Instance.KHGetSelfInformation();
        }
    }
}
