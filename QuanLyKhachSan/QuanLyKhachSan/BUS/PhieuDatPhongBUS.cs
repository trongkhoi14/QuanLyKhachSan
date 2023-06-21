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
        public DataTable KHLayDanhSachPDP()
        {
            return PhieuDatPhongDAO.Instance.KHLayDanhSach();
        }
        public bool KHKiemTraThongTinPDP(PhieuDatPhongBUS pdp)
        {
            string patternNUMBER = @"^-?\d+$";

            //số điện thoại, số fax, số người, hoặc số đêm lưu trú không hợp lệ
            if (!Regex.IsMatch(pdp.SONGUOI, patternNUMBER) || 
                !Regex.IsMatch(pdp.SODEMLUUTRU, patternNUMBER))
            {
                return false;
            }

            //kiểm tra có thông tin nào trống không
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
            //kiểm tra ngày đến
            if (pdp.NGAYDEN < DateTime.Today)
            {
                return false;
            }

            return true;
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
    }
}
