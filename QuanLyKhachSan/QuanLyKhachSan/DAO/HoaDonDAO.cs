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
        [Obsolete]
        public void KHUpdateTienCoc(int tienCoc)
        {
            string query = string.Format("update HOTELADMIN.hoadon " +
                                        $"set tiencoc = {tienCoc} " +
                                        "where mapdp = (select mapdp from HOTELADMIN.phieudatphong " +
                                                        $"where makh='{PhieuDatPhongBUS.MAKH}' and  " +
                                                        $"ngaylap = (select max(ngaylap) " +
                                                                   $"from HOTELADMIN.phieudatphong where makh='{PhieuDatPhongBUS.MAKH}'))");
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        [Obsolete]
        public DataTable KHRetrieveInvoice()
        {
            string query = string.Format($"select * from HOTELADMIN.hoadon " +
                                         $"where mapdp = '{PhieuDatPhongBUS.Instance.KHLayMaPDPGanNhat(PhieuDatPhongBUS.MAKH)}'");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public void KHUpdatePTTToan(string ptttoan)
        {
            string query = string.Format("update HOTELADMIN.hoadon " +
                                        $"set phuongthuctt = '{ptttoan}' " +
                                        "where mapdp = (select mapdp from HOTELADMIN.phieudatphong " +
                                                        $"where makh='{PhieuDatPhongBUS.MAKH}' and  " +
                                                        $"ngaylap = (select max(ngaylap) " +
                                                                   $"from HOTELADMIN.phieudatphong where makh='{PhieuDatPhongBUS.MAKH}'))");
            DataProvider.Instance.ExecuteNonQuery(query);
        }

    }
}
