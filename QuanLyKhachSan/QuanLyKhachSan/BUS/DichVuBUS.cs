using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class DichVuBUS
    {
        private static DichVuBUS instance;

        public static DichVuBUS Instance
        {
            get { if (instance == null) instance = new DichVuBUS(); return instance; }
            set => instance = value;
        }

        public DichVuBUS() { }

        public DichVuBUS(string MaDV, string TenDV, string DonViTinh, double GiaDV, string LoaiDV)
        {
            this.MaDV = MaDV;
            this.TenDV = TenDV;
            this.DonViTinh = DonViTinh;
            this.GiaDV = GiaDV;
            this.LoaiDV = LoaiDV;
        }

        [Obsolete]
        public DataTable LayDSDV()
        {
            return DichVuDAO.Instance.LayDSDV();
        }

        [Obsolete]
        public DataTable LayDVTheoMaDV(string MaDV)
        {
            return DichVuDAO.Instance.LayDVTheoMaDV(MaDV);
        }

        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public string DonViTinh { get; set; }
        public double GiaDV { get; set; }
        public string LoaiDV { get; set; }

        public bool ThemDV(string madv, string tendv, string donvitinh, string gia, string loai)
        {
            try
            {
                if (DichVuDAO.Instance.ThemDV(madv, tendv, donvitinh, gia, loai) > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [Obsolete]
        public bool XoaDV(string madv)
        {
            try
            {
                if (DichVuDAO.Instance.XoaDV(madv) > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [Obsolete]
        public bool CapNhatDV(string madv, string tendv, string donvitinh, string gia, string loai)
        {
            try
            {
                if (DichVuDAO.Instance.CapNhatDV(madv, tendv, donvitinh, gia, loai) > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
