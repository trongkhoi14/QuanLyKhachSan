using QuanLyKhachSan.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class PDKTourDAO
    {
        private static PDKTourDAO instance;
        public static PDKTourDAO Instance
        {
            get { if (instance == null) instance = new PDKTourDAO(); return instance; }
            set => instance = value;
        }
        private PDKTourDAO() { }

        [Obsolete]
        public DataTable LayPDKTour(string MaKH)
        {
            string query = string.Format($"SELECT A.MAPDKT, A.TGKHOIHANH, A.SONGUOITG, A.DICHVUDUADON, A.MATDL, A.YCDB FROM HOTELADMIN.PDKTOUR A, HOTELADMIN.CT_PDKTOUR B WHERE A.MAPDKT = B.MAPDK AND B.MAKH = '{MaKH}'");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public void ThemPDK(PDKTourBUS p)
        {
            string query = string.Format($"INSERT INTO HOTELADMIN.PDKTOUR VALUES ('{p.MaPDKT}',TO_DATE('{p.TGKhoiHanh.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY'),'{p.SoNguoiTG}','{p.DVDuaDon}','{p.MaTDL}','{p.YCDB}')");
            DataProvider.Instance.ExecuteNonQuery(query);
            query = string.Format($"INSERT INTO HOTELADMIN.CT_PDKTOUR VALUES ('{p.MaPDKT}','{p.MaKH}')");
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        [Obsolete]
        public int LaySoLuongPDK()
        {
            string query = string.Format($"SELECT COUNT(*) FROM HOTELADMIN.PDKTOUR");
            return Convert.ToInt32(DataProvider.Instance.ExecuteQuery(query).Rows[0][0].ToString());
        }
    }
}
