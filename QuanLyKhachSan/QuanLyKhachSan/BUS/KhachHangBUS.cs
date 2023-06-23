using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class KhachHangBUS
    {
        private static KhachHangBUS instance;
        public static KhachHangBUS Instance
        {
            get { if (instance == null) instance = new KhachHangBUS(); return instance; }
            set => instance = value;
        }
        private KhachHangBUS() { }
        public bool LTKiemTraTonTai(string tenkh, string diachi, string ngaysinh)
        {

            return true;
        }
    }
}
