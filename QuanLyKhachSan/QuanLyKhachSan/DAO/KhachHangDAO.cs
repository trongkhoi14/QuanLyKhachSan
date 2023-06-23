using QuanLyKhachSan.BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;
        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            set => instance = value;
        }
        private KhachHangDAO() { }

        [Obsolete]
        public DataTable KHGetSelfInformation()
        {
            string query = string.Format($"SELECT * FROM HOTELADMIN.khachhang WHERE makh = '{PhieuDatPhongBUS.MAKH}'");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        [Obsolete]
        public void KHUpdateSelfInformation(KhachHangBUS newInfo)
        {
            string query = string.Format($"update HOTELADMIN.khachhang " +
                                            $"set    " +
                                            $"tenkh='{newInfo.TENKH}',    " +
                                            $"ngaysinh = TO_DATE('{newInfo.NGAYSINH.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY'),    " +
                                            $"diachi= '{newInfo.DIACHI}',  " +
                                            $"email= '{newInfo.EMAIL}',  " +
                                            $"sodt= '{newInfo.SODT}',  " +
                                            $"sofax= '{newInfo.SOFAX}'  " +
                                            $"where makh='{PhieuDatPhongBUS.MAKH}' ");
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
