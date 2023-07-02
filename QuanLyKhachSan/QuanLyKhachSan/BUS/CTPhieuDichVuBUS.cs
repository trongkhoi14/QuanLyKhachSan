using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class CTPhieuDichVuBUS
    {
        private static CTPhieuDichVuBUS instance;
        public static CTPhieuDichVuBUS Instance
        {
            get { if (instance == null) instance = new CTPhieuDichVuBUS(); return instance; }
            set => instance = value;
        }
        public CTPhieuDichVuBUS() { }

        public CTPhieuDichVuBUS(string MaPDV, string MaDV, int SoLuong, DateTime LichSuDung, string GhiChu, string NhanXet)
        {
            this.MaPDV = MaPDV;
            this.MaDV = MaDV;
            this.SoLuong = SoLuong;
            this.LichSuDung = LichSuDung;
            this.GhiChu = GhiChu;
            this.NhanXet = NhanXet;
        }

        [Obsolete]
        public DataTable LayCTPhieuDichVu(string MaPDV)
        {
            return CTPhieuDichVuDAO.Instance.LayCTPhieuDichVu(MaPDV);
        }

        [Obsolete]
        public void ThemCTPhieuDichVu(string MaPDV, string MaDV, int SoLuong, DateTime LichSuDung, string GhiChu, string NhanXet)
        {
            if (KiemTraTonTaiDVTrongPDV(MaPDV, MaDV, LichSuDung, GhiChu))
            {
                int slHienTai = CTPhieuDichVuDAO.Instance.LaySoLuongDV(MaPDV, MaDV, LichSuDung, GhiChu);
                SoLuong = slHienTai + SoLuong;
                CTPhieuDichVuDAO.Instance.CapNhatSoLuong(MaPDV, MaDV, SoLuong, LichSuDung, GhiChu);
            }
            else
            {
                CTPhieuDichVuDAO.Instance.Them(MaPDV, MaDV, SoLuong, LichSuDung, GhiChu, NhanXet);
            }
        }

        [Obsolete]
        public bool KiemTraTonTaiDVTrongPDV(string MaPDV, string MaDV, DateTime LichSuDung, string GhiChu)
        {
            return CTPhieuDichVuDAO.Instance.KiemTraTonTaiDVTrongPDV(MaPDV, MaDV, LichSuDung, GhiChu);
        }

        public string MaPDV { get; set; }
        public string MaDV { get; set; }
        public int SoLuong { get; set; }
        public DateTime LichSuDung { get; set; }
        public string GhiChu { get; set; }
        public string NhanXet { get; set; }
    }
}
