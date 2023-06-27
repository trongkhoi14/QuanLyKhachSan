using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class CTPhieuNhanPhongDAO
    {
        private static CTPhieuNhanPhongDAO instance;
        public static CTPhieuNhanPhongDAO Instance
        {
            get { if (instance == null) instance = new CTPhieuNhanPhongDAO(); return instance; }
            set => instance = value;
        }
        private CTPhieuNhanPhongDAO() { }

        [Obsolete]
        public DataTable LTLayThongTinDatPhong(string mapnp)
        {
            string query = string.Format("SELECT PDP.SONGUOI " +
                "FROM HOTELADMIN.PHIEUNHANPHONG PNP " +
                "JOIN HOTELADMIN.PHIEUDATPHONG PDP ON PDP.MAPDP = PNP.MAPDP " +
                "WHERE MAPNP = '{0}'", mapnp);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public DataTable LTLayDSKhachHangNhanPhong(string maPNP)
        {
            string query = string.Format("SELECT KH.TENKH, KH.NGAYSINH, KH.DIACHI, KH.EMAIL, KH.SODT, KH.SOFAX, KH.TINHTRANG " +
                                        "FROM HOTELADMIN.CT_PHIEUNHANPHONG P " +
                                        "JOIN HOTELADMIN.KHACHHANG KH ON P.MAKH = KH.MAKH " +
                                        "WHERE MAPNP = '{0}'", maPNP);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public int LTThem(string mapnp, string makh)
        {
            string query = string.Format("INSERT INTO HOTELADMIN.CT_PHIEUNHANPHONG (MAPNP, MAKH) " +
                                         "VALUES('{0}', '{1}')", mapnp, makh);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        [Obsolete]
        public DataTable LTLay(string mapnp, string makh)
        { 
            string query = string.Format("SELECT * FROM HOTELADMIN.CT_PHIEUNHANPHONG " +
                                         "WHERE MAPNP = '{0}' AND MAKH = '{1}'", mapnp, makh);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public int LTXoa(string mapnp, string makh)
        {
            string query = string.Format("DELETE FROM HOTELADMIN.CT_PHIEUNHANPHONG " +
                                         "WHERE MAPNP = '{0}' AND MAKH = '{1}'", mapnp, makh);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
