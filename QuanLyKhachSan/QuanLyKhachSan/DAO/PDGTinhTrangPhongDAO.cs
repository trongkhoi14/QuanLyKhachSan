using QuanLyKhachSan.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class PDGTinhTrangPhongDAO
    {
        private static PDGTinhTrangPhongDAO instance;
        public static PDGTinhTrangPhongDAO Instance
        {
            get { if (instance == null) instance = new PDGTinhTrangPhongDAO(); return instance; }
            set => instance = value;
        }
        public PDGTinhTrangPhongDAO() { }

        [Obsolete]
        public DataTable BPLayMaPdgttPhong()
        {
            string query = string.Format($"select count(*) from HOTELADMIN.pdgtinhtrangphong");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public void BPThemPDPTTPhong(PDGTinhTrangPhongBUS pdgttp)
        {
            string query = string.Format($"insert into HOTELADMIN.pdgtinhtrangphong values('{pdgttp.MAPDG}','{pdgttp.MAPDP}','{pdgttp.MAPHONG}'," +
                $"TO_DATE('{pdgttp.NGAYLAP.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY'),'{pdgttp.MOTA}','{PDGTinhTrangPhongBUS.MANV}') ");
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
