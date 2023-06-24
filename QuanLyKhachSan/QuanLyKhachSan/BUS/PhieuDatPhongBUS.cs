using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.BUS
{
    public class PhieuDatPhongBUS
    {
        public string MAPDP { get; set; }
        public DateTime NGAYDEN { get; set; }
        public DateTime NGAYLAP { get; set; }
        public string SODEMLUUTRU { get; set; }
        public string SONGUOI { get; set; }
        public static string MAKH { get; set; }
        
        private static PhieuDatPhongBUS instance;
        public static PhieuDatPhongBUS Instance
        {
            get { if (instance == null) instance = new PhieuDatPhongBUS(); return instance; }
            set => instance = value;
        }
        public PhieuDatPhongBUS() { }

        [Obsolete]
        public DataTable LTLayDanhSachPDP()
        {
            return PhieuDatPhongDAO.Instance.LTLayDanhSach();
        }

        [Obsolete]
        public DataTable KHLayDanhSachPDP()
        {
            return PhieuDatPhongDAO.Instance.KHLayDanhSach();
        }

        [Obsolete]
        public int KHKiemTraThongTinPDP(PhieuDatPhongBUS pdp, DataGridView dsPhong, bool isCheckDoan, ComboBox thanhtoan)
        {
            //kiểm tra có thông tin nào trống không
            foreach (PropertyInfo prop in pdp.GetType().GetProperties())
            {
                if (prop.PropertyType == typeof(string))
                {
                    string value = (string)prop.GetValue(pdp);
                    if (string.IsNullOrEmpty(value))
                    {
                        return 0;
                    }
                }
            }
            //kiểm tra xem có chọn phương thức thanh toán chưa
            if(thanhtoan.SelectedIndex == -1)
            {
                return 6;
            }

            string patternNUMBER = "^[0-9]+$";

            //số người trong đoàn, hoặc số đêm lưu trú không hợp lệ
            if (!Regex.IsMatch(pdp.SONGUOI, patternNUMBER) ||
                !Regex.IsMatch(pdp.SODEMLUUTRU, patternNUMBER))
            {
                return 1;
            }

            
            //kiểm tra ngày đến
            if (pdp.NGAYDEN < DateTime.Today)
            {
                return 2;
            }

            //kiểm tra xem có chọn phòng nào chưa
            int checkedColumnIndex = dsPhong.Columns["Select"].Index;
            bool hasCheckedBox = false;
            foreach (DataGridViewRow row in dsPhong.Rows)
            {
                if (row.Cells[checkedColumnIndex] != null && row.Cells[checkedColumnIndex].Value != null)
                {
                    bool isChecked = (bool)row.Cells[checkedColumnIndex].Value;
                    if (isChecked)
                    {
                        hasCheckedBox = true;
                        break;
                    }
                }
            }
            if (!hasCheckedBox)
            {
                return 3;
            }
            //kiểm tra số người trong đoàn lớn hơn 1
            if (isCheckDoan && int.Parse(pdp.SONGUOI) < 2)
            {
                return 4;
            }
            //Hai lần đặt phòng phải cách nhau ít nhất 5 ngày
            var latestDate = Convert.ToDateTime(PhieuDatPhongDAO.Instance.KHRetrieveNGAYLAP(PhieuDatPhongBUS.MAKH).Rows[0][0]);
            TimeSpan twoDateInterval = pdp.NGAYLAP - latestDate;
            if (twoDateInterval.Days<5)
            {
                return 7;
            }

            return 5;
        }

        [Obsolete]
        public string KHLayMaPDP()
        {
            var dt = PhieuDatPhongDAO.Instance.KHLayMaPDPMoiNhat();
            int count = Convert.ToInt32(dt.Rows[0][0]);
            return $"PDP0{count+1}";
        }
        [Obsolete]
        public void KHThemPDP(PhieuDatPhongBUS pdp)
        {
            PhieuDatPhongDAO.Instance.KHThemPhieuDatPhong(pdp);
        }
        [Obsolete]
        public DataTable KHLayPhieuDatPhong()
        {
            return PhieuDatPhongDAO.Instance.KHRetrieveBookedPDP();
        }
        [Obsolete]
        public DataTable KHLayThongTinPhongDaDat()
        {
            return PhieuDatPhongDAO.Instance.KhRetrieveRoomType();
        }

        [Obsolete]
        public DataTable KHLayThongTinPhongDaDatTheoMaPDP(string maPDP)
        {
            return PhieuDatPhongDAO.Instance.KhRetrieveRoomTypeWithMaPDP(maPDP);
        }
        [Obsolete]
        public string KHLayMaPDPGanNhat(string maKH)
        {
            var temp = PhieuDatPhongDAO.Instance.KHRetrieveLatestMAPDP(maKH);
            string output = (temp.Rows[0][0]).ToString();

            return output;
        }

        [Obsolete]
        public DataTable KHLayPDP(string maPDP)
        {
            return PhieuDatPhongDAO.Instance.KHRetrievePDP(maPDP);
        }

        [Obsolete]
        public void KHCapNhatPDP(PhieuDatPhongBUS pdp)
        {
            PhieuDatPhongDAO.Instance.KHCapNhatPhieuDatPhong(pdp);
        }
        [Obsolete]
        public int CheckValidNewPDP(PhieuDatPhongBUS newPDP)
        {
            var oldPDP = PhieuDatPhongBUS.Instance.KHLayPDP(newPDP.MAPDP);

            //có ô trống
            if(newPDP.SONGUOI =="" || newPDP.SODEMLUUTRU == "")
            {
                return 1;
            }

            string patternNUMBER = "^[0-9]+$";
            //số người trong đoàn không hợp lệ
            if (!Regex.IsMatch(newPDP.SONGUOI, patternNUMBER))
            {
                return 2;
            }
            //số đêm lưu trú
            if (!Regex.IsMatch(newPDP.SODEMLUUTRU, patternNUMBER))
            {
                return 3;
            }
            //kiểm tra ngày đến
            if (newPDP.NGAYDEN < DateTime.Today)
            {
                return 4;
            }

            //kiểm tra nếu không có thông tin nào thay đổi
            if (newPDP.SONGUOI == oldPDP.Rows[0]["SONGUOI"]&&
                newPDP.SODEMLUUTRU == oldPDP.Rows[0]["SODEMLUUTRU"]&&
                newPDP.NGAYDEN == DateTime.Parse((string)oldPDP.Rows[0]["NGAYDEN"]))
            {
                return 5;
            }

            return 0;
        }

        [Obsolete]
        public void KHCapNhatTinhTrangPDP(string tinhTrangPDP)
        {
            PhieuDatPhongDAO.Instance.KHCapNhatTinhTrangPDP(tinhTrangPDP);
        }

        [Obsolete]
        public bool KHCheckDaCoc()
        {
            var temp = PhieuDatPhongBUS.Instance.KHLayPDP(PhieuDatPhongBUS.Instance.KHLayMaPDPGanNhat(PhieuDatPhongBUS.MAKH));
            if (temp.Rows[0]["TINHTRANG"] == "Da coc")
            {
                return true;
            }
            return false;
        }
    }
}
