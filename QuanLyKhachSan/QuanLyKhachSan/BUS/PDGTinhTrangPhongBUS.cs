using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class PDGTinhTrangPhongBUS
    {
        public string MAPDG { get; set; }
        public string MAPHONG { get; set; }
        public DateTime NGAYLAP { get; set; }
        public string MOTA { get; set; }
        public static string MANV { get; set; }

        private static PDGTinhTrangPhongBUS instance;
        public static PDGTinhTrangPhongBUS Instance
        {
            get { if (instance == null) instance = new PDGTinhTrangPhongBUS(); return instance; }
            set => instance = value;
        }
        public PDGTinhTrangPhongBUS() { }
        [Obsolete]
        public string BPGetPDGCode()
        {
            var code = PDGTinhTrangPhongDAO.Instance.BPGetPDGCodeFromDB();
            int count = Convert.ToInt32(code.Rows[0][0]);
            if (count < 10)
            {
                return $"PDG00{count + 1}";
            }

            return $"PDG0{count+1}";
        }

        [Obsolete]
        public int BPCheckValidPDG(PDGTinhTrangPhongBUS pdgttp)
        {
            //Kiểm tra xem mã phòng có trống không
            if(pdgttp.MAPHONG == "") 
            {
                return 0;
            }
            //Kiểm tra xem mô tả có trống không
            if(pdgttp.MOTA == "")
            {
                return 1;
            }
            //Kiểm tra xem mã phòng có tồn tại không
            if (!Instance.BPCheckExistPhongCode(pdgttp.MAPHONG))
            {
                return 2;
            }

            return 3;
        }

        [Obsolete]
        public bool BPCheckExistPhongCode(string maPhong)
        {
            var temp = PhongDAO.Instance.BPSelectPDGCodeFromDB(maPhong);
            if (Convert.ToInt32(temp.Rows[0][0]) == 1)
            {
                return true;
            }
            return false;
        }
    }
}
