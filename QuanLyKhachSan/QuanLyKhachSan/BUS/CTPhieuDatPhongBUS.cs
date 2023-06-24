using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class CTPhieuDatPhongBUS
    {
        private static CTPhieuDatPhongBUS instance;
        public static CTPhieuDatPhongBUS Instance
        {
            get { if (instance == null) instance = new CTPhieuDatPhongBUS(); return instance; }
            set => instance = value;
        }
        private CTPhieuDatPhongBUS() { }

        [Obsolete]
        public void KHThemCtPDP(string MAPDP, string MAPHONG)
        {
            CTPhieuDatPhongDAO.Instance.KHThemCTPhieuDatPhong(MAPDP, MAPHONG);
        }
        [Obsolete]
        public void KHDeleteCtPDP(string maPDP)
        {
            CTPhieuDatPhongDAO.Instance.KHDeleteCtPDP(maPDP);
        }
    }
}
