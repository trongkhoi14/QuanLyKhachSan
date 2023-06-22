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
        public DataTable KHLayDanhSach()
        {
            string query = string.Format("select p.maphong, lp.loaigiuong,lp.succhua, lp.giamotdem " +
                                        "from HOTELADMIN.phong p join HOTELADMIN.loaiphong lp " +
                                            "on p.loaiphong=lp.malp " +
                                        "where p.maphong not in (select maphong from HOTELADMIN.ct_phieudatphong) " +
                                        " and p.trangthai='O duoc'");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        [Obsolete]
        public void KHThemPhieuDatPhong(PhieuDatPhongBUS pdp)
        {
            string query = string.Format($"INSERT INTO HOTELADMIN.phieudatphong(MAPDP, TINHTRANG, NGAYLAP, NGAYDEN, SODEMLUUTRU, SONGUOI, MANV, MAKH) " +
               $"VALUES ('{pdp.MAPDP}', 'Chua coc', TO_DATE('{pdp.NGAYLAP.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY'), " +
               $"TO_DATE('{pdp.NGAYDEN.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY'), '{pdp.SODEMLUUTRU}', '{pdp.SONGUOI}', 'NV001', '{PhieuDatPhongBUS.MAKH}')");
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
        public DataTable KHRetrieveBookedPDP()
        {
            string query = string.Format(
            $"select p.mapdp, p.tinhtrang, p.ngaylap, p.ngayden, p.sodemluutru, p.songuoi, ct.maphong " +
            $"from HOTELADMIN.phieudatphong p join HOTELADMIN.ct_phieudatphong ct " +
                $"on p.mapdp = ct.mapdp " +
            $"where makh='{PhieuDatPhongBUS.MAKH}' " +
            $"order by p.mapdp");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        [Obsolete]
        //Lấy loại phòng mà khách hàng đã đặt
        public DataTable KhRetrieveRoomType()
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
                $"where pdp.makh='{PhieuDatPhongBUS.MAKH}' " +
                $" order by pdp.mapdp");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        [Obsolete]
        public DataTable KhRetrieveRoomTypeWithMaPDP(string maPDP)
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
                $"where pdp.makh='{PhieuDatPhongBUS.MAKH}' and  pdp.mapdp='{maPDP}'" +
                $" order by pdp.mapdp");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        //Lấy phiếu đặt phòng theo mã phiếu đặt phòng
        [Obsolete]
        public DataTable KHRetrievePDP(string maPDP)
        {
            string query = string.Format($"select * from HOTELADMIN.phieudatphong where mapdp='{maPDP}'");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        //Lấy giá thuê một đêm của phòng mà khách hàng đã đặt
        [Obsolete]
        public DataTable KHRetrieveRentalFee(string maPDP)
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
        public DataTable KHRetrieveNGAYLAP(string maKH)
        {
            string query = string.Format($"select max(ngaylap) from HOTELADMIN.phieudatphong where makh='{maKH}'");
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
    }
}
