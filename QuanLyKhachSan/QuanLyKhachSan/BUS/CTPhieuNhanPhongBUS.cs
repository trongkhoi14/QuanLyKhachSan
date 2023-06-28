using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class CTPhieuNhanPhongBUS
    {
        private static CTPhieuNhanPhongBUS instance;
        public static CTPhieuNhanPhongBUS Instance
        {
            get { if (instance == null) instance = new CTPhieuNhanPhongBUS(); return instance; }
            set => instance = value;
        }
        private CTPhieuNhanPhongBUS() { }

        [Obsolete]
        public DataTable LTLayDSKhachHangNhanPhong(string maPNP)
        {
            return CTPhieuNhanPhongDAO.Instance.LTLayDSKhachHangNhanPhong(maPNP);
        }

        [Obsolete]
        public bool LTKiemTraDangKyLuuTru(string mapnp)
        {
            //Lấy số khách khi đặt phòng
            DataTable pdp = CTPhieuNhanPhongDAO.Instance.LTLayThongTinDatPhong(mapnp);
            int soKhach = 0;
            Int32.TryParse(pdp.Rows[0]["SONGUOI"].ToString(), out soKhach);
            //Lấy số khách đã đăng ký lưu trú
            DataTable dslt = CTPhieuNhanPhongDAO.Instance.LTLayDSKhachHangNhanPhong(mapnp);
            int soKhachDaDangKy = dslt.Rows.Count;
            if(soKhach == soKhachDaDangKy)
            {
                return true;
            }
            return false;
        }

        [Obsolete]
        public bool LTThemCTPhieuNhanPhong(string mapnp, string makh)
        {
            //Lấy số khách khi đặt phòng
            DataTable pdp = CTPhieuNhanPhongDAO.Instance.LTLayThongTinDatPhong(mapnp);
            int soKhach = 0;
            Int32.TryParse(pdp.Rows[0]["SONGUOI"].ToString(), out soKhach);
            //Lấy số khách đã đăng ký lưu trú
            DataTable dslt = CTPhieuNhanPhongDAO.Instance.LTLayDSKhachHangNhanPhong(mapnp);
            int soKhachDaDangKy = dslt.Rows.Count;
            if(soKhach > soKhachDaDangKy)
            {
                try
                {
                    CTPhieuNhanPhongDAO.Instance.LTThem(mapnp, makh);
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
           
        }

        [Obsolete]
        public bool LTXoaCTPhieuNhanPhong(string mapnp, string makh)
        {
            try
            {
                CTPhieuNhanPhongDAO.Instance.LTXoa(mapnp, makh);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        [Obsolete]
        public bool LTKiemTraDaTonTai(string mapnp, string makh)
        {
            DataTable ctpnp = CTPhieuNhanPhongDAO.Instance.LTLay(mapnp, makh);
            if(ctpnp.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }



}
