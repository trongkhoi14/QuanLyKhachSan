using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.DAO
{
    public class CTPhieuDichVuDAO
    {
        private static CTPhieuDichVuDAO instance;

        public static CTPhieuDichVuDAO Instance 
        {
            get { if (instance == null) instance = new CTPhieuDichVuDAO(); return instance; }
            set => instance = value;
        }

        private CTPhieuDichVuDAO() { }

        [Obsolete]
        public DataTable LayCTPhieuDichVu(string MaPDV)
        {
            string query = string.Format($"SELECT * FROM HOTELADMIN.CT_PHIEUDICHVU WHERE MAPDV = '{MaPDV}'");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public void Them(string MaPDV, string MaDV, int SoLuong, DateTime LichSuDung, string GhiChu, string NhanXet)
        {
            string query = string.Format(
                "INSERT INTO HOTELADMIN.CT_PHIEUDICHVU " + 
                $"VALUES ('{MaPDV}', '{MaDV}', '{SoLuong}', TO_DATE('{LichSuDung.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY'), '{GhiChu}', '{NhanXet}')");
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        [Obsolete]
        public bool KiemTraTonTaiDVTrongPDV(string MaPDV, string MaDV, DateTime LichSuDung, string GhiChu)
        {
            string query = string.Format(
                "SELECT COUNT(*) " + 
                "FROM HOTELADMIN.CT_PHIEUDICHVU " + 
                $"WHERE MAPDV = '{MaPDV}' AND MADV = '{MaDV}' AND LICHSUDUNG = TO_DATE('{LichSuDung.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY') AND GHICHU = '{GhiChu}'");
            return (Convert.ToInt32(DataProvider.Instance.ExecuteQuery(query).Rows[0][0].ToString()) > 0);
        }

        [Obsolete]
        public void CapNhatSoLuong(string MaPDV, string MaDV, int SoLuong, DateTime LichSuDung, string GhiChu)
        {
            string query = string.Format(
                "UPDATE HOTELADMIN.CT_PHIEUDICHVU " + 
                $"SET SOLUONG = '{SoLuong}' " +
                $"WHERE MAPDV = '{MaPDV}' AND MADV = '{MaDV}' AND LICHSUDUNG = TO_DATE('{LichSuDung.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY') AND GHICHU = '{GhiChu}'");
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        [Obsolete]
        public int LaySoLuongDV(string MaPDV, string MaDV, DateTime LichSuDung, string GhiChu)
        {
            string query = string.Format(
                "SELECT SOLUONG " + 
                "FROM HOTELADMIN.CT_PHIEUDICHVU " +
                $"WHERE MAPDV = '{MaPDV}' AND MADV = '{MaDV}' AND LICHSUDUNG = TO_DATE('{LichSuDung.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY') AND GHICHU = '{GhiChu}'");
            return Convert.ToInt32(DataProvider.Instance.ExecuteQuery(query).Rows[0][0].ToString());
        }
    }
}
