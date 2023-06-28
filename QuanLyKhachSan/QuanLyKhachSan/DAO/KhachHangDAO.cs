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
        public DataTable LTLayDanhSach()
        {
            string query = string.Format("SELECT * FROM HOTELADMIN.KHACHHANG");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public DataTable LTLayKhachHang(string tenkh, string ngaysinh, string diachi)
        {
            string query = string.Format("SELECT * FROM HOTELADMIN.KHACHHANG " +
                                        "WHERE TENKH = '{0}' " +
                                        "AND NGAYSINH = TO_DATE('{1}', 'DD/MM/YYYY') " +
                                        "AND DIACHI = '{2}'", tenkh, ngaysinh, diachi);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        [Obsolete]
        public int LTThemKhachHang(string makh, string tenkh, string ngaysinh, string diachi, string email, string sodt, string sofax)
        {
            string query = string.Format("INSERT INTO HOTELADMIN.KHACHHANG (MAKH, TENKH, NGAYSINH, DIACHI, EMAIL, SODT, SOFAX) " +
                "VALUES('{0}', '{1}', TO_DATE('{2}', 'DD/MM/YYYY'), " +
                "'{3}', '{4}', '{5}', '{6}')", makh, tenkh, ngaysinh, diachi, email, sodt, sofax);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        [Obsolete]
        public int LTCapNhatKhachHang(string makh, string email, string sodt, string sofax)
        {
            string query = string.Format("UPDATE HOTELADMIN.KHACHHANG " +
                                         "SET EMAIL = '{0}', " +
                                         "SODT = '{1}', " +
                                         "SOFAX = '{2}' " +
                                         "WHERE MAKH = '{3}'", email, sodt, sofax, makh);
            return DataProvider.Instance.ExecuteNonQuery(query);
            
        }
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
