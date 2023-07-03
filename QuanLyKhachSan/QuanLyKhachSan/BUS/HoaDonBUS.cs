using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class HoaDonBUS
    {
        public string MAHD { get; set; }
        public string MAPDP { get; set; }
        public DateTime NGAYCAPNHAT { get; set; }
        public string TRANGTHAI { get; set; }
        public int TIENCOC { get; set; }
        public static int TIENPHONG { get; set; }
        public int TIENDV { get; set; }
        public int PHUTHU { get; set; }
        public int TIENNHAN { get; set; }
        public int TIENHOAN { get; set; }
        public static string PHUONGTHUCTHANHTOAN { get; set; }

        public static HoaDonBUS instance;
        public static HoaDonBUS Instance
        {
            get { if (instance == null) instance = new HoaDonBUS(); return instance; }
            set => instance = value;
        }
        public HoaDonBUS() { }

        [Obsolete]
        public string KHGetInvoiceCode()
        {
            var code = HoaDonDAO.Instance.KHLayMaHoaDon();
            int count = Convert.ToInt32(code.Rows[0][0]);
            if (count < 10)
            {
                return $"HD00{count + 1}";
            }
            return $"HD0{count + 1}";
        }

        [Obsolete]
        public int KHCountRentalFee(string maPDP)
        {
            //lấy phòng ra
            var pdp = PhieuDatPhongDAO.Instance.KHLayPhieuDatPhong(maPDP);

            int soDemLuuTru = Convert.ToInt32(pdp.Rows[0]["SODEMLUUTRU"]);

            //lấy số tiền 1 đêm ứng với từng phòng đã đặt
            var giaTienMotDem = PhieuDatPhongDAO.Instance.KHLayGiaThue1DemCacPhongDaDat(maPDP);
            int giaCacPhong = 0;
            for(int i=0; i<giaTienMotDem.Rows.Count; i++)
            {
                giaCacPhong += Convert.ToInt32(giaTienMotDem.Rows[i][0]);
            }
            return soDemLuuTru * giaCacPhong;
        }

        [Obsolete]
        public void KHAddInvoice(HoaDonBUS hoadon, string ptttoan)
        {
            HoaDonDAO.Instance.KHThemHoaDon(hoadon, ptttoan);
        }

        [Obsolete]
        public void KHCapNhatTienCoc(int tienCoc, string maKH)
        {
            HoaDonDAO.Instance.KHCapNhatTienCoc(tienCoc, maKH);
        }
        [Obsolete]
        public DataTable KHRetrieveInvoice(string maPDP)
        {
            return HoaDonDAO.Instance.KHLayHoaDon(maPDP);
        }
        [Obsolete]
        public void KHUpdatePTTToan(string ptttoan, string maKH)
        {
            HoaDonDAO.Instance.KHCapNhatPttToan(ptttoan, maKH);
        }
        [Obsolete]
        public void KHDeleteInvoice(string maPDP)
        {
            HoaDonDAO.Instance.KHXoaHoaDon(maPDP);
        }
        public DataTable TongTienThanhToan(string MaPhong, string PhuThu)
        {
            return HoaDonDAO.Instance.TongTienThanhToan(MaPhong, PhuThu);
        }
        public DataTable TienHoanLai(string MaPhong, string TienNhan)
        {
            return HoaDonDAO.Instance.TienHoanLai(MaPhong, TienNhan);
        }
        
    }
}
