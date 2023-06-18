using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class PhieuDatPhongBUS
    {
        private static PhieuDatPhongBUS instance;
        public static PhieuDatPhongBUS Instance
        {
            get { if (instance == null) instance = new PhieuDatPhongBUS(); return instance; }
            set => instance = value;
        }
        private PhieuDatPhongBUS() { }

        [Obsolete]
        public DataTable LayDanhSachPDP()
        {
            return PhieuDatPhongDAO.Instance.LayDanhSach();
        }    
    }
}
