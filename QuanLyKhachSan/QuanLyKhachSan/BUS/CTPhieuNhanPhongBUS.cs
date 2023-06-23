using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class CTPhieuNhanPhongBUS
    {
        private static CTPhieuNhanPhongBUS instance;
        public static CTPhieuNhanPhongBUS Instance
        {
            get { if (instance == null) instance = new CTPhieuNhanPhongBUS(); return instance; }
            set => instance = value;
        }
        private CTPhieuNhanPhongBUS() { }

        [Obsolete]
        public DataTable LTLayDSKhachHangNhanPhong(string maPNP)
        {
            return CTPhieuNhanPhongDAO.Instance.LTLayDSKhachHangNhanPhong(maPNP);
        }
    }
}
