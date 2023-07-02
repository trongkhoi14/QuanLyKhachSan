using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class PhieuDichVuBUS
    {
        private static PhieuDichVuBUS instance;
        public static PhieuDichVuBUS Instance
        {
            get { if (instance == null) instance = new PhieuDichVuBUS(); return instance; }
            set => instance = value;
        }
        private PhieuDichVuBUS() { }

        [Obsolete]
        public DataTable LTLayDSDichVuTheoPDP(string MaPDP)
        {
            return PhieuDichVuDAO.Instance.LTLayPhieuDichVuTheoPDP(MaPDP);
        }

        [Obsolete]
        public string LayMaPhieuDichVu(string MaPDP)
        {
            return PhieuDichVuDAO.Instance.LayMaPhieuDichVu(MaPDP).Rows[0][0].ToString();
        }
    }
}
