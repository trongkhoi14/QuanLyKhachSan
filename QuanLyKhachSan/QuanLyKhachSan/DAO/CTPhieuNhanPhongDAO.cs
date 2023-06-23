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
        public DataTable LTLayDSKhachHangNhanPhong(string maPNP)
        {
            string query = string.Format("SELECT KH.TENKH, KH.NGAYSINH, KH.DIACHI, KH.EMAIL, KH.SODT, KH.SOFAX, KH.TINHTRANG " +
                                        "FROM HOTELADMIN.CT_PHIEUNHANPHONG P " +
                                        "JOIN HOTELADMIN.KHACHHANG KH ON P.MAKH = KH.MAKH " +
                                        "WHERE MAPNP = '{0}'", maPNP);
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
