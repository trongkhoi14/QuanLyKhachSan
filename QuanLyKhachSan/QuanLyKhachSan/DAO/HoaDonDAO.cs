using QuanLyKhachSan.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return instance; }
            set => instance = value;
        }

        private HoaDonDAO() { }

        [Obsolete] 
        public void KHAddInvoice(HoaDonBUS hoadon)
        {
            string query = string.Format($"insert into HOTELADMIN.hoadon values('{hoadon.MAHD}','{hoadon.MAPDP}'," +
                $"TO_DATE('{hoadon.NGAYCAPNHAT.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY'),'{hoadon.TRANGTHAI}','{hoadon.TIENCOC}'," +
                $"'{hoadon.PHUTHU}','{hoadon.TIENNHAN}','{hoadon.TIENHOAN}','{HoaDonBUS.PHUONGTHUCTHANHTOAN}')");
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        [Obsolete]
        public DataTable KHRetrieveInvoiceCode()
        {
            string query = string.Format("select count(*) from HOTELADMIN.hoadon");
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
