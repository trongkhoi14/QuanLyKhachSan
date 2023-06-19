using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class PhieuDatPhongDAO
    {
        private static PhieuDatPhongDAO instance;
        public static PhieuDatPhongDAO Instance
        {
            get { if (instance == null) instance = new PhieuDatPhongDAO(); return instance; }
            set => instance = value;
        }
        private PhieuDatPhongDAO() { }

        [Obsolete]
        public DataTable LayDanhSach()
        {
            string query = string.Format("SELECT P.MAPDP, K.TENKH, K.NGAYSINH, K.DIACHI, K.EMAIL, K.SODT, K.SOFAX, P.NGAYDEN, P.SODEMLUUTRU, P.SONGUOI, P.TINHTRANG AS THANHTOAN " +
                                         "FROM HOTELADMIN.PHIEUDATPHONG P " +
                                         "JOIN HOTELADMIN.KHACHHANG K ON K.MAKH = P.MAKH");
            return DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
