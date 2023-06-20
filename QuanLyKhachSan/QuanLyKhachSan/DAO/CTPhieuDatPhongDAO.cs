using System;
using System.Collections.Generic;
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
      
    }
}
