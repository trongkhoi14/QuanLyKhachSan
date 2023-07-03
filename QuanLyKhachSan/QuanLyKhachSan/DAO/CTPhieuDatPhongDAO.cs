using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class CTPhieuDatPhongDAO
    {
        private static CTPhieuDatPhongDAO instance;
        public static CTPhieuDatPhongDAO Instance
        {
            get { if (instance == null) instance = new CTPhieuDatPhongDAO(); return instance; }
            set => instance = value;
        }
        private CTPhieuDatPhongDAO() { }
        [Obsolete]
        public bool KHThemCTPhieuDatPhong(string MAPDP, string MAPHONG)
        {
            string query = string.Format($"insert into HOTELADMIN.ct_phieudatphong values('{MAPDP}','{MAPHONG}')");
            DataProvider.Instance.ExecuteNonQuery(query);
            return true;
        }
        [Obsolete]
        public DataTable KHTinhTongTienThuePhong(string maPDP)
        {
            string query = string.Format($"select lp.giamotdem " +
                                        $"from HOTELADMIN.ct_phieudatphong ct " +
                                        $"join phong p on ct.maphong = p.maphong " +
                                        $"join loaiphong lp on p.loaiphong = lp.malp " +
                                        $"where ct.mapdp='{maPDP}'");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        [Obsolete]
        public void KHXoaCTPhieuDatPhong(string maPDP)
        {
            string query = string.Format($"delete from HOTELADMIN.ct_phieudatphong where mapdp='{maPDP}'");
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        [Obsolete]
        public DataTable BPLayMaPDP(string maPhong)
        {
            string query = string.Format($"select mapdp from HOTELADMIN.ct_phieudatphong where maphong='{maPhong}'");
            return DataProvider.Instance.ExecuteQuery(query);
        }


    }
}
