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
        public DataTable KHLayDanhSachPDP()
        {
            return PhieuDatPhongDAO.Instance.KHLayDanhSach();
        }
        public int KHKiemTraThongTinPDP(PhieuDatPhongBUS pdp, DataGridView dsPhong, bool isCheckDoan)
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
            DataTable a = PhieuDatPhongDAO.Instance.KhRetrieveRoomType();
            return PhieuDatPhongDAO.Instance.KhRetrieveRoomType();
        }
    }
}
