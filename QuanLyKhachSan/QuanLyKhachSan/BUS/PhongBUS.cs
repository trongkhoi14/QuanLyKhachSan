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
        public DataTable LTLayDSPhongTheoPDP(string MaPDP)
        {
            return PhongDAO.Instance.LTLayDSTheoPDP(MaPDP);
            
        }
         [Obsolete]
        public DataTable KHLayDSPhongTheoPDP(string MaPDP)
        {
            
            return PhongDAO.Instance.KHLayDSTheoPDP(MaPDP);
        }
        //checkout
        public DataTable PhongTraCuuCK(string MaPhong)
        {
            return PhongDAO.Instance.PhongTraCuuCK(MaPhong);
        }
        public DataTable PhongCapNhatCK(string MaPhong, string TrangThai)
        {
            return PhongDAO.Instance.PhongCapNhatCK(MaPhong, TrangThai);
        }
    }
}
