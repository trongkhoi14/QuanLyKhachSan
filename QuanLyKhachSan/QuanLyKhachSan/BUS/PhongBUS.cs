using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class PhongBUS
    {
        private static PhongBUS instance;
        public static PhongBUS Instance
        {
            get { if (instance == null) instance = new PhongBUS(); return instance; }
            set => instance = value;
        }
        private PhongBUS() { }

        [Obsolete]
        public DataTable LayDSPhongTheoPDP(string MaPDP)
        {
            return PhongDAO.Instance.KHLayDSTheoPDP(MaPDP);
        }
    }
}
