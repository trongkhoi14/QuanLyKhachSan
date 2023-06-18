using System;
using System.Collections.Generic;
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
    }
}
