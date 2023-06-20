using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
        public DataTable LayDanhSachPDP()
        {
            return PhieuDatPhongDAO.Instance.LayDanhSach();
        }
        public bool KiemTraThongTinPDP(PhieuDatPhongBUS pdp)
        {
            string patternNUMBER = @"^-?\d+$";

            //số điện thoại, số fax, số người, hoặc số đêm lưu trú không hợp lệ
            if (!Regex.IsMatch(pdp.SONGUOI, patternNUMBER) || 
                !Regex.IsMatch(pdp.SODEMLUUTRU, patternNUMBER))
            {
                return false;
            }

            foreach (PropertyInfo prop in pdp.GetType().GetProperties())
            {
                if (prop.PropertyType == typeof(string))
                {
                    string value = (string)prop.GetValue(pdp);
                    if (string.IsNullOrEmpty(value))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        [Obsolete]
        public DataTable LayMaPDPGanNhat()
        {
            return PhieuDatPhongDAO.Instance.LayMaPDPMoiNhat();
        }
        //Tạo mã phiếu đặt phòng
        public string CurrentMaPDP(string mapdp)
        {
            string prefix = mapdp.Substring(0, 3); 
            int number = int.Parse(mapdp.Substring(3)); 
            number++; 
            string output = $"{prefix}{number:000}"; 
            return output;
        }

        [Obsolete]
        public void ThemPDP(PhieuDatPhongBUS pdp)
        {
            PhieuDatPhongDAO.Instance.ThemPhieuDatPhong(pdp);
        }
    }
}
