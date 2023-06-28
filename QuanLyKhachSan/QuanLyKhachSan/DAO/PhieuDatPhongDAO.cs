using QuanLyKhachSan.BUS;
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
        public DataTable LTLayDanhSach()
        {
            string query = string.Format("SELECT P.MAPDP, K.TENKH, K.NGAYSINH, K.DIACHI, K.EMAIL, K.SODT, K.SOFAX, P.NGAYDEN, P.SODEMLUUTRU, P.SONGUOI, P.TINHTRANG AS THANHTOAN " +
                                         "FROM HOTELADMIN.PHIEUDATPHONG P " +
                                         "JOIN HOTELADMIN.KHACHHANG K ON K.MAKH = P.MAKH");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        //Lấy danh sách phòng trống để khách hàng đặt
        [Obsolete]
        public DataTable KHLayDanhSachPhongTrong()
        {
            string query = string.Format("select p.maphong,lp.hangphong, lp.loaigiuong,lp.succhua, lp.mota, lp.giamotdem " +
                                        "from HOTELADMIN.phong p join HOTELADMIN.loaiphong lp " +
                                            "on p.loaiphong=lp.malp " +
                                        "where p.maphong not in (select maphong from HOTELADMIN.ct_phieudatphong) " +
                                        " and p.trangthai='O duoc'");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        [Obsolete]
        public void KHThemPhieuDatPhong(PhieuDatPhongBUS pdp, string maKH)
        {
            string query = string.Format($"INSERT INTO HOTELADMIN.phieudatphong(MAPDP, TINHTRANG, NGAYLAP, NGAYDEN, SODEMLUUTRU, SONGUOI, MANV, MAKH) " +
               $"VALUES ('{pdp.MAPDP}', 'Chua coc', TO_DATE('{pdp.NGAYLAP.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY'), " +
               $"TO_DATE('{pdp.NGAYDEN.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY'), '{pdp.SODEMLUUTRU}', '{pdp.SONGUOI}', 'NV001', '{maKH}')");
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        [Obsolete]
        public DataTable KHLayMaPDPMoiNhat()
        {
            string query = string.Format("select count(*) from HOTELADMIN.phieudatphong");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        //Lấy danh sách phiếu đặt phòng đã đặt của khách hàng
        [Obsolete]
        public DataTable KHLayPhieuTatCaPDPDaDat(string maKH)
        {
            string query = string.Format(
            $"select p.mapdp, p.tinhtrang, p.ngaylap, p.ngayden, p.sodemluutru, p.songuoi, ct.maphong " +
            $"from HOTELADMIN.phieudatphong p join HOTELADMIN.ct_phieudatphong ct " +
                $"on p.mapdp = ct.mapdp " +
            $"where makh='{maKH}' " +
            $"order by p.mapdp");

            return DataProvider.Instance.ExecuteQuery(query);
        }
        [Obsolete]
        //Lấy loại phòng mà khách hàng đã đặt
        public DataTable KHLayThongTinPhongDaDat(string maKH)
        {
            string query = string.Format(
                "select pdp.mapdp, lp.hangphong, lp.loaigiuong, lp.mota, lp.succhua, lp.giamotdem " +
                "from HOTELADMIN.phieudatphong pdp " +
                "join HOTELADMIN.ct_phieudatphong ct " +
                  "on pdp.mapdp = ct.mapdp " +
                "join HOTELADMIN.phong p " +
                  "on ct.maphong=p.maphong " +
                "join HOTELADMIN.loaiphong lp " +
                  "on p.loaiphong=lp.malp " +
                $"where pdp.makh='{maKH}' " +
                $" order by pdp.mapdp");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        [Obsolete]
        public DataTable KHLayLoaiPhongVoiMaPDP(string maPDP, string maKH)
        {
            string query = string.Format(
                "select pdp.mapdp,p.maphong, lp.hangphong, lp.loaigiuong, lp.mota, lp.succhua, lp.giamotdem " +
                "from HOTELADMIN.phieudatphong pdp " +
                "join HOTELADMIN.ct_phieudatphong ct " +
                  "on pdp.mapdp = ct.mapdp " +
                "join HOTELADMIN.phong p " +
                  "on ct.maphong=p.maphong " +
                "join HOTELADMIN.loaiphong lp " +
                  "on p.loaiphong=lp.malp " +
                $"where pdp.makh='{maKH}' and  pdp.mapdp='{maPDP}'" +
                $" order by pdp.mapdp");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        //Lấy phiếu đặt phòng theo mã phiếu đặt phòng
        [Obsolete]
        public DataTable KHLayPhieuDatPhong(string maPDP)
        {
            string query = string.Format($"select * from HOTELADMIN.phieudatphong where mapdp='{maPDP}'");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        //Lấy giá thuê một đêm của phòng mà khách hàng đã đặt
        [Obsolete]
        public DataTable KHLayGiaThue1DemCacPhongDaDat(string maPDP)
        {
            string query = string.Format($"select lp.giamotdem " +
                                        $"from HOTELADMIN.ct_phieudatphong ct " +
                                        $"join HOTELADMIN.phong p on ct.maphong = p.maphong " +
                                        $"join HOTELADMIN.loaiphong lp on p.loaiphong = lp.malp " +
                                        $"where ct.mapdp='{maPDP}'");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        //Lấy ngày lập phiếu đặt phòng gần nhất của khách hàng
        [Obsolete]
        public DataTable KHLayNgayLap(string maKH)
        {
            string query = string.Format($"select max(ngaylap) from HOTELADMIN.phieudatphong where makh='{maKH}'");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        [Obsolete]
        public DataTable KHLayPDPMoiNhat(string maKH)
        {
            string query = string.Format($"select * from HOTELADMIN.phieudatphong " +
                                        $"where makh='{maKH}' and " +
                                        $"ngaylap = (select max(ngaylap) from HOTELADMIN.phieudatphong " +
                                                    $"where makh='{maKH}') ");

            return DataProvider.Instance.ExecuteQuery(query);
        }
        //Lấy mã phiếu đặt phòng gần nhất của khách hàng
        [Obsolete]
        public DataTable KHRetrieveLatestMAPDP(string maKH)
        {
            string query = string.Format($"select mapdp from HOTELADMIN.phieudatphong " +
                                        $"where makh='{maKH}' and ngaylap = (select max(ngaylap) " +
                                                                           $"from HOTELADMIN.phieudatphong " +
                                                                           $"where makh='{maKH}')");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        [Obsolete]//TO_DATE('{pdp.NGAYDEN.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY')
        public void KHCapNhatPhieuDatPhong(PhieuDatPhongBUS pdp)
        {
            string query = string.Format($"update HOTELADMIN.phieudatphong " +
                                            $"set    " +
                                            $"sodemluutru={pdp.SODEMLUUTRU},    " +
                                            $"ngayden = TO_DATE('{pdp.NGAYDEN.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY'),    " +
                                            $"songuoi= {pdp.SONGUOI} " +
                                            $"where mapdp='{pdp.MAPDP}'");
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tinhTrang">tình trạng phòng mới</param>
        /// <param name="maPDP">mã phiếu đặt phòng gần nhất</param>
        [Obsolete]
        public void KHCapNhatTinhTrangPDP(string tinhTrang, string maPDP)
        {
            string query = string.Format("update HOTELADMIN.phieudatphong " +
                                        $"set tinhtrang = '{tinhTrang}' " +
                                        $"where mapdp = '{maPDP}'");
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        [Obsolete]
        public void KHDeletePDP(string maPDP)
        {
            string query = string.Format($"delete from HOTELADMIN.phieudatphong where mapdp='{maPDP}'");
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
