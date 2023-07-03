using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class TourDuLichBUS
    {
        private static TourDuLichBUS instance;

        public static TourDuLichBUS Instance
        {
            get { if (instance == null) instance = new TourDuLichBUS(); return instance; }
            set => instance = value;
        }

        public TourDuLichBUS() { }

        public TourDuLichBUS(string MaTDL, string Ten, string DiaDiem, string MoTa, double Gia, string MaDT)
        {
            this.MaTDL = MaTDL ;
            this.Ten = Ten;
            this.DiaDiem = DiaDiem;
            this.MoTa = MoTa;
            this.Gia = Gia;
            this.MaDT = MaDT;
        }

        [Obsolete]
        public DataTable LayDSTour()
        {
            return TourDuLichDAO.Instance.LayDSTour();
        }

        public string MaTDL { get; set; }
        public string Ten { get; set; }
        public string DiaDiem { get; set; }
        public string MoTa { get; set; }
        public double Gia { get; set; }
        public string MaDT { get; set; }
    }
}
