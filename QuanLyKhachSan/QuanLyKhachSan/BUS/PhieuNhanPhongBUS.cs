using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class PhieuNhanPhongBUS
    {
        private static PhieuNhanPhongBUS instance;
        public static PhieuNhanPhongBUS Instance
        {
            get { if (instance == null) instance = new PhieuNhanPhongBUS(); return instance; }
            set => instance = value;
        }
        private PhieuNhanPhongBUS() { }

        [Obsolete]
        public void LTThemPNP(string maPDP)
        {
            //Kiểm tra đã có phiếu nhận phòng tương ứng với phiếu đặt phòng hay chưa
            DataTable pnp = PhieuNhanPhongDAO.Instance.LTLayPNP(maPDP);
            //Nếu chưa có phiếu nhận phòng thì thêm
            if (pnp.Rows.Count == 0)
            {
                //Lấy danh sách phiếu nhận phòng
                DataTable dsPhieuNhanphong = PhieuNhanPhongDAO.Instance.LTLayDanhSachPNP();
                //Tạo mã phiếu nhận phòng
                int soPhieu = dsPhieuNhanphong.Rows.Count;
                soPhieu = soPhieu + 1;
                string maPNP = $"PNP00{soPhieu}";
                //Thêm phiếu nhận phòng
                int r = PhieuNhanPhongDAO.Instance.LTThem(maPNP, maPDP,DataProvider.Instance.username);
            }
        }
        [Obsolete]
        public string LTLayMaPNP(string maPDP)
        {
            try
            {
                DataTable pnp = PhieuNhanPhongDAO.Instance.LTLayPNP(maPDP);
                return pnp.Rows[0]["MAPNP"].ToString();
            }
            catch (Exception)
            {
                return "";
            }
            
        }
    }
}
