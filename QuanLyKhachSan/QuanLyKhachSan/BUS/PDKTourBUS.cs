using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class PDKTourBUS
    {
        private static PDKTourBUS instance;

        public static PDKTourBUS Instance
        {
            get { if (instance == null) instance = new PDKTourBUS(); return instance; }
            set => instance = value;
        }

        public PDKTourBUS() { }

        [Obsolete]
        public DataTable LayPDKTour(string MaKh)
        {
            return PDKTourDAO.Instance.LayPDKTour(MaKh);
        }

        [Obsolete]
        public void ThemPDK(PDKTourBUS p)
        {
            PDKTourDAO.Instance.ThemPDK(p);
        }

        [Obsolete]
        public int LaySoLuongPDK()
        {
            return PDKTourDAO.Instance.LaySoLuongPDK();
        }

        public string MaPDKT { get; set; }
        public DateTime TGKhoiHanh { get; set; }
        public int SoNguoiTG { get; set; }
        public string DVDuaDon { get; set; }
        public string MaTDL { get; set; }
        public string YCDB { get; set; }
        public string MaKH { get; set; }
    }
}
