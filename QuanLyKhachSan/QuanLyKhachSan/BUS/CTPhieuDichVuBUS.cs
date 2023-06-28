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
        private CTPhieuDichVuBUS() { }

        public string MaPDV;
        public string MPDV;
        public string SoLuong;
        public DateTime LichSuDung;
        public string GhiChu;
        public string NhanXet;
    }
}
